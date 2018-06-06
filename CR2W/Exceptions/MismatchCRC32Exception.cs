using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Exceptions
{
    public class MismatchCRC32Exception : Exception
    {
        public MismatchCRC32Exception(string message) : base(message)
        {

        }
    }
}
