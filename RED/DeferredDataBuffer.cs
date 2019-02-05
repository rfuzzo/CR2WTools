using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RED.CR2W;

namespace RED
{
    public class DeferredDataBuffer : DataBuffer
    {
        public uint Flags   { get; set; }
        public ushort Value { get; set; }
    }
}