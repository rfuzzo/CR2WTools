using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.IO;
using CR2W.Types.W3;

namespace CR2W.Types
{
    public struct Ptr<T>
    {
        public uint Index { get; set; }

        public Type PtrOf
        {
            get
            {
                return typeof(T);
            }
        }

        
    }
}