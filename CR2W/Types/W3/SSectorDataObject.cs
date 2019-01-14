using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SSectorDataObject
    {
        public byte type { get; set; }
        public byte flags { get; set; }
        public ushort radius { get; set; }
        public ulong offset { get; set; }
        public float positionX { get; set; }
        public float positionY { get; set; }
        public float positionZ { get; set; }

        //blockdata
        [TypeConverter(typeof(ListConverter))]
        public List<byte> blockdata { get; set; }

    }
}
