using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.IO;

namespace CR2W.Attributes
{
    class ArrayAttribute : CR2WPropertyAttribute
    {
        public byte ValueA { get; set; }
        public byte ValueB { get; set; }

        private Type _type;

        public ArrayAttribute(string name, byte a, byte b, Type type) : base(name, "array")
        {
            ValueA = a;
            ValueB = b;

            _type = type;
        }
    }
}
