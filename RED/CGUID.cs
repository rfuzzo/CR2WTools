using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace RED
{
    /// <summary>
    /// Represents a globally unique identifier (<see cref="CGUID"/>). For use with the REDEngine.
    /// </summary>
    [ImmutableObject(true)]
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public sealed class CGUID : IComparable, IComparable<CGUID>, IEquatable<CGUID>
    {
        // Raw uint values that make the 128 bit guid value;
        private uint _a;
        private uint _b;
        private uint _c;
        private uint _d;

        /// <summary>
        /// A read-only instance of the <see cref="CGUID"/> structure whose value is all zeros.
        /// </summary>
        public static readonly CGUID Empty = new CGUID();

        /// <summary>
        /// Initializes a new instance of the <see cref="CGUID"/> class.
        /// </summary>
        public CGUID()
        {
            _a = 0;
            _b = 0;
            _c = 0;
            _d = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CGUID"/> structure by using the specified array of bytes.
        /// </summary>
        /// <param name="value">A 16-element byte array containing values with which to initialize the GUID.</param>
        /// <exception cref="ArgumentException">value is not 16 bytes long.</exception>
        /// <exception cref="ArgumentNullException">value is null.</exception>
        public CGUID(byte[] value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "Value cannot be null.");
            }
            if (value.Length != 16)
            {
                throw new ArgumentException("Byte array for CGUID must be exactly 16 bytes long.");
            }
            unsafe
            {
                fixed (byte* bPtr = value)
                {
                    _a = ((uint*)bPtr)[0];
                    _b = ((uint*)bPtr)[1];
                    _c = ((uint*)bPtr)[2];
                    _d = ((uint*)bPtr)[3];
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CGUID"/> class by using the specified integers
        /// </summary>
        /// <param name="a">The first 4 bytes of the <see cref="CGUID"/>.</param>
        /// <param name="b">The next 4 bytes of the <see cref="CGUID"/>.</param>
        /// <param name="c">The next 4 bytes of the <see cref="CGUID"/>.</param>
        /// <param name="d">The last 4 bytes of the <see cref="CGUID"/>.</param>
        public CGUID(uint a, uint b, uint c, uint d)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
        }

        /// <summary>
        /// Initializes a new instance of the RED.CGUID class by using the value represented
        /// by the specified string.
        /// </summary>
        /// <param name="value">
        /// A string represeting the CGUID value in the following format: xxxxxxxx-xxxxxxxx-xxxxxxxx-xxxxxxxx, (case insensitive).
        /// </param>
        public CGUID(string value)
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentNullException(nameof(value));

            var match = Regex.Match(value, "^([0-9a-f]{8})-([0-9a-f]{8})-([0-9a-f]{8})-([0-9a-f]{8})$", RegexOptions.IgnoreCase);

            if (!match.Success)
                throw new FormatException("CGUID should contain 32 hexadecimal digits with 3 dashes: xxxxxxxx-xxxxxxxx-xxxxxxxx-xxxxxxxx");

            _a = Convert.ToUInt32(match.Groups[1].Value, 16);
            _b = Convert.ToUInt32(match.Groups[2].Value, 16);
            _c = Convert.ToUInt32(match.Groups[3].Value, 16);
            _d = Convert.ToUInt32(match.Groups[4].Value, 16);
        }

        /// <summary>
        /// Creates and returns a new random <see cref="CGUID"/> value.
        /// </summary>
        /// <returns>A new CGUID object.</returns>
        public static CGUID NewCGUID()
        {
            var gBytes = System.Guid.NewGuid().ToByteArray();
            return new CGUID(gBytes);
        }

        /// <summary>
        /// Returns a value indicating whether this instance and a specified <see cref="CGUID"/> object represent the same value.
        /// </summary>
        /// <param name="other">An <see cref="CGUID"/> to compare to this instance.</param>
        /// <returns>true if other is equal to this instance; otherwise, false.</returns>
        public bool Equals(CGUID other)
        {
            if (other == null)
                return false;

            if (other._a != this._a)
                return false;

            if (other._b != this._b)
                return false;

            if (other._c != this._c)
                return false;

            if (other._d != this._d)
                return false;

            return true;
        }

        /// <summary>
        /// Returns a value that indicates whether this instance is equal to a specified object
        /// </summary>
        /// <param name="o">The object to compare with this instance.</param>
        /// <returns>true if o is a <see cref="CGUID"/> that has the same value as this instance; otherwise, false.</returns>
        public override bool Equals(object o)
        {
            if (o is CGUID g)
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
        /// <exception cref="ArgumentException">value is not a <see cref="CGUID"/>.</exception>
        public int CompareTo(object value)
        {
            if (value is CGUID g)
            {
                return CompareTo(g);
            }
            throw new ArgumentException("Object must be of type CGUID.");
        }

        /// <summary>
        /// Compares this instance to a specified <see cref="CGUID"/> object and returns an indication
        /// of their relative values.
        /// </summary>
        /// <param name="value">An object to compare to this instance.</param>
        /// <returns>
        /// A signed number indicating the relative values of this instance and value. Return
        /// value Description. A negative integer This instance is less than value. Zero This
        /// instance is equal to value. A positive integer This instance is greater than
        /// value.
        /// </returns>
        public int CompareTo(CGUID value)
        {
            if(value is null)
                throw new ArgumentNullException(nameof(value));

            if (value._a != this._a)
                return this._a.CompareTo(value._a);

            if (value._b != this._b)
                return this._b.CompareTo(value._b);

            if (value._c != this._c)
                return this._c.CompareTo(value._c);

            if (value._d != this._d)
                return this._d.CompareTo(value._d);

            return 0;
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>The hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return RuntimeHelpers.GetHashCode(this);
        }

        /// <summary>
        /// Returns a 16-element byte array that contains the value of this instance.
        /// </summary>
        /// <returns>A 16-element byte array.</returns>
        public byte[] ToByteArray()
        {
            var value = new byte[16];
            unsafe
            {
                fixed(byte* bPtr = value)
                {
                    ((uint*)bPtr)[0] = _a;
                    ((uint*)bPtr)[1] = _b;
                    ((uint*)bPtr)[2] = _c;
                    ((uint*)bPtr)[3] = _d;
                }
            }
            return value;
        }

        /// <summary>
        /// Returns a string representation of the this instance.
        /// </summary>
        /// <returns>
        /// The value of this RED.CGUID, formatted as follows:
        /// XXXXXXXX-XXXXXXXX-XXXXXXXX-XXXXXXXX where the value of the CGUID is
        /// represented as a series of uppercase hexadecimal digits in groups of 8, 8, 8, and
        /// 8 digits and separated by hyphens. An example of a return value is "0C9691D9-74D7552B-3E7AF032-3E7AF032".
        /// To convert the hexadecimal digits from a through f to lowercase, call the System.String.ToLower
        /// method on the returned string.
        /// </returns>
        public override string ToString()
        {
            return String.Format("{0:X8}-{1:X8}-{2:X8}-{3:X8}", _a, _b, _c, _d);
        }

        /// <summary>
        /// Indicates whether the values of two specified RED.CGUID objects are equal.
        /// </summary>
        /// <param name="a">The first object to compare.</param>
        /// <param name="b">The second object to compare.</param>
        /// <returns>true if a and b are equal; otherwise, false.</returns>
        public static bool operator ==(CGUID a, CGUID b)
        {
            if(ReferenceEquals(a, b))
                return true;

            if (a is null)
                return false;

            return a.Equals(b);
        }

        /// <summary>
        /// Indicates whether the values of two specified RED.CGUID objects are not equal.
        /// </summary>
        /// <param name="a">The first object to compare.</param>
        /// <param name="b">The second object to compare.</param>
        /// <returns>false if a and b are equal; otherwise, true.</returns>
        public static bool operator !=(CGUID a, CGUID b)
        {
            if (ReferenceEquals(a, b))
                return false;

            if (a is null)
                return true;

            return !a.Equals(b);
        }
    }
}
