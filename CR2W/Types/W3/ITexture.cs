using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using CR2W.Types.W3;

namespace CR2W.Types.W3
{
    public interface ITexture
    {
        UInt32 Width { get; set; }
        UInt32 Height { get; set; }
        ETextureRawFormat Format { get; set; }
        ETextureCompression Compression { get; set; }
        Handle<CSourceTexture> SourceData { get; set; }
        CName TextureGroup { get; set; }
        Int32 PCDownscaleBias { get; set; }
        Int32 XBoneDownscaleBias { get; set; }
        Int32 PS4DownscaleBias { get; set; }
        byte ResidentMipIndex { get; set; }
        UInt32 TextureCacheKey { get; set; }
    }
}
