using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace RED
{
    /// <summary>
    /// Represents a single byte ANSI encoded (Windows-1252) string class. This class is immutable.
    /// </summary>
    [ImmutableObject(true)]
    public sealed class StringAnsi : IEquatable<StringAnsi>, IEnumerable<char>
    {
        private readonly string m_value;
        private static readonly Encoding ANSI = Encoding.GetEncoding(1252);

        #region Constructors
        public StringAnsi(string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return;
            }
            m_value = String.Copy(value);
        }
        public StringAnsi(char[] value)
        {
            if (value is null || value.Length == 0)
            {
                return;
            }
            m_value = new string(value);
        }
        public StringAnsi(byte[] value)
        {
            if (value is null || value.Length == 0)
            {
                return;
            }
            m_value = ANSI.GetString(value);
        }
        #endregion

        #region Properties
        public int Length
        {
            get
            {
                if (m_value is null)
                    return 0;

                return m_value.Length;
            }
        }
        public char this[int index]
        {
            get
            {
                if (m_value is null)
                    throw new IndexOutOfRangeException();

                return m_value[index];
            }
        }
        #endregion

        public override bool Equals(object obj)
        {
            if (obj is StringAnsi str)
                return Equals(str);

            return false;
        }
        public override int GetHashCode()
        {
            return RuntimeHelpers.GetHashCode(this);
        }
        public override string ToString()
        {
            if (String.IsNullOrEmpty(m_value))
            {
                return string.Empty;
            }
            return String.Copy(m_value);
        }

        public byte[] ToByteArray()
        {
            if (String.IsNullOrEmpty(m_value))
            {
                return Array.Empty<byte>();
            }
            return ANSI.GetBytes(m_value);
        }
        public char[] ToCharArray()
        {
            if (String.IsNullOrEmpty(m_value))
            {
                return Array.Empty<char>();
            }
            return m_value.ToCharArray();
        }

        public bool Equals(StringAnsi other)
        {
            if (other is null)
                return false;

            if (ReferenceEquals(m_value, other.m_value))
                return true;

            return m_value.Equals(other.m_value);
        }

        public IEnumerator<char> GetEnumerator()
        {
            if (m_value == null || Length == 0)
                yield break;

            for (int i = 0; i < Length; i++)
            {
                yield return m_value[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #region Operators
        public static implicit operator string(StringAnsi value)
        {
            return value?.ToString();
        }
        public static implicit operator StringAnsi(string value)
        {
            return new StringAnsi(value);
        }

        public static bool operator ==(StringAnsi left, StringAnsi right)
        {
            if (left is null)
                return false;

            if (left.m_value == right.m_value)
                return true;

            return left.Equals(right);
        }
        public static bool operator !=(StringAnsi left, StringAnsi right)
        {
            if (left is null)
                return true;

            if (left.m_value == right.m_value)
                return false;

            return !left.Equals(right);
        }
        #endregion
    }
}