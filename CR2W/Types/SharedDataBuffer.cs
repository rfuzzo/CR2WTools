using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.Types.W3;

namespace CR2W.Types
{
    [REDPrimitive]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public struct SharedDataBuffer
    {

        //dbg
        [TypeConverter(typeof(ListConverter))]
        public byte[] data;

        [TypeConverter(typeof(ListConverter))]
        public List<CObject> buffer { get; set; }

        

    }
}
