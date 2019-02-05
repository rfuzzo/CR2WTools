using System;
using System.Reflection;

namespace RED.CR2W
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
