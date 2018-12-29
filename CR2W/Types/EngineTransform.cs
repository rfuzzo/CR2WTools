using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.IO;
using CR2W.Types.W3;

namespace CR2W.Types
{
    [REDPrimitive]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public struct EngineTransform
    {
        public float ScaleX { get; set; }
        public float ScaleY { get; set; }
        public float ScaleZ { get; set; }

        public float Pitch { get; set; }
        public float Yaw   { get; set; }
        public float Roll  { get; set; }

        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
    }
}