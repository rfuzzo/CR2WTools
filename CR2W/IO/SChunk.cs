using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.IO
{
    public struct SChunk
    {
        public string type;
        public uint flags;
        public uint parentID;
        public byte[] data;
    }
}
