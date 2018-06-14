using System;

namespace CR2W.Types.W3
{
    public class SSwfHeaderInfo
    {
        public float frameRate { get; set; }
        public float frameHeight { get; set; }
        public float frameWidth { get; set; }
        public uint frameCount { get; set; }
        public float height { get; set; }
        public float width { get; set; }
        public uint version { get; set; }
        public bool compressed { get; set; }
    }
}