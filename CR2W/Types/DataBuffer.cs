using CR2W.Types.W3;
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
    public struct DataBuffer
    {
        //dbg
        [TypeConverter(typeof(ListConverter))]
        public byte[] data;

        [TypeConverter(typeof(ListConverter))]
        public List<CObject> buffer { get; set; }
    }
}
