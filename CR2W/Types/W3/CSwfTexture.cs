using System;

using CR2W.IO;

namespace CR2W.Types.W3
{
    public class CSwfTexture : CBitmapTexture
    {
        [REDProp("linkageName")]
        public string LinkageName { get; set; }
    }
}
