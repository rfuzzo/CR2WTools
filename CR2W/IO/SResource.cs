using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.IO
{
    public struct SResource
    {
        public string path;
        public string type;
        public ushort flags;

        public SResource(string p, string t, ushort f)
        {
            path = p;
            type = t;
            flags = f;
        }
    }
}
