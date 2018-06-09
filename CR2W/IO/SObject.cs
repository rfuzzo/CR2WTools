using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.IO
{
    public struct SObject
    {
        public ushort typeID;
        public ushort flags;
        public uint parentID;
        public uint size;
        public uint offset;
        public uint template;
    }
}
