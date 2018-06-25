using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.IO
{
    public class InvalidCR2WFileException : Exception
    {
        public InvalidCR2WFileException()
        {

        }

        public InvalidCR2WFileException(string message) : base(message)
        {

        }

        public InvalidCR2WFileException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
