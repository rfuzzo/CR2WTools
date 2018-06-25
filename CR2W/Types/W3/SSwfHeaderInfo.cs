using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
    public class SSwfHeaderInfo
    {
        [REDProp("frameRate")]
        public float FrameRate { get; set; }

        [REDProp("frameHeight")]
        public float FrameHeight { get; set; }

        [REDProp("frameWidth")]
        public float FrameWidth { get; set; }

        [REDProp("frameCount")]
        public uint FrameCount { get; set; }

        [REDProp("height")]
        public float Height { get; set; }

        [REDProp("width")]
        public float Width { get; set; }

        [REDProp("version")]
        public uint Version { get; set; }

        [REDProp("compressed")]
        public bool Compressed { get; set; }
    }
}