using System;

namespace RED.Utilities
{
    /// <summary>
    /// Provides additional methods for converting primitive values.
    /// </summary>
    public static class BitConverterExtensions
    {
        /// <summary>
        /// Copy a ushort value as a byte array into a byte buffer at a given starting index.
        /// </summary>
        /// <param name="value">The ushort value to copy.</param>
        /// <param name="buffer">The byte array to copy into.</param>
        /// <param name="startIndex">The posiotion in the byte array to begin copying to.</param>
        /// <exception cref="ArgumentNullException">The buffer was null.</exception>
        /// <exception cref="IndexOutOfRangeException">The size of the value exceeds the size of the bytes to copy to.</exception>
        public unsafe static void CopyBytes(ushort value, byte[] buffer, int startIndex)
        {
            if (buffer == null)
                throw new ArgumentException(nameof(buffer));

            if (startIndex < 0 || startIndex + 2 > buffer.Length)
                throw new IndexOutOfRangeException();

            fixed (byte* b = &buffer[startIndex])
            {
                *((ushort*)b) = value;
            }
        }
        /// <summary>
        /// Copy a uint value as a byte array into a byte buffer at a given starting index.
        /// </summary>
        /// <param name="value">The uint value to copy.</param>
        /// <param name="buffer">The byte array to copy into.</param>
        /// <param name="startIndex">The posiotion in the byte array to begin copying to.</param>
        /// <exception cref="ArgumentNullException">The buffer was null.</exception>
        /// <exception cref="IndexOutOfRangeException">The size of the value exceeds the size of the bytes to copy to.</exception>
        public unsafe static void CopyBytes(uint value, byte[] buffer, int startIndex)
        {
            if (buffer == null)
                throw new ArgumentException(nameof(buffer));

            if (startIndex < 0 || startIndex + 4 > buffer.Length)
                throw new IndexOutOfRangeException();

            fixed (byte* b = &buffer[startIndex])
            {
                *((uint*)b) = value;
            }
        }
        /// <summary>
        /// Copy a ulong value as a byte array into a byte buffer at a given starting index.
        /// </summary>
        /// <param name="value">The ulong value to copy.</param>
        /// <param name="buffer">The byte array to copy into.</param>
        /// <param name="startIndex">The posiotion in the byte array to begin copying to.</param>
        /// <exception cref="ArgumentNullException">The buffer was null.</exception>
        /// <exception cref="IndexOutOfRangeException">The size of the value exceeds the size of the bytes to copy to.</exception>
        public unsafe static void CopyBytes(ulong value, byte[] buffer, int startIndex)
        {
            if (buffer == null)
                throw new ArgumentException(nameof(buffer));

            if (startIndex < 0 || startIndex + 8 > buffer.Length)
                throw new IndexOutOfRangeException();

            fixed (byte* b = &buffer[startIndex])
            {
                *((ulong*)b) = value;
            }
        }

        /// <summary>
        /// Copy a short value as a byte array into a byte buffer at a given starting index.
        /// </summary>
        /// <param name="value">The short value to copy.</param>
        /// <param name="buffer">The byte array to copy into.</param>
        /// <param name="startIndex">The posiotion in the byte array to begin copying to.</param>
        /// <exception cref="ArgumentNullException">The buffer was null.</exception>
        /// <exception cref="IndexOutOfRangeException">The size of the value exceeds the size of the bytes to copy to.</exception>
        public unsafe static void CopyBytes(short value, byte[] buffer, int startIndex)
        {
            if (buffer == null)
                throw new ArgumentException(nameof(buffer));

            if (startIndex < 0 || startIndex + 2 > buffer.Length)
                throw new IndexOutOfRangeException();

            fixed (byte* b = &buffer[startIndex])
            {
                *((short*)b) = value;
            }
        }
        /// <summary>
        /// Copy a int value as a byte array into a byte buffer at a given starting index.
        /// </summary>
        /// <param name="value">The int value to copy.</param>
        /// <param name="buffer">The byte array to copy into.</param>
        /// <param name="startIndex">The posiotion in the byte array to begin copying to.</param>
        /// <exception cref="ArgumentNullException">The buffer was null.</exception>
        /// <exception cref="IndexOutOfRangeException">The size of the value exceeds the size of the bytes to copy to.</exception>
        public unsafe static void CopyBytes(int value, byte[] buffer, int startIndex)
        {
            if (buffer == null)
                throw new ArgumentException(nameof(buffer));

            if (startIndex < 0 || startIndex + 4 > buffer.Length)
                throw new IndexOutOfRangeException();

            fixed (byte* b = &buffer[startIndex])
            {
                *((int*)b) = value;
            }
        }
        /// <summary>
        /// Copy a long value as a byte array into a byte buffer at a given starting index.
        /// </summary>
        /// <param name="value">The long value to copy.</param>
        /// <param name="buffer">The byte array to copy into.</param>
        /// <param name="startIndex">The posiotion in the byte array to begin copying to.</param>
        /// <exception cref="ArgumentNullException">The buffer was null.</exception>
        /// <exception cref="IndexOutOfRangeException">The size of the value exceeds the size of the bytes to copy to.</exception>
        public unsafe static void CopyBytes(long value, byte[] buffer, int startIndex)
        {
            if (buffer == null)
                throw new ArgumentException(nameof(buffer));

            if (startIndex < 0 || startIndex + 8 > buffer.Length)
                throw new IndexOutOfRangeException();

            fixed (byte* b = &buffer[startIndex])
            {
                *((long*)b) = value;
            }
        }

        /// <summary>
        /// Copy a float value as a byte array into a byte buffer at a given starting index.
        /// </summary>
        /// <param name="value">The float value to copy.</param>
        /// <param name="buffer">The byte array to copy into.</param>
        /// <param name="startIndex">The posiotion in the byte array to begin copying to.</param>
        /// <exception cref="ArgumentNullException">The buffer was null.</exception>
        /// <exception cref="IndexOutOfRangeException">The size of the value exceeds the size of the bytes to copy to.</exception>
        public unsafe static void CopyBytes(float value, byte[] buffer, int startIndex)
        {
            if (buffer == null)
                throw new ArgumentException(nameof(buffer));

            if (startIndex < 0 || startIndex + 4 > buffer.Length)
                throw new IndexOutOfRangeException();

            fixed (byte* b = &buffer[startIndex])
            {
                *((float*)b) = value;
            }
        }
        /// <summary>
        /// Copy a double value as a byte array into a byte buffer at a given starting index.
        /// </summary>
        /// <param name="value">The double value to copy.</param>
        /// <param name="buffer">The byte array to copy into.</param>
        /// <param name="startIndex">The posiotion in the byte array to begin copying to.</param>
        /// <exception cref="ArgumentNullException">The buffer was null.</exception>
        /// <exception cref="IndexOutOfRangeException">The size of the value exceeds the size of the bytes to copy to.</exception>
        public unsafe static void CopyBytes(double value, byte[] buffer, int startIndex)
        {
            if (buffer == null)
                throw new ArgumentException(nameof(buffer));

            if (startIndex < 0 || startIndex + 8 > buffer.Length)
                throw new IndexOutOfRangeException();

            fixed (byte* b = &buffer[startIndex])
            {
                *((double*)b) = value;
            }
        }

        /// <summary>
        /// Swap the Endianness of a 16 bit unsigned integer.
        /// </summary>
        /// <param name="value">The value to swap.</param>
        /// <returns>The swapped value.</returns>
        public static ushort SwapEndianness(ushort value)
        {
            return (ushort)((value << 8) | (value >> 8));
        }
        /// <summary>
        /// Swap the Endianness of a 32 bit unsigned integer.
        /// </summary>
        /// <param name="value">The value to swap.</param>
        /// <returns>The swapped value.</returns>
        public static uint SwapEndianness(uint value)
        {
            value = (value << 16) | (value >> 16);
            return ((value & 0xFF00FF00) >> 8) | ((value & 0x00FF00FF) << 8);
        }
        /// <summary>
        /// Swap the Endianness of a 64 bit unsigned integer.
        /// </summary>
        /// <param name="value">The value to swap.</param>
        /// <returns>The swapped value.</returns>
        public static ulong SwapEndianness(ulong value)
        {
            value = (value >> 32) | (value << 32);
            value = ((value & 0xFFFF0000FFFF0000) >> 16) | ((value & 0x0000FFFF0000FFFF) << 16);
            return ((value & 0xFF00FF00FF00FF00) >> 8) | ((value & 0x00FF00FF00FF00FF) << 8);
        }

        /// <summary>
        /// Swap the Endianness of a 16 bit signed integer.
        /// </summary>
        /// <param name="value">The value to swap.</param>
        /// <returns>The swapped value.</returns>
        public static short SwapEndianness(short value)
        {
            var temp = (ushort)value;
            return (short)((temp << 8) | (temp >> 8));
        }
        /// <summary>
        /// Swap the Endianness of a 32 bit signed integer.
        /// </summary>
        /// <param name="value">The value to swap.</param>
        /// <returns>The swapped value.</returns>
        public static int SwapEndianness(int value)
        {
            var temp = (uint)value;
            temp = (temp << 16) | (temp >> 16);
            temp = ((temp & 0xFF00FF00) >> 8) | ((temp & 0x00FF00FF) << 8);
            return (int)temp;
        }
        /// <summary>
        /// Swap the Endianness of a 64 bit signed integer.
        /// </summary>
        /// <param name="temp">The value to swap.</param>
        /// <returns>The swapped value.</returns>
        public static long SwapEndianness(long value)
        {
            var temp = (ulong)value;
            temp = (temp >> 32) | (temp << 32);
            temp = ((temp & 0xFFFF0000FFFF0000) >> 16) | ((temp & 0x0000FFFF0000FFFF) << 16);
            temp = ((temp & 0xFF00FF00FF00FF00) >> 8) | ((temp & 0x00FF00FF00FF00FF) << 8);
            return (long)temp;
        }

    }
}