using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types
{
    public struct CDateTime
    {
        private DateTime _value;

        public CDateTime( DateTime value )
        {
            _value = value;
        }
    }
}
