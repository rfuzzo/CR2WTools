using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RED.DDS.Utils
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct Colour565
    {
        public ushort blue; //: 5;
        public ushort green; //: 6;
        public ushort red; //: 5;
    }
}
