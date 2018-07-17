using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.IO
{
    public struct SResource
    {
        public uint offset;
        public ushort typeid;
        public ushort flags;

        public string path;
        public string type;
    }
}
