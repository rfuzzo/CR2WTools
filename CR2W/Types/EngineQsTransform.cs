using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types
{
    [REDPrimitive]
    public struct EngineQsTransform
    {
        public float ScaleX { get; set; }
        public float ScaleY { get; set; }
        public float ScaleZ { get; set; }

        public float Pitch { get; set; }
        public float Yaw   { get; set; }
        public float Roll  { get; set; }
        public float RotW  { get; set; }

        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }

        public string QsType { get; set; }

        public byte Flags { get; set; }
    }
}
