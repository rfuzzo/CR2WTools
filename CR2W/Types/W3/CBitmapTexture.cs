using System;
using System.IO;
using System.Drawing;
using CR2W.IO;
using CR2W.Attributes;

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
            base.ParseBytes(br, size);
        }
    }
}