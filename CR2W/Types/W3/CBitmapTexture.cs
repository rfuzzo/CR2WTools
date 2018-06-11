using System;
using System.IO;
using System.Drawing;
using CR2W.IO;

namespace CR2W.Types.W3
{
    public class CBitmapTexture : CResource, ITexture
    {
        public uint Width { get; set; }
        public uint Height { get; set; }
        public ETextureRawFormat Format { get; set; }
        public ETextureCompression Compression { get; set; }
        public CHandle<CSourceTexture> SourceData { get; set; }
        public CName TextureGroup { get; set; }
        public int PCDownscaleBias { get; set; }
        public int XBoneDownscaleBias { get; set; }
        public int PS4DownscaleBias { get; set; }
        public int ResidentMipIndex { get; set; }
        public int TextureCacheKey { get; set; }

        public Bitmap TextureMap { get; set; }

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseBytes(br, size);
        }
    }
}
 