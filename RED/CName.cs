using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using RED.FNV1A;

namespace RED
{
    /// <summary>
    /// Represents an immutable ASCII encoded name value used with the redengine.
    /// </summary>
    [ImmutableObject(true)]
    public sealed class CName : IEquatable<CName>, IEnumerable<char>
    {
        private readonly string m_value; //String value

        public static readonly CName None = new CName("None");
        public static readonly CName Empty = new CName(string.Empty);

        #region Properties
        public int Length => m_value is null ? 0 : m_value.Length;
        #endregion

        #region Constructors
        public CName(string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return;
            }
            var index = value.IndexOf('\0');
            if(index >= 0)
            {
                m_value = value.Substring(0, index);
            }
            else
            {
                m_value = String.Copy(value);
            }
        }
        public CName(char[] value)
        {
            if(value is null || value.Length == 0)
            {
                return;
            }
            var index = Array.IndexOf(value, '\0');
            if(index >= 0)
            {
                m_value = new string(value, 0, index);
            }
            else
            {
                m_value = new string(value);
            }
        }
        public unsafe CName(byte* value)
        {
            if (value == null)
            {
                return;
            }
            m_value = new string((sbyte*)value);
        }
        public unsafe CName(byte* value, int length)
        {
            if (value == null)
            {
                return;
            }
            var nullPos = 0;
            while(value[nullPos] > 0)
            {
                nullPos++;
            }
            length = Math.Min(nullPos, length);
            m_value = new string((sbyte*)value, 0, length);
        }
        #endregion

        public bool Equals(CName other)
        {
            if (other is null)
                return false;

            if (ReferenceEquals(this.m_value, other.m_value))
                return true;

            return m_value.Equals(other.m_value);
        }
        public override string ToString()
        {
            return m_value ?? string.Empty;
        }
        public override int GetHashCode()
        {
            return RuntimeHelpers.GetHashCode(this);
        }
        public override bool Equals(object obj)
        {
            if (obj is CName n)
                return this.Equals(n);

            return false;
        }
        public byte[] ToByteArray()
        {
            return ToByteArray(true);
        }
        public byte[] ToByteArray(bool nullEnded)
        {
            byte[] bytes = new byte[nullEnded ? Length + 1 : Length];
            Encoding.ASCII.GetBytes(m_value, 0, Length, bytes, 0);
            return bytes;
        }

        public static bool IsNullOrEmpty(CName name)
        {
            if (name is null)
                return true;

            return String.IsNullOrEmpty(name.m_value);
        }

        public IEnumerator<char> GetEnumerator()
        {
            return m_value.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #region Operators
        public static implicit operator CName(string value)
        {
            return new CName(value);
        }
        public static implicit operator string(CName value)
        {
            return value?.ToString();
        }

        public static bool operator ==(CName left, CName right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if (left is null)
                return false;

            return left.Equals(right);
        }
        public static bool operator !=(CName left, CName right)
        {
            if (ReferenceEquals(left, right))
                return false;

            if (left is null)
                return true;

            return !left.Equals(right);
        }
        #endregion
    }
}