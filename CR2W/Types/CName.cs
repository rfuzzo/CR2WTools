using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types
{
    [REDPrimitive]
    [TypeConverter(typeof(string))]
    public struct CName
    {
        private string _value;

        public static implicit operator CName(string value)
        {
            return new CName(value);
        }

        public static implicit operator string(CName value)
        {
            return value._value;
        }

        public CName(string value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return _value;
        }
    }
}
