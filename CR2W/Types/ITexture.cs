using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.Types.W3;

namespace CR2W.Types
{
    public interface ITexture
    {
        UInt32 Width { get; set; }
        UInt32 Height { get; set; }
        ETextureRawFormat Format { get; set; }
        ETextureCompression Compression { get; set; }
        CHandle<CSourceTexture> SourceData { get; set; }
        CName TextureGroup { get; set; }
        Int32 PCDownscaleBias { get; set; }
        Int32 XBoneDownscaleBias { get; set; }
        Int32 PS4DownscaleBias { get; set; }
        Int32 ResidentMipIndex { get; set; }
        Int32 TextureCacheKey { get; set; }
    }
}
