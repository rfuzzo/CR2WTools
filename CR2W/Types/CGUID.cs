using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types
{
    /// <summary>
    /// Represents a globally unique identifier (CGUID). For use with CR2W files and the REDEngine.
    /// </summary>
    public struct CGUID : IFormattable, IComparable, IComparable<CGUID>, IEquatable<CGUID>
    {
        private uint A;
        private uint B;
        private uint C;
        private uint D;

        /// <summary>
        /// A read-only instance of the CR2W.Types.CGUID structure whose value is all zeros.
        /// </summary>
        public static readonly CGUID Empty = new CGUID(0,0,0,0);

        /// <summary>
        /// Initializes a new instance of the CR2W.Types.CGUID structure by using the specified array of bytes.
        /// </summary>
        /// <param name="value">A 16-element byte array containing values with which to initialize the GUID.</param>
        /// <exception cref="ArgumentException">value is not 16 bytes long.</exception>
        /// <exception cref="ArgumentNullException">value is null.</exception>
        public CGUID( byte[] value )
        {
            if(value == null)
            {
                throw new ArgumentNullException("Value cannot be null.");
            }
            if(value.Length != 16)
            {
                throw new ArgumentException("Byte array for CGUID must be exactly 16 bytes long.");
            }
            A = BitConverter.ToUInt32(value, 0);
            B = BitConverter.ToUInt32(value, 4);
            C = BitConverter.ToUInt32(value, 8);
            D = BitConverter.ToUInt32(value, 12);
        }

        public CGUID( string value )
        {
            var values = value.Split(new char[] { '-' });
            A = Convert.ToUInt32(values[0], 16);
            B = Convert.ToUInt32(values[1], 16);
            C = Convert.ToUInt32(values[2], 16);
            D = Convert.ToUInt32(values[3], 16);
        }

        /// <summary>
        /// Initializes a new instance of the CR2W.Types.CGUID structure by using the specified integers
        /// </summary>
        /// <param name="a">The first 4 bytes of the CGUID.</param>
        /// <param name="b">The next 4 bytes of the CGUID.</param>
        /// <param name="c">The next 4 bytes of the CGUID.</param>
        /// <param name="d">The last 4 bytes of the CGUID.</param>
        public CGUID( uint a, uint b, uint c, uint d )
        {
            A = a; B = b; C = c; D = d;
        }

        /// <summary>
        /// Initializes a new instance of the CR2W.Types.CGUID structure.
        /// </summary>
        /// <returns>A new CGUID object.</returns>
        public static CGUID NewCGUID()
        {
            var rand = new Random();
            var a = Convert.ToUInt32(rand.Next());
            var b = Convert.ToUInt32(rand.Next());
            var c = Convert.ToUInt32(rand.Next());
            var d = Convert.ToUInt32(rand.Next());
            return new CGUID(a, b, c, d);
        }

        /// <summary>
        /// Returns a value indicating whether this instance and a specified CR2W.Types.CGUID object represent the same value.
        /// </summary>
        /// <param name="other">An object to compare to this instance.</param>
        /// <returns>true if other is equal to this instance; otherwise, false.</returns>
        public bool Equals(CGUID other)
        {
            return this.GetHashCode() == other.GetHashCode();
        }

        /// <summary>
        /// Returns a value that indicates whether this instance is equal to a specified object
        /// </summary>
        /// <param name="o">The object to compare with this instance.</param>
        /// <returns>true if o is a CR2W.Types.CGUID that has the same value as this instance; otherwise, false.</returns>
        public override bool Equals(object o)
        {
            if(o is CGUID g)
            {
                return Equals(g);
            }
            return false;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(CGUID other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>The hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Returns a 16-element byte array that contains the value of this instance.
        /// </summary>
        /// <returns>A 16-element byte array.</returns>
        public byte[] ToByteArray()
        {
            return BitConverter.GetBytes(A).Concat(
                BitConverter.GetBytes(B).Concat(
                BitConverter.GetBytes(C).Concat(
                BitConverter.GetBytes(D)))).ToArray();
        }

        /// <summary>
        /// Returns a string representation of the value of this instance in registry format.
        /// </summary>
        /// <returns>
        /// The value of this CR2W.Types.CGUID, formatted by using the "D" format specifier as
        /// follows: XXXXXXXX-XXXXXXXX-XXXXXXXX-XXXXXXXX where the value of the CGUID is
        /// represented as a series of uppercase hexadecimal digits in groups of 8, 8, 8, and
        /// 8 digits and separated by hyphens. An example of a return value is "0C9691D9-74D7552B-3E7AF032-3E7AF032".
        /// To convert the hexadecimal digits from a through f to lowercase, call the System.String.ToLower
        /// method on the returned string.
        /// </returns>
        public override string ToString()
        {
            return ToString("D");
        }

        /// <summary>
        /// Returns a string representation of the value of this CR2W.Types.CGUID instance, according
        /// to the provided format specifier.
        /// </summary>
        /// <param name="format">
        /// A single format specifier that indicates how to format the value of this CR2W.Types.CGUID.
        /// The format parameter can be "N", "D", "B", "P", or "X". If format is null or
        /// an empty string (""), "D" is used.
        /// </param>
        /// <returns>
        /// The value of this CR2W.Types.CGUID, represented as a series of lowercase hexadecimal
        /// digits in the specified format.
        /// </returns>
        public string ToString(string format)
        {
            switch(format)
            {
                case "n":
                case "N":
                    return String.Format("{0:X8}{1:X8}{2:X8}{3:X8}", A, B, C, D);
                case "":
                case "d":
                case "D":
                case null:
                    return String.Format("{0:X8}-{1:X8}-{2:X8}-{3:X8}", A, B, C, D);
                case "p":
                case "P":
                    return String.Format("({0:X8}-{1:X8}-{2:X8}-{3:X8})", A, B, C, D);
                case "b":
                case "B":
                    return String.Format("{0}{1:X8}-{2:X8}-{3:X8}-{4:X8}{5}", "{", A, B, C, D, "}");
                case "x":
                case "X":
                    return String.Format("{0}0x{1:X8},0x{2:X8},0x{3:X8},0x{4:X8}{5}", "{", A, B, C, D, "}");
                default:
                    throw new FormatException("Format String can be only \"D\", \"d\", \"N\", \"n\", \"P\", \"p\", \"B\", \"b\", \"X\" or \"x\".");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Indicates whether the values of two specified CR2W.Types.CGUID objects are equal.
        /// </summary>
        /// <param name="a">The first object to compare.</param>
        /// <param name="b">The second object to compare.</param>
        /// <returns>true if a and b are equal; otherwise, false.</returns>
        public static bool operator ==(CGUID a, CGUID b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// Indicates whether the values of two specified CR2W.Types.CGUID objects are not equal.
        /// </summary>
        /// <param name="a">The first object to compare.</param>
        /// <param name="b">The second object to compare.</param>
        /// <returns>false if a and b are equal; otherwise, true.</returns>
        public static bool operator !=(CGUID a, CGUID b)
        {
            return !a.Equals(b);
        }
    }
}
