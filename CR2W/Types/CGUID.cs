using System;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace CR2W.Types
{
    /// <summary>
    /// Represents a globally unique identifier (CGUID). For use with CR2W files and the REDEngine.
    /// </summary>
    public struct CGUID : IFormattable, IComparable, IComparable<CGUID>, IEquatable<CGUID>
    {
        private static Random random = new Random();

        private BigInteger _value;

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
            this._value = new BigInteger(value);
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
            var bytes = new []{ a, b, c, d }.SelectMany(BitConverter.GetBytes).ToArray();
            _value = new BigInteger(bytes);
        }

        /// <summary>
        /// Initializes a new instance of the CR2W.Types.CGUID structure.
        /// </summary>
        /// <returns>A new CGUID object.</returns>
        public static CGUID NewCGUID()
        {
            byte[] bytes = new byte[16];
            random.NextBytes(bytes);
            return new CGUID(bytes);
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

        /// <summary>
        /// Compares this instance to a specified object and returns an indication of their 
        /// relative values.
        /// </summary>
        /// <param name="value">An object to compare, or null.</param>
        /// <returns>
        /// A signed number indicating the relative values of this instance and value.Return
        /// value Description A negative integer This instance is less than value. Zero This
        /// instance is equal to value. A positive integer This instance is greater than
        /// value, or value is null.
        /// </returns>
        /// <exception cref="ArgumentException">value is not a CR2W.Types.CGUID.</exception>
        public int CompareTo(object value)
        {
            if(value is CGUID g)
            {
                return CompareTo(g);
            }
            throw new ArgumentException("Object must be of type CGUID.");
        }

        /// <summary>
        /// Compares this instance to a specified CR2W.Types.CGUID object and returns an indication
        /// of their relative values.
        /// </summary>
        /// <param name="value">A signed number indicating the relative values of this instance and value.Return
        /// value Description A negative integer This instance is less than value. Zero This
        /// instance is equal to value. A positive integer This instance is greater than
        /// value.</param>
        /// <returns>An object to compare to this instance.</returns>
        public int CompareTo(CGUID value)
        {
            return this._value.CompareTo(value._value);
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
            var bytes = new byte[16];
            this._value.ToByteArray().CopyTo(bytes, 0);
            return bytes;
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
        /// <exception cref="FormatException">The value of format is not null, an empty string (""), "N", "D", "B", "P", or "X".</exception>
        public string ToString(string format)
        {
            var bytes = ToByteArray();
            var A = BitConverter.ToUInt32(bytes, 0);
            var B = BitConverter.ToUInt32(bytes, 4);
            var C = BitConverter.ToUInt32(bytes, 8);
            var D = BitConverter.ToUInt32(bytes, 12);
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

        /// <summary>
        /// Returns a string representation of the value of this instance of the System.Guid
        /// class, according to the provided format specifier and culture-specific format
        /// information.
        /// </summary>
        /// <param name="format">A single format specifier that indicates how to format the value of this System.Guid.
        /// The format parameter can be "N", "D", "B", "P", or "X". If format is null or
        /// an empty string (""), "D" is used.</param>
        /// <param name="provider">(Reserved) An object that supplies culture-specific formatting information.</param>
        /// <returns>
        /// The value of this System.Guid, represented as a series of lowercase hexadecimal
        /// digits in the specified format.
        /// </returns>
        /// <exception cref="FormatException">The value of format is not null, an empty string (""), "N", "D", "B", "P", or "X".</exception>
        public string ToString(string format, IFormatProvider provider)
        {
            if (provider == null)
            {
                provider = CultureInfo.CurrentCulture;
            }
            if (String.IsNullOrEmpty(format))
            {
                format = "D";
            }
            return String.Format(provider, ToString(format));
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
