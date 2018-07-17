using System;
using System.IO;
using System.Drawing;
using CR2W.IO;
using CR2W.DDS.Utils;
using CR2W.DDS;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
    public class CBitmapTexture : CResource, ITexture
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
            var pos = br.BaseStream.Position;
            base.ParseBytes(br, size);

            var header = new DDSStruct();

            var unknown1        = br.ReadUInt32();
            var unknown2        = br.ReadUInt32();
            header.width        = br.ReadUInt32();
            header.height       = br.ReadUInt32();
            var unknown5        = br.ReadUInt32();
            header.sizeorpitch  = br.ReadUInt32();
            var unknown7        = br.ReadUInt32();

            header.size = 124;
            header.depth = 1;

            switch(Compression)
            {
                case ETextureCompression.TCM_DXTAlpha:
                case ETextureCompression.TCM_DXTAlphaLinear:
                case ETextureCompression.TCM_None:
                case ETextureCompression.TCM_Normals:
                case ETextureCompression.TCM_NormalsGloss:
                case ETextureCompression.TCM_NormalsHigh:
                case ETextureCompression.TCM_QualityR:
                case ETextureCompression.TCM_QualityRG:
                case ETextureCompression.TCM_RGBE:
                    header.pixelformat.fourcc = DDS.Utils.Helper.FOURCC_DXT5;
                    break;
                case ETextureCompression.TCM_DXTNoAlpha:
                    header.pixelformat.fourcc = DDS.Utils.Helper.FOURCC_DXT1;
                    break;
            }

            header.ddscaps.caps1 = 4096;
            header.mipmapcount = 1;
            header.pixelformat.flags = 4;
            header.pixelformat.size = 32;
            header.reserved = new uint[10];
            header.flags = 659463;

            var rawsize = Convert.ToInt32(pos + size - br.BaseStream.Position);
            var raw = br.ReadBytes(rawsize);

            var dds = new DDSImage(raw, header, true);

            Form form = new Form
            {
                Text = "Image"
            };
            PictureBox pictureBox = new PictureBox
            {
                Image = dds.BitmapImage,
                Width = (int)header.width,
                Height = (int)header.height
            };
            form.Controls.Add(pictureBox);
            var t = new Task(() => 
            {
                Application.Run(form);
            });
            t.Start();
        }
    }
}