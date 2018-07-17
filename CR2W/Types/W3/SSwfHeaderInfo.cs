using System;


namespace CR2W.Types.W3
{
    [REDClass]
    public struct SSwfHeaderInfo
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