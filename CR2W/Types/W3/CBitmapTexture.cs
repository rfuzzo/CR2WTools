using CR2W.IO;
using System.IO;

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

        public override void ParseBytes(BinaryReader br, CR2WParser parser)
        {
            base.ParseBytes(br, parser);

            /* - ToDo:
             *   Read Bitmap texture bytes.
             */
        }
    }
}
 