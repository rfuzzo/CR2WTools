using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
    public struct SSectorDataObject
    {
        public byte type;
        public byte flags;
        public ushort radius;
        public ulong offset;
        public float positionX;
        public float positionY;
        public float positionZ;
    }
}
