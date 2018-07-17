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
    public struct Soft<T> where T : CResource
    {
        //Do not chanage names
        public string DepotPath { get; set; }
        public ushort Flags     { get; set; }

        public Type SoftOf
        {
            get
            {
                return typeof(T);
            }
        }
    }
}