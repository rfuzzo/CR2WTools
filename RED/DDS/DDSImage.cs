using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using RED.DDS.Utils;

namespace RED.DDS
{
    public class DDSImage : IDisposable
    {
        #region Fields and Properties
        private Bitmap    m_bitmap;
        private bool      m_isValid;
        private bool      m_alpha;
        private DDSStruct m_header;
        private Stream    m_stream;

        public Bitmap BitmapImage
        {
            get { return m_bitmap; }
        }
        public bool IsValid
        {
            get { return m_isValid; }
        }
        public bool PreserveAlpha
        {
            get { return m_alpha; }
            set { m_alpha = value; }
        }

        public const uint MAGIC = 0x20534444;
        #endregion

        #region Constructors
        public DDSImage(byte[] ddsImage, bool preserveAlpha = true)
        {
            if (ddsImage == null)
                throw new ArgumentNullException();

            if (ddsImage.Length == 0)
                throw new ArgumentException();

            m_alpha = preserveAlpha;

            m_stream = new MemoryStream(ddsImage);
            m_stream.Seek(0, SeekOrigin.Begin);
            Parse();
        }
        public DDSImage(Stream ddsImage, bool preserveAlpha = true)
        {
            if (ddsImage == null)
                throw new ArgumentNullException();

            if (!ddsImage.CanRead)
                throw new ArgumentException();

            m_alpha = preserveAlpha;
            m_stream = ddsImage;
            Parse();
        }
        #endregion

        #region Data Reading
        private void Parse()
        {
            var idString = new byte[4];
            m_stream.Read(idString, 0, 4);
            var signature = BitConverter.ToUInt32(idString, 0);
            if (signature != MAGIC)
            {
                throw new InvalidFileHeaderException();
            }

            m_header = ReadHeader();
            

            m_isValid = true;

            if (m_header.depth == 0)
                m_header.depth = 1;

            uint blocksize = 0;
            var pixelFormat = GetFormat(ref blocksize);
            if (pixelFormat == Utils.DDSPixelFormat.UNKNOWN)
            {
                throw new InvalidFileHeaderException();
            }

            var data = ReadData();
            if(data == null)
            {
                throw new InvalidDataException();
            }

            byte[] rawData = DDSDecompressor.Expand(m_header, data, pixelFormat);
            m_bitmap = CreateBitmap((int)m_header.width, (int)m_header.height, rawData);
        }
        private byte[] ReadData()
        {
            byte[] compdata = null;
            uint compsize = 0;

            if ((m_header.flags & DDSHelper.DDSD_LINEARSIZE) > 1)
            {
                compdata = new byte[m_header.sizeorpitch];
                m_stream.Read(compdata, 0, compdata.Length);
            }
            else
            {
                uint bps = m_header.width * m_header.pixelformat.rgbbitcount / 8;
                compsize = bps * m_header.height * m_header.depth;
                compdata = new byte[compsize];

                MemoryStream mem = new MemoryStream((int)compsize);

                byte[] temp = new byte[bps];
                for (int z = 0; z < m_header.depth; z++)
                {
                    for (int y = 0; y < m_header.height; y++)
                    {
                        m_stream.Read(temp, 0, temp.Length);
                        mem.Write(temp, 0, temp.Length);
                    }
                }
                mem.Seek(0, SeekOrigin.Begin);

                mem.Read(compdata, 0, compdata.Length);
                mem.Close();
            }

            return compdata;
        }
        private Bitmap CreateBitmap(int width, int height, byte[] rawData)
        {
            var pxFormat = PixelFormat.Format32bppRgb;
            if (m_alpha)
                pxFormat = PixelFormat.Format32bppArgb;

            Bitmap bitmap = new Bitmap(width, height, pxFormat);

            BitmapData data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.WriteOnly, pxFormat);
            IntPtr scan = data.Scan0;
            int size = bitmap.Width * bitmap.Height * 4;

            unsafe
            {
                byte* p = (byte*)scan;
                for (int i = 0; i < size; i += 4)
                {
                    // iterate through bytes.
                    // Bitmap stores it's data in RGBA order.
                    // DDS stores it's data in BGRA order.
                    p[i] = rawData[i + 2]; // blue
                    p[i + 1] = rawData[i + 1]; // green
                    p[i + 2] = rawData[i];   // red
                    p[i + 3] = rawData[i + 3]; // alpha
                }
            }

            bitmap.UnlockBits(data);
            return bitmap;
        }
        #endregion

        private DDSStruct ReadHeader()
        {
            var size = Marshal.SizeOf<DDSStruct>();
            var temp = new byte[size];
            var handle = GCHandle.Alloc(temp, GCHandleType.Pinned);

            m_stream.Read(temp, 0, size);
            var item = Marshal.PtrToStructure<DDSStruct>(handle.AddrOfPinnedObject());

            handle.Free();

            if (item.size != Marshal.SizeOf<DDSStruct>())
            {
                throw new InvalidFileHeaderException();
            }
            if (item.pixelformat.size != Marshal.SizeOf<DDSPixelForamtStruct>())
            {
                throw new InvalidFileHeaderException();
            }

            return item;
        }

        private DDSPixelFormat GetFormat(ref uint blocksize)
        {
            Utils.DDSPixelFormat format = Utils.DDSPixelFormat.UNKNOWN;
            if ((m_header.pixelformat.flags & DDSHelper.DDPF_FOURCC) == DDSHelper.DDPF_FOURCC)
            {
                blocksize = ((m_header.width + 3) / 4) * ((m_header.height + 3) / 4) * m_header.depth;

                switch (m_header.pixelformat.fourcc)
                {
                    case DDSHelper.FOURCC_DXT1:
                        format = Utils.DDSPixelFormat.DXT1;
                        blocksize *= 8;
                        break;

                    case DDSHelper.FOURCC_DXT2:
                        format = Utils.DDSPixelFormat.DXT2;
                        blocksize *= 16;
                        break;

                    case DDSHelper.FOURCC_DXT3:
                        format = Utils.DDSPixelFormat.DXT3;
                        blocksize *= 16;
                        break;

                    case DDSHelper.FOURCC_DXT4:
                        format = Utils.DDSPixelFormat.DXT4;
                        blocksize *= 16;
                        break;

                    case DDSHelper.FOURCC_DXT5:
                        format = Utils.DDSPixelFormat.DXT5;
                        blocksize *= 16;
                        break;

                    case DDSHelper.FOURCC_ATI1:
                        format = Utils.DDSPixelFormat.ATI1N;
                        blocksize *= 8;
                        break;

                    case DDSHelper.FOURCC_ATI2:
                        format = Utils.DDSPixelFormat.THREEDC;
                        blocksize *= 16;
                        break;

                    case DDSHelper.FOURCC_RXGB:
                        format = Utils.DDSPixelFormat.RXGB;
                        blocksize *= 16;
                        break;

                    case DDSHelper.FOURCC_DOLLARNULL:
                        format = Utils.DDSPixelFormat.A16B16G16R16;
                        blocksize = m_header.width * m_header.height * m_header.depth * 8;
                        break;

                    case DDSHelper.FOURCC_oNULL:
                        format = Utils.DDSPixelFormat.R16F;
                        blocksize = m_header.width * m_header.height * m_header.depth * 2;
                        break;

                    case DDSHelper.FOURCC_pNULL:
                        format = Utils.DDSPixelFormat.G16R16F;
                        blocksize = m_header.width * m_header.height * m_header.depth * 4;
                        break;

                    case DDSHelper.FOURCC_qNULL:
                        format = Utils.DDSPixelFormat.A16B16G16R16F;
                        blocksize = m_header.width * m_header.height * m_header.depth * 8;
                        break;

                    case DDSHelper.FOURCC_rNULL:
                        format = Utils.DDSPixelFormat.R32F;
                        blocksize = m_header.width * m_header.height * m_header.depth * 4;
                        break;

                    case DDSHelper.FOURCC_sNULL:
                        format = Utils.DDSPixelFormat.G32R32F;
                        blocksize = m_header.width * m_header.height * m_header.depth * 8;
                        break;

                    case DDSHelper.FOURCC_tNULL:
                        format = Utils.DDSPixelFormat.A32B32G32R32F;
                        blocksize = m_header.width * m_header.height * m_header.depth * 16;
                        break;

                    default:
                        format = Utils.DDSPixelFormat.UNKNOWN;
                        blocksize *= 16;
                        break;
                }
            }
            else
            {
                // uncompressed image
                if ((m_header.pixelformat.flags & DDSHelper.DDPF_LUMINANCE) == DDSHelper.DDPF_LUMINANCE)
                {
                    if ((m_header.pixelformat.flags & DDSHelper.DDPF_ALPHAPIXELS) == DDSHelper.DDPF_ALPHAPIXELS)
                    {
                        format = Utils.DDSPixelFormat.LUMINANCE_ALPHA;
                    }
                    else
                    {
                        format = Utils.DDSPixelFormat.LUMINANCE;
                    }
                }
                else
                {
                    if ((m_header.pixelformat.flags & DDSHelper.DDPF_ALPHAPIXELS) == DDSHelper.DDPF_ALPHAPIXELS)
                    {
                        format = Utils.DDSPixelFormat.RGBA;
                    }
                    else
                    {
                        format = Utils.DDSPixelFormat.RGB;
                    }
                }

                blocksize = (m_header.width * m_header.height * m_header.depth * (m_header.pixelformat.rgbbitcount >> 3));
            }
            return format;
        }

        public void Dispose()
        {
            m_stream.Dispose();
            if (m_bitmap != null)
            {
                m_bitmap.Dispose();
                m_bitmap = null;
            }
        }

        /*
        public void PrintHeader()
        {
            Console.WriteLine("header");
            Console.WriteLine("\tsize             {0}", m_header.size);
            Console.WriteLine("\tflags            {0}", m_header.flags);
            Console.WriteLine("\twidth            {0}", m_header.width);
            Console.WriteLine("\theight           {0}", m_header.height);
            Console.WriteLine("\tsizeorpitch      {0}", m_header.sizeorpitch);
            Console.WriteLine("\tdepth            {0}", m_header.depth);
            Console.WriteLine("\tmipmapcount      {0}", m_header.mipmapcount);
            Console.WriteLine("\talphabitdepth    {0}", m_header.alphabitdepth);
            for (int i = 0; i < m_header.reserved.Length; i++)
            {
                Console.WriteLine("\treserved[{0}]      {1}", i, m_header.reserved[i]);
            }
            Console.WriteLine("header.pixelformat");
            Console.WriteLine("\tsize             {0}", m_header.pixelformat.size);
            Console.WriteLine("\tflags            {0}", m_header.pixelformat.flags);
            Console.WriteLine("\tfourcc           {0}", m_header.pixelformat.fourcc);
            Console.WriteLine("\trgbbitcount      {0}", m_header.pixelformat.rgbbitcount);
            Console.WriteLine("\trbitmask         {0}", m_header.pixelformat.rbitmask);
            Console.WriteLine("\tgbitmask         {0}", m_header.pixelformat.gbitmask);
            Console.WriteLine("\tbbitmask         {0}", m_header.pixelformat.bbitmask);
            Console.WriteLine("\talphabitmask     {0}", m_header.pixelformat.alphabitmask);
            Console.WriteLine("header.ddscaps");
            Console.WriteLine("\tcaps1            {0}", m_header.ddscaps.caps1);
            Console.WriteLine("\tcaps2            {0}", m_header.ddscaps.caps2);
            Console.WriteLine("\tcaps3            {0}", m_header.ddscaps.caps3);
            Console.WriteLine("\tcaps4            {0}", m_header.ddscaps.caps4);
            Console.WriteLine();
        }
        */
    }
}