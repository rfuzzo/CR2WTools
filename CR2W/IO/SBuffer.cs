using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W
{
    public struct SBuffer
    {
        public uint flags;
        public uint index;
        public uint offset;
        public uint diskSize;
        public uint memSize;
        public uint crc32;
    }
}
