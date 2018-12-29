using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types
{
    [REDPrimitive]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public struct EntityHandle
    {
        public byte TagType { get; set; }
        public byte HandleType { get; set; }
        public byte Flag { get; set; }
        public CGUID Value { get; set; }
        public byte[] Unknown { get; set; }
    }
}
