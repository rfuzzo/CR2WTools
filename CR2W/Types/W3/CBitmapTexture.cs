using System;
using System.IO;
using System.Drawing;
using CR2W.IO;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
    public class CBitmapTexture : CResource, ITexture
    {
        [W3Type("width")]
        public uint Width { get; set; }

        [W3Type("height")]
        public uint Height { get; set; }

        [W3Type("format")]
        public ETextureRawFormat Format { get; set; }

        [W3Type("compression")]
        public ETextureCompression Compression { get; set; }

        [W3Type("sourceData")]
        public Handle<CSourceTexture> SourceData { get; set; }

        [W3Type("textureGroup")]
        public CName TextureGroup { get; set; }

        [W3Type("pcDownscaleBias")]
        public int PCDownscaleBias { get; set; }

        [W3Type("xboneDownscaleBias")]
        public int XBoneDownscaleBias { get; set; }

        [W3Type("ps4DownscaleBias")]
        public int PS4DownscaleBias { get; set; }

        [W3Type("residentMipIndex")]
        public byte ResidentMipIndex { get; set; }

        [W3Type("textureCacheKey")]
        public uint TextureCacheKey { get; set; }

        public Bitmap TextureMap { get; set; }

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseBytes(br, size);
        }
    }
}
 