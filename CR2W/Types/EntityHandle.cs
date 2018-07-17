using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types
{
    public struct EntityHandle
    {
        public byte Flag { get; set; }
        public byte Type { get; set; }
        public CGUID Value { get; set; }
    }
}
