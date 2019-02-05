using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RED.DDS.Utils
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Colour8888
    {
        public byte red;
        public byte green;
        public byte blue;
        public byte alpha;
    }
}
