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
        public override string ToString()
        {
            var sb = new StringBuilder("[");
            foreach (var item in this)
            {
                if(sb.Length > 1)
                {
                    sb.Append(", ");
                }
                sb.Append(item.ToString());
            }
            sb.Append("]");
            return sb.ToString();
        }
    }
}
