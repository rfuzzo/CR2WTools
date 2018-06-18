using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
    public class SSwfFontDesc
    {
        [W3Type("fontName")]
        public string FontName { get; set; }

        [W3Type("numGlyphs")]
        public uint NumGlyphs { get; set; }

        [W3Type("italic")]
        public bool Italic { get; set; }

        [W3Type("bold")]
        public bool Bold { get; set; }
    }
}