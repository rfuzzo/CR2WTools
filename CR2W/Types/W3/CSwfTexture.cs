using System;
using CR2W.Attributes;
using CR2W.IO;

namespace CR2W.Types.W3
{
    public class CSwfTexture : CBitmapTexture
    {
        [W3Type("linkageName")]
        public string LinkageName { get; set; }
    }
}
