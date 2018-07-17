using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.IO;
using CR2W.Types.W3;
using CR2W.Types;
using System.IO;

namespace CR2W.Types
{
    public class Array<T> : List<T>
    {
        public Type ArrayOf
        {
            get
            {
                return typeof(T);
            }
        }
    }
}
