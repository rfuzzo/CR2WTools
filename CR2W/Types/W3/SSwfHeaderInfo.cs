using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
    public class SSwfHeaderInfo
    {
        [W3Type("frameRate")]
        public float FrameRate { get; set; }

        [W3Type("frameHeight")]
        public float FrameHeight { get; set; }

        [W3Type("frameWidth")]
        public float FrameWidth { get; set; }

        [W3Type("frameCount")]
        public uint FrameCount { get; set; }

        [W3Type("height")]
        public float Height { get; set; }

        [W3Type("width")]
        public float Width { get; set; }

        [W3Type("version")]
        public uint Version { get; set; }

        [W3Type("compressed")]
        public bool Compressed { get; set; }
    }
}