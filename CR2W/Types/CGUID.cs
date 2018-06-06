using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types
{
    public sealed class CGUID
    {
        private Guid _value;

        public CGUID( Guid value )
        {
            _value = value;
        }

        public CGUID( byte[] value )
        {
            _value = new Guid(value);
        }

        public CGUID( string value )
        {
            _value = Guid.Parse(value);
        }

        public static implicit operator CGUID( Guid value )
        {
            return new CGUID(value);
        }

        public static implicit operator Guid( CGUID value )
        {
            return value._value;
        }
    }
}
