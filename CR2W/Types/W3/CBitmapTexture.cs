using System;
using System.IO;
using System.Drawing;
using CR2W.IO;
using CR2W.DDS.Utils;
using CR2W.DDS;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
    [TypeConverter(typeof(ExpandableObjectConverter))]public class CBitmapTexture : CResource, ITexture
    {
        [REDProp("width")]
        public uint Width { get; set; }

        [REDProp("height")]
        public uint Height { get; set; }

        [REDProp("format")]
        public ETextureRawFormat Format { get; set; }

        [REDProp("compression")]
        public ETextureCompression Compression { get; set; }

        [REDProp("sourceData")]
        public Handle<CSourceTexture> SourceData { get; set; }

        [REDProp("textureGroup")]
        public CName TextureGroup { get; set; }
        /*  - All possible options.
         *  
         *  BillboardAtlas
         *  CharacterDiffuse
         *  CharacterDiffuseWithAlpha
         *  CharacterEmissive
         *  CharacterNormal
         *  CharacterNormalHQ
         *  CharacterNormalmapGloss
         *  Default
         *  DetailNormalMap
         *  DiffuseNoMips
         *  Flares
         *  FoliageDiffuse
         *  Font
         *  GUIWithAlpha
         *  GUIWithoutAlpha
         *  HeadDiffuse
         *  HeadDiffuseWithAlpha
         *  HeadEmissive
         *  HeadNormal
         *  HeadNormalHQ
         *  MimicDecalsNormal
         *  NormalmapGloss
         *  NormalsNoMips
         *  Particles
         *  ParticlesWithoutAlpha
         *  PostFxMap
         *  QualityColor
         *  QualityOneChannel
         *  QualityTwoChannels
         *  SpecialQuestDiffuse
         *  SpecialQuestNormal
         *  SystemNoMips
         *  TerrainDiffuse
         *  TerrainNormal
         *  WorldDiffuse
         *  WorldDiffuseWithAlpha
         *  WorldEmissive
         *  WorldNormal
         *  WorldNormalHQ
         *  WorldSpecular
         */

        [REDProp("pcDownscaleBias")]
        public int PCDownscaleBias { get; set; }

        [REDProp("xboneDownscaleBias")]
        public int XBoneDownscaleBias { get; set; }

        [REDProp("ps4DownscaleBias")]
        public int PS4DownscaleBias { get; set; }

        [REDProp("residentMipIndex")]
        public byte ResidentMipIndex { get; set; }

        [REDProp("textureCacheKey")]
        public uint TextureCacheKey { get; set; }

        public Bitmap TextureMap { get; set; }

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseBytes(br, size);

            /*
             *  This is a temporary solution for reading the contents of a CBitmapTexture
             *  What this does is contruct a dds header object and parse it and the raw bytes 
             *  using the dds library.
             *  
             *  The bitmap bytes from the cr2w has a header 28 bytes long, containing data about the 
             *  image such as size and height etc...
             *  There are 4 unknown ones.
             *  
             *  This class should in the end support reading all xbm files with means supporting not just 
             *  dds but tga, bmp, png, and jpg.
             * 
             */

            var zero        = br.ReadUInt32();
            var mipCount    = br.ReadUInt32();
            var width       = br.ReadUInt32();
            var height      = br.ReadUInt32();
            var unknown5    = br.ReadUInt32();
            var sizeorpitch = br.ReadUInt32();

            Console.WriteLine("zero        {0}", zero);
            Console.WriteLine("mipCount    {0}", mipCount);
            Console.WriteLine("width       {0}", width);
            Console.WriteLine("height      {0}", height);
            Console.WriteLine("unknown5    {0}", unknown5);
            Console.WriteLine("sizeorpitch {0}", sizeorpitch);

            var ddsheader = new DDSStruct
            {
                size            = 124,
                flags           = 659463,
                width           = width,
                height          = height,
                sizeorpitch     = sizeorpitch,
                depth           = 1,
                mipmapcount     = 1,
                reserved        = new uint[10],
            };

            ddsheader.ddscaps.caps1 = 4096;
            ddsheader.pixelformat.size = 32;
            ddsheader.pixelformat.flags = 5;
            ddsheader.pixelformat.fourcc = DDSHelper.FOURCC_DXT1;

            var dds = new DDSImage(br, ddsheader, true);

            Form form = new Form
            {
                Text = "Image",
                ClientSize = new Size((int)width, (int)height),
            };
            PictureBox pictureBox = new PictureBox
            {
                Image = dds.BitmapImage,
                Width = (int)width,
                Height = (int)height
            };
            form.Controls.Add(pictureBox);
            var t = new Task(() =>
            {
                Application.Run(form);
            });
            t.Start();
        }

        public List<TexEncodePair> TEX_ENCODE_PAIRS = new List<TexEncodePair>()
        {
            new TexEncodePair(){code = 0x3FD, format = ETextureFormat.TEXFMT_R8G8B8A8},
            new TexEncodePair(){code = 0x40B, format = ETextureFormat.TEXFMT_Float_R16G16B16A16},
            new TexEncodePair(){code = 0x40C, format = ETextureFormat.TEXFMT_Float_R32G32B32A32},
            new TexEncodePair(){code = 0x407, format = ETextureFormat.TEXFMT_BC1},
            new TexEncodePair(){code = 0x40D, format = ETextureFormat.TEXFMT_BC2},
            new TexEncodePair(){code = 0x408, format = ETextureFormat.TEXFMT_BC3},
            new TexEncodePair(){code = 0x40E, format = ETextureFormat.TEXFMT_BC4},
            new TexEncodePair(){code = 0x40F, format = ETextureFormat.TEXFMT_BC5},
            new TexEncodePair(){code = 0x409, format = ETextureFormat.TEXFMT_BC6H},
            new TexEncodePair(){code = 0x40A, format = ETextureFormat.TEXFMT_BC7},
        };

        ETextureFormat DecodeTextureFormat(Int16 encoded)
        {
            return TEX_ENCODE_PAIRS.First(t => t.code == encoded).format;
        }

        public struct TexEncodePair
        {
            public UInt16 code;
            public ETextureFormat format;
        };

        public enum ETextureFormat
        {
            TEXFMT_A8 = 0x0,
            TEXFMT_A8_Scaleform = 0x1,
            TEXFMT_L8 = 0x2,
            TEXFMT_R8G8B8X8 = 0x3,
            TEXFMT_R8G8B8A8 = 0x4,
            TEXFMT_A8L8 = 0x5,
            TEXFMT_Uint_16_norm = 0x6,
            TEXFMT_Uint_16 = 0x7,
            TEXFMT_Uint_32 = 0x8,
            TEXFMT_R32G32_Uint = 0x9,
            TEXFMT_R16G16_Uint = 0xA,
            TEXFMT_Float_R10G10B10A2 = 0xB,
            TEXFMT_Float_R16G16B16A16 = 0xC,
            TEXFMT_Float_R11G11B10 = 0xD,
            TEXFMT_Float_R16G16 = 0xE,
            TEXFMT_Float_R32G32 = 0xF,
            TEXFMT_Float_R32G32B32A32 = 0x10,
            TEXFMT_Float_R32 = 0x11,
            TEXFMT_Float_R16 = 0x12,
            TEXFMT_D24S8 = 0x13,
            TEXFMT_D24FS8 = 0x14,
            TEXFMT_D32F = 0x15,
            TEXFMT_D16U = 0x16,
            TEXFMT_BC1 = 0x17,
            TEXFMT_BC2 = 0x18,
            TEXFMT_BC3 = 0x19,
            TEXFMT_BC4 = 0x1A,
            TEXFMT_BC5 = 0x1B,
            TEXFMT_BC6H = 0x1C,
            TEXFMT_BC7 = 0x1D,
            TEXFMT_R8_Uint = 0x1E,
            TEXFMT_NULL = 0x1F,
            TEXFMT_Max = 0x20,
        };
    }


}