using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
    public class SSwfFontDesc
    {
        [REDProp("fontName")]
        public string FontName { get; set; }

        [REDProp("numGlyphs")]
        public uint NumGlyphs { get; set; }

        [REDProp("italic")]
        public bool Italic { get; set; }

        [REDProp("bold")]
        public bool Bold { get; set; }
    }
}