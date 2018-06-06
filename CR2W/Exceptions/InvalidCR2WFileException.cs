using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Exceptions
{
    public class InvalidCR2WFileException : Exception
    {
        public InvalidCR2WFileException(string message) : base(message)
        {

        }
    }
}
