using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types
{
    [REDPrimitive]
    public struct IdTag
    {
        public byte Flags { get; set; }
        public CGUID ID { get; set; }
    }
}
