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
    public struct DeferredDataBuffer
    {
        public ushort value;
    }
}
