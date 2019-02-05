namespace RED.Utilities
{
    /// <summary>
    /// Provides static methods for rotating byte, ushort, uint, ulong, 
    /// sbyte, short, int or long values to the left or right a given number of times.
    /// </summary>
    public static class BitRotator
    {
        /// <summary>
        /// Rotates the bits of a unsigned byte value to the left.
        /// </summary>
        /// <param name="value">The value to rotate.</param>
        /// <param name="count">The number of positions to rotate.</param>
        /// <returns>The rotated value.</returns>
        public static byte RotateLeft(byte value, int count)
        {
            count %= 8;
            return (byte)((value << count) | (value >> (8 - count)));
        }
        /// <summary>
        /// Rotates the bits of a unsigned short value to the left.
        /// </summary>
        /// <param name="value">The value to rotate.</param>
        /// <param name="count">The number of positions to rotate.</param>
        /// <returns>The rotated value.</returns>
        public static ushort RotateLeft(ushort value, int count)
        {
            count %= 16;
            return (ushort)((value << count) | (value >> (16 - count)));
        }
        /// <summary>
        /// Rotates the bits of a unsigned int value to the left.
        /// </summary>
        /// <param name="value">The value to rotate.</param>
        /// <param name="count">The number of positions to rotate.</param>
        /// <returns>The rotated value.</returns>
        public static uint RotateLeft(uint value, int count)
        {
            return (value << count) | (value >> (32 - count));
        }
        /// <summary>
        /// Rotates the bits of a unsigned long value to the left.
        /// </summary>
        /// <param name="value">The value to rotate.</param>
        /// <param name="count">The number of positions to rotate.</param>
        /// <returns>The rotated value.</returns>
        public static ulong RotateLeft(ulong value, int count)
        {
            return (value << count) | (value >> (64 - count));
        }

        /// <summary>
        /// Rotates the bits of a signed byte value to the left.
        /// </summary>
        /// <param name="value">The value to rotate.</param>
        /// <param name="count">The number of positions to rotate.</param>
        /// <returns>The rotated value.</returns>
        public static sbyte RotateLeft(sbyte value, int count)
        {
            count %= 8;
            var val = (byte)value;
            return (sbyte)((val << count) | (val >> (8 - count)));
        }
        /// <summary>
        /// Rotates the bits of a signed short value to the left.
        /// </summary>
        /// <param name="value">The value to rotate.</param>
        /// <param name="count">The number of positions to rotate.</param>
        /// <returns>The rotated value.</returns>
        public static short RotateLeft(short value, int count)
        {
            count %= 16;
            var val = (ushort)value;
            return (short)((val << count) | (val >> (16 - count)));
        }
        /// <summary>
        /// Rotates the bits of a signed int value to the left.
        /// </summary>
        /// <param name="value">The value to rotate.</param>
        /// <param name="count">The number of positions to rotate.</param>
        /// <returns>The rotated value.</returns>
        public static int RotateLeft(int value, int count)
        {
            var val = (uint)value;
            return (int)((val << count) | (val >> (32 - count)));
        }
        /// <summary>
        /// Rotates the bits of a signed long value to the left.
        /// </summary>
        /// <param name="value">The value to rotate.</param>
        /// <param name="count">The number of positions to rotate.</param>
        /// <returns>The rotated value.</returns>
        public static long RotateLeft(long value, int count)
        {
            var val = (ulong)value;
            return (long)((val << count) | (val >> (64 - count)));
        }

        /// <summary>
        /// Rotates the bits of a unsigned byte value to the right.
        /// </summary>
        /// <param name="value">The value to rotate.</param>
        /// <param name="count">The number of positions to rotate.</param>
        /// <returns>The rotated value.</returns>
        public static byte RotateRight(byte value, int count)
        {
            count %= 8;
            return (byte)((value >> count) | (value << (8 - count)));
        }
        /// <summary>
        /// Rotates the bits of a unsigned short value to the right.
        /// </summary>
        /// <param name="value">The value to rotate.</param>
        /// <param name="count">The number of positions to rotate.</param>
        /// <returns>The rotated value.</returns>
        public static ushort RotateRight(ushort value, int count)
        {
            count %= 16;
            return (ushort)((value >> count) | (value << (16 - count)));
        }
        /// <summary>
        /// Rotates the bits of a unsigned int value to the right.
        /// </summary>
        /// <param name="value">The value to rotate.</param>
        /// <param name="count">The number of positions to rotate.</param>
        /// <returns>The rotated value.</returns>
        public static uint RotateRight(uint value, int count)
        {
            return (value >> count) | (value << (32 - count));
        }
        /// <summary>
        /// Rotates the bits of a unsigned long value to the right.
        /// </summary>
        /// <param name="value">The value to rotate.</param>
        /// <param name="count">The number of positions to rotate.</param>
        /// <returns>The rotated value.</returns>
        public static ulong RotateRight(ulong value, int count)
        {
            return (value >> count) | (value << (64 - count));
        }

        /// <summary>
        /// Rotates the bits of a signed byte value to the right.
        /// </summary>
        /// <param name="value">The value to rotate.</param>
        /// <param name="count">The number of positions to rotate.</param>
        /// <returns>The rotated value.</returns>
        public static sbyte RotateRight(sbyte value, int count)
        {
            count %= 8;
            var val = (byte)value;
            return (sbyte)((val >> count) | (val << (8 - count)));
        }
        /// <summary>
        /// Rotates the bits of a signed short value to the right.
        /// </summary>
        /// <param name="value">The value to rotate.</param>
        /// <param name="count">The number of positions to rotate.</param>
        /// <returns>The rotated value.</returns>
        public static short RotateRight(short value, int count)
        {
            count %= 16;
            var val = (ushort)value;
            return (short)((val >> count) | (val << (16 - count)));
        }
        /// <summary>
        /// Rotates the bits of a signed int value to the right.
        /// </summary>
        /// <param name="value">The value to rotate.</param>
        /// <param name="count">The number of positions to rotate.</param>
        /// <returns>The rotated value.</returns>
        public static int RotateRight(int value, int count)
        {
            var val = (uint)value;
            return (int)((val >> count) | (val << (32 - count)));
        }
        /// <summary>
        /// Rotates the bits of a signed long value to the right.
        /// </summary>
        /// <param name="value">The value to rotate.</param>
        /// <param name="count">The number of positions to rotate.</param>
        /// <returns>The rotated value.</returns>
        public static long RotateRight(long value, int count)
        {
            var val = (ulong)value;
            return (long)((val >> count) | (val << (64 - count)));
        }
    }
}