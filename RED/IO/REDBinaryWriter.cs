using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using RED.CRC32;
using RED.Reflection;

namespace RED.IO
{
    /// <summary>
    /// Provides an abstract base class for writing binary data, suited to redengine files.
    /// </summary>
    public abstract class REDBinaryWriter : IDisposable
    {
        #region Props / Fields
        private readonly Stream m_stream;
        private readonly byte[] m_buffer;
        private readonly bool m_leaveOpen;

        public Stream BaseStream
        {
            get
            {
                return m_stream;
            }
        }
        public bool LeaveOpen
        {
            get
            {
                return m_leaveOpen;
            }
        }
        #endregion

        #region Contructors
        public REDBinaryWriter(Stream stream)
            : this(stream, false)
        {

        }
        public REDBinaryWriter(Stream stream, bool leaveOpen)
        {
            m_stream = stream ?? throw new ArgumentNullException(nameof(stream));
            m_leaveOpen = leaveOpen;
            m_buffer = new byte[16];
        }
        #endregion

        #region .NET
        public void Write(byte value)
        {
            m_stream.WriteByte(value);
        }
        public unsafe void Write(ushort value)
        {
            fixed(byte* bPtr = m_buffer)
            {
                *((ushort*)bPtr) = value;
            }
            m_stream.Write(m_buffer, 0, 2);
        }
        public unsafe void Write(uint value)
        {
            fixed (byte* bPtr = m_buffer)
            {
                *((uint*)bPtr) = value;
            }
            m_stream.Write(m_buffer, 0, 4);
        }
        public unsafe void Write(ulong value)
        {
            fixed (byte* bPtr = m_buffer)
            {
                *((ulong*)bPtr) = value;
            }
            m_stream.Write(m_buffer, 0, 8);
        }

        public void Write(sbyte value)
        {
            m_stream.WriteByte((byte)value);
        }
        public unsafe void Write(short value)
        {
            fixed (byte* bPtr = m_buffer)
            {
                *((short*)bPtr) = value;
            }
            m_stream.Write(m_buffer, 0, 2);
        }
        public unsafe void Write(int value)
        {
            fixed (byte* bPtr = m_buffer)
            {
                *((int*)bPtr) = value;
            }
            m_stream.Write(m_buffer, 0, 4);
        }
        public unsafe void Write(long value)
        {
            fixed (byte* bPtr = m_buffer)
            {
                *((long*)bPtr) = value;
            }
            m_stream.Write(m_buffer, 0, 8);
        }

        public unsafe void Write(float value)
        {
            fixed (byte* bPtr = m_buffer)
            {
                *((float*)bPtr) = value;
            }
            m_stream.Write(m_buffer, 0, 4);
        }
        public unsafe void Write(double value)
        {
            fixed (byte* bPtr = m_buffer)
            {
                *((double*)bPtr) = value;
            }
            m_stream.Write(m_buffer, 0, 8);
        }
        public void Write(bool value)
        {
            m_stream.WriteByte((byte)(value ? 1 : 0));
        }
        public void Write(string value)
        {
            var isAcsii = value.All(c => c <= sbyte.MaxValue && c >= 0);
            var encoding = isAcsii ? Encoding.ASCII : Encoding.Unicode;
            WriteVLQInt32(value.Length, isAcsii);
            using (var sw = new StreamWriter(m_stream, encoding, 1024, true))
            {
                sw.Write(value.ToCharArray(), 0, value.Length);
            }
        }
        #endregion

        #region Arrays
        public void Write(byte[] value)
        {
            m_stream.Write(value, 0, value.Length);
        }
        public void Write(ushort[] value)
        {
            PrivateWriteMultiple(value);
        }
        public void Write(uint[] value)
        {
            PrivateWriteMultiple(value);
        }
        public void Write(ulong[] value)
        {
            PrivateWriteMultiple(value);
        }

        public void Write(sbyte[] value)
        {
            var bytes = Array.ConvertAll(value, b => unchecked((byte)b));
            m_stream.Write(bytes, 0, bytes.Length);
        }
        public void Write(short[] value)
        {
            PrivateWriteMultiple(value);
        }
        public void Write(int[] value)
        {
            PrivateWriteMultiple(value);
        }
        public void Write(long[] value)
        {
            PrivateWriteMultiple(value);
        }

        private void PrivateWriteMultiple<T>(T[] value)
        {
            var size = checked(value.Length * Marshal.SizeOf<T>());
            var buffer = new byte[size];
            Buffer.BlockCopy(value, 0, buffer, 0, size);
            m_stream.Write(buffer, 0, size);
        }
        #endregion

        #region Structures
        public void WriteStruct<T>(T value)
        {
            var buffer = new byte[Marshal.SizeOf<T>()];
            var handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);

            Marshal.StructureToPtr(value, handle.AddrOfPinnedObject(), true);
            m_stream.Write(buffer, 0, buffer.Length);

            handle.Free();
        }
        public void WriteStructs<T>(T[] array)
        {
            var size = Marshal.SizeOf<T>();
            var buffer = new byte[size];
            var handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            for (int i = 0; i < array.Length; i++)
            {
                Marshal.StructureToPtr(array[i], handle.AddrOfPinnedObject(), true);
                m_stream.Write(buffer, 0, buffer.Length);
            }
            handle.Free();
        }
        public void WriteStruct<T>(T value, Crc32Algorithm crc32) 
        {
            var buffer = new byte[Marshal.SizeOf<T>()];
            var handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);

            Marshal.StructureToPtr(value, handle.AddrOfPinnedObject(), true);
            m_stream.Write(buffer, 0, buffer.Length);

            crc32.Append(buffer);

            handle.Free();
        }
        public void WriteStructs<T>(T[] array, Crc32Algorithm crc32)
        {
            var size = Marshal.SizeOf<T>();
            var buffer = new byte[size];
            var handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            for (int i = 0; i < array.Length; i++)
            {
                Marshal.StructureToPtr(array[i], handle.AddrOfPinnedObject(), true);
                m_stream.Write(buffer, 0, buffer.Length);
                crc32.Append(buffer);
            }
            handle.Free();
        }
        #endregion

        #region RED
        public abstract void Write(CName value);
        public void Write(Enum value)
        {
            var names = EnumExtensions.ConvertToNames((Enum)value);
            if (value.GetType().IsDefined(typeof(FlagsAttribute), false))
            {
                foreach (var name in names)
                {
                    Write(name);
                }
                Write((ushort)0);
            }
            else if(names.Any())
            {
                Write(names.First());
            }
            else
            {
                Write((ushort)0);
            }
        }
        public unsafe void Write(EngineTransform value)
        {
            var flags = 0;

            if (value.Scale.Length() > 0)
                flags |= 1;

            if (value.Rotation.Length() > 0)
                flags |= 2;

            if (value.Position.Length() > 0)
                flags |= 4;

            Write((byte)flags);
            fixed (byte* bPtr = m_buffer)
            {
                if ((flags & 1) == 1)
                {
                    *((float*)bPtr) = value.Scale.X;
                    *((float*)bPtr + 1) = value.Scale.Y;
                    *((float*)bPtr + 2) = value.Scale.Z;
                    m_stream.Write(m_buffer, 0, 12);
                }
                if ((flags & 2) == 2)
                {
                    *((float*)bPtr) = value.Rotation.X;
                    *((float*)bPtr + 1) = value.Rotation.Y;
                    *((float*)bPtr + 2) = value.Rotation.Z;
                    m_stream.Write(m_buffer, 0, 12);
                }
                if ((flags & 4) == 4)
                {
                    *((float*)bPtr) = value.Position.X;
                    *((float*)bPtr + 1) = value.Position.Y;
                    *((float*)bPtr + 2) = value.Position.Z;
                    m_stream.Write(m_buffer, 0, 12);
                }
            }
        }
        public unsafe void Write(EngineQsTransform value)
        {
            var header = 0;

            if (value.Scale.Length() > 0)
                header |= 1;

            if (value.Rotation.Length() > 0)
                header |= 2;

            if (value.Position.Length() > 0)
                header |= 4;

            Write((byte)header);
            fixed (byte* bPtr = m_buffer)
            {
                if ((header & 1) == 1)
                {
                    *((float*)bPtr) = value.Scale.X;
                    *((float*)bPtr + 1) = value.Scale.Y;
                    *((float*)bPtr + 2) = value.Scale.Z;
                    m_stream.Write(m_buffer, 0, 12);
                }
                if ((header & 2) == 2)
                {
                    *((float*)bPtr) = value.Rotation.X;
                    *((float*)bPtr + 1) = value.Rotation.Y;
                    *((float*)bPtr + 2) = value.Rotation.Z;
                    *((float*)bPtr + 3) = value.Rotation.W;
                    m_stream.Write(m_buffer, 0, 16);
                }
                if ((header & 4) == 4)
                {
                    *((float*)bPtr) = value.Position.X;
                    *((float*)bPtr + 1) = value.Position.Y;
                    *((float*)bPtr + 2) = value.Position.Z;
                    m_stream.Write(m_buffer, 0, 12);
                }
            }
        }
        public void Write(CDateTime value)
        {
            if (value is null)
            {
                Write(0UL);
            }
            else
            {
                Write(value.ToUInt64());
            }
        }
        public void Write(CGUID value)
        {
            if (value is null)
            {
                Write(0u);
                Write(0u);
                Write(0u);
                Write(0u);
            }
            else
            {
                Write(value.ToByteArray());
            }
        }
        public void Write(TagList value)
        {
            if (value is null)
            {
                Write((byte)0);
                return;
            }
            Write((byte)value.Count);
            foreach (var item in value)
            {
                Write(item);
            }
        }
        public void Write(IdTag value)
        {
            Write(value.Dynamic);
            Write(value.ID);
        }

        public void WriteVLQInt32(int value, bool flag)
        {
            if (value < 0)
                throw new ArgumentException();

            byte b = (byte)(value & 0x3F);
            value >>= 6;
            if (flag)
            {
                b |= 0x80;
            }
            bool cont = value != 0;
            if (cont)
            {
                b |= 0x40;
            }
            m_stream.WriteByte(b);
            while (cont)
            {
                b = (byte)(value & 0x7F);
                value >>= 7;
                cont = value != 0;
                if (cont)
                {
                    b |= 0x80;
                }
                m_stream.WriteByte(b);
            }
        }
        #endregion

        public virtual void Dispose()
        {
            m_stream.Dispose();
        }
    }
}