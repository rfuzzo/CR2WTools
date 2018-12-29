using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.IO;
using CR2W.Types.W3;
using CR2W.Types;
using System.IO;
using System.ComponentModel;

namespace CR2W.Types
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
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
