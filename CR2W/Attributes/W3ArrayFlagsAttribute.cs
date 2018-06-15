using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Attributes
{
    class W3ArrayFlagsAttribute : Attribute
    {
        /// <summary>
        /// 1 dimensional arrays
        /// </summary>
        public W3ArrayFlagsAttribute( byte a, byte b )
        {

        }

        /// <summary>
        /// 2 dimensional arrays
        /// </summary>
        public W3ArrayFlagsAttribute(byte a, byte b, byte c, byte d)
        {

        }

        /// <summary>
        /// 3 dimensional arrays
        /// </summary>
        public W3ArrayFlagsAttribute(byte a, byte b, byte c, byte d, byte e, byte f)
        {

        }
    }
}
