using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.IO
{
    public struct SHeader
    {
        public uint offset;
        public uint size;
        public uint crc32;

        public SHeader(uint o, uint s, uint c)
        {
            offset = 0;
            size = s;
            crc32 = c;
        }
    }
}
