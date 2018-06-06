using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Exceptions
{
    class UnknownObjectTypeException : Exception
    {
        public UnknownObjectTypeException(string message) : base(message)
        {

        }
    }
}
