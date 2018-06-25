using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class REDSizeAttribute : Attribute
    {
        public byte Size { get; private set; }
        public REDSizeAttribute(byte size)
        {
            Size = size;
        }
    }
}
