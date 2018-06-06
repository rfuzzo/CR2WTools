using System;

namespace CR2W.Types.W3
{
    public class CSourceTexture : CResource
    {
        UInt32 Width { get; set; }
        UInt32 Height { get; set; }
        UInt32 Pitch { get; set; }
        ETextureRawFormat Format { get; set; }
    }
}
