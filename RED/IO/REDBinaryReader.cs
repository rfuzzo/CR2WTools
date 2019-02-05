using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using RED.CRC32;
using RED.Reflection;

namespace RED.IO
{
    /// <summary>
    /// Provides an abstract base class for reading binary data, suited to redengine files.
    /// </summary>
    public abstract class REDBinaryReader : IDisposable
    {
        #region Propertie / Fields
        private const int bufferSize = 16;

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
        public REDBinaryReader(Stream stream)
            : this(stream, false)
        {

        }
        public REDBinaryReader(Stream stream, bool leaveOpen)
        {
            m_stream = stream ?? throw new ArgumentNullException(nameof(stream));
            m_leaveOpen = leaveOpen;
            m_buffer = new byte[bufferSize];
        }
        #endregion

        #region .NET
        public byte ReadByte()
        {
            FillBuffer(1);
            return m_buffer[0];
        }
        public unsafe ushort ReadUInt16()
        {
            FillBuffer(2);
            fixed (byte* numRef = m_buffer)
            {
                return *((ushort*)numRef);
            }
        }
        public unsafe uint ReadUInt32()
        {
            FillBuffer(4);
            fixed (byte* numRef = m_buffer)
            {
                return *((uint*)numRef);
            }
        }
        public unsafe ulong ReadUInt64()
        {
            FillBuffer(8);
            fixed (byte* numRef = m_buffer)
            {
                return *((ulong*)numRef);
            }
        }

        public sbyte ReadSByte()
        {
            FillBuffer(1);
            return (sbyte)m_buffer[0];
        }
        public unsafe short ReadInt16()
        {
            FillBuffer(2);
            fixed (byte* numRef = m_buffer)
            {
                return *((short*)numRef);
            }
        }
        public unsafe int ReadInt32()
        {
            FillBuffer(4);
            fixed (byte* numRef = m_buffer)
            {
                return *((int*)numRef);
            }
        }
        public unsafe long ReadInt64()
        {
            FillBuffer(8);
            fixed (byte* numRef = m_buffer)
            {
                return *((long*)numRef);
            }
        }

        public bool ReadBoolean()
        {
            FillBuffer(1);
            return m_buffer[0] > 0;
        }
        public unsafe float ReadSingle()
        {
            FillBuffer(4);
            fixed (byte* numRef = m_buffer)
            {
                return *((float*)numRef);
            }
        }
        public unsafe double ReadDouble()
        {
            FillBuffer(8);
            fixed (byte* numRef = m_buffer)
            {
                return *((double*)numRef);
            }
        }
        public string ReadString()
        {
            var (isAscii, length) = ReadVLQInt32();
            var encoding = isAscii ? Encoding.ASCII : Encoding.Unicode;
            var chars = new char[length];
            using (var sr = new StreamReader(m_stream, encoding, false, 1024, true))
            {
                sr.ReadBlock(chars, 0, length);
            }
            return new string(chars);
        }

        public int Read7BitEncodedInt()
        {
            var count = 0;
            var shift = 0;
            var b = 0;
            do
            {
                b = m_stream.ReadByte();
                if (b < 0)
                {
                    throw new EndOfStreamException();
                }
                count |= (b & 0x7F) << shift;
                shift += 7;
            }
            while ((b & 0x80) != 0);
            return count;
        }
        #endregion

        #region Arrays
        public byte[] ReadBytes(int count)
        {
            var temp = new byte[count];
            var read = m_stream.Read(temp, 0, count);
            if(read != count)
            {
                throw new EndOfStreamException();
            }
            return temp;
        }
        public ushort[] ReadUInt16s(int count)
        {
            return PrivateReadMultiple<ushort>(count);
        }
        public uint[] ReadUInt32s(int count)
        {
            return PrivateReadMultiple<uint>(count);
        }
        public ulong[] ReadUInt64s(int count)
        {
            return PrivateReadMultiple<ulong>(count);
        }

        public sbyte[] ReadSBytes(int count)
        {
            var buffer = new byte[count];
            m_stream.Read(buffer, 0, buffer.Length);
            return Array.ConvertAll(buffer, b => unchecked((sbyte)b));
        }
        public short[] ReadInt16s(int count)
        {
            return PrivateReadMultiple<short>(count);
        }
        public int[] ReadInt32s(int count)
        {
            return PrivateReadMultiple<int>(count);
        }
        public long[] ReadInt64s(int count)
        {
            return PrivateReadMultiple<long>(count);
        }

        private T[] PrivateReadMultiple<T>(int count) where T : struct
        {
            var size   = checked(count * Marshal.SizeOf<T>());
            var buffer = new byte[size];
            var read   = m_stream.Read(buffer, 0, size);
            if(read != size)
            {
                throw new EndOfStreamException();
            }
            var output = new T[count];
            Buffer.BlockCopy(buffer, 0, output, 0, size);
            return output;
        }
        #endregion

        #region Structures
        public T ReadStruct<T>()
        {
            var size = Marshal.SizeOf<T>();
            var temp = new byte[size];
            var handle = GCHandle.Alloc(temp, GCHandleType.Pinned);

            var read = m_stream.Read(temp, 0, size);
            if(read != size)
            {
                throw new EndOfStreamException();
            }

            var item = Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());

            handle.Free();
            return item;
        }
        public T[] ReadStructs<T>(int count)
        {
            var size = Marshal.SizeOf<T>();
            var items = new T[count];
            var buffer = new byte[size];
            var handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            for (int i = 0; i < count; i++)
            {
                var read = m_stream.Read(buffer, 0, size);
                if (read != size)
                {
                    throw new EndOfStreamException();
                }
                items[i] = Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());
            }
            handle.Free();
            return items;
        }
        public T ReadStruct<T>(Crc32Algorithm crc32)
        {
            var size = Marshal.SizeOf<T>();
            var buffer = new byte[size];
            var handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);

            var read = m_stream.Read(buffer, 0, size);
            if (read != size)
            {
                throw new EndOfStreamException();
            }
            var item = Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());
            crc32.Append(buffer);

            handle.Free();
            return item;
        }
        public T[] ReadStructs<T>(uint count, Crc32Algorithm crc32)
        {
            var size = Marshal.SizeOf<T>();
            var items = new T[count];
            var buffer = new byte[size];
            var handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            for (uint i = 0; i < count; i++)
            {
                var read = m_stream.Read(buffer, 0, size);
                if (read != size)
                {
                    throw new EndOfStreamException();
                }
                items[i] = Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());
                crc32.Append(buffer);
            }
            handle.Free();
            return items;
        }
        #endregion

        #region RED
        public abstract CName ReadCName();
        public CDateTime ReadCDateTime()
        {
            var value = ReadUInt64();
            return new CDateTime(value);
        }
        public CGUID ReadCGUID()
        {
            FillBuffer(16);
            return new CGUID(m_buffer);
        }
        public EngineTransform ReadEngineTransform()
        {
            var e = new EngineTransform();
            var header = ReadByte();

            if (header == 0)
                return e;

            unsafe
            {
                fixed (byte* bPtr = m_buffer)
                {
                    if ((header & 1) == 1)
                    {
                        FillBuffer(12);
                        e.Scale.X = *((float*)bPtr);
                        e.Scale.Y = *((float*)bPtr + 1);
                        e.Scale.Z = *((float*)bPtr + 2);
                    }
                    if ((header & 2) == 2)
                    {
                        FillBuffer(12);
                        e.Rotation.X = *((float*)bPtr);
                        e.Rotation.Y = *((float*)bPtr + 1);
                        e.Rotation.Z = *((float*)bPtr + 2);
                    }
                    if ((header & 4) == 4)
                    {
                        FillBuffer(12);
                        e.Position.X = *((float*)bPtr);
                        e.Position.Y = *((float*)bPtr + 1);
                        e.Position.Z = *((float*)bPtr + 2);
                    }
                }
            }
            return e;
        }
        public EngineQsTransform ReadEngineQsTransform()
        {
            var e = new EngineQsTransform();
            var header = ReadByte();

            if (header == 0)
                return e;

            unsafe
            {
                fixed (byte* bPtr = m_buffer)
                {
                    if ((header & 1) == 1)
                    {
                        FillBuffer(12);
                        e.Scale.X = *((float*)bPtr);
                        e.Scale.Y = *((float*)bPtr + 1);
                        e.Scale.Z = *((float*)bPtr + 2);
                    }
                    if ((header & 2) == 2)
                    {
                        FillBuffer(16);
                        e.Rotation.X = *((float*)bPtr);
                        e.Rotation.Y = *((float*)bPtr + 1);
                        e.Rotation.Z = *((float*)bPtr + 2);
                        e.Rotation.W = *((float*)bPtr + 3);
                    }
                    if ((header & 4) == 4)
                    {
                        FillBuffer(12);
                        e.Position.X = *((float*)bPtr);
                        e.Position.Y = *((float*)bPtr + 1);
                        e.Position.Z = *((float*)bPtr + 2);
                    }
                }
            }

            return e;
        }
        public DataBuffer ReadDataBuffer()
        {
            var size  = ReadInt32();
            var bytes = ReadBytes(size);
            return new DataBuffer(bytes);
        }
        public object ReadEnumerator(Type enumType)
        {
            if (!enumType.IsEnum)
            {
                throw new ArgumentException();
            }
            if (enumType.IsDefined(typeof(FlagsAttribute), false))
            {
                var flags = new HashSet<CName>();
                while (true)
                {
                    var flag = ReadCName();
                    if (CName.IsNullOrEmpty(flag))
                    {
                        break;
                    }
                    flags.Add(flag);
                }
                return EnumExtensions.ConvertToEnum(enumType, flags);
            }
            else
            {
                var name = ReadCName();
                return Enum.Parse(enumType, name);
            }
        }
        public IdTag ReadIdTag()
        {
            var dyn = ReadBoolean();
            var id = ReadCGUID();
            return new IdTag(dyn, id);
        }
        public TagList ReadTagList()
        {
            var (flag, size) = ReadVLQInt32();
            var tags = new TagList();
            for (int i = 0; i < size; i++)
            {
                var n = ReadCName();
                tags.Add(n);
            }
            return tags;
        }
        public LocalizedString ReadLocalizedString()
        {
            var id = ReadUInt32();
            return new LocalizedString(id);
        }

        public (bool Flag, int Size) ReadVLQInt32()
        {
            var b1 = m_stream.ReadByte();

            if(b1 < 0)
            {
                throw new EndOfStreamException();
            }

            var sign = (b1 & 128) == 128;
            var next = (b1 & 64) == 64;
            var size = b1 % 128 % 64;
            var offset = 6;
            while (next)
            {
                var b = m_stream.ReadByte();

                if (b < 0)
                {
                    throw new EndOfStreamException();
                }

                size = (b % 128) << offset | size;
                next = (b & 128) == 128;
                offset += 7;
            }
            return (sign, size);
        }
        #endregion

        public void FillBuffer(int count)
        {
            if(count < 0 || count > bufferSize)
            {
                throw new ArgumentException();
            }

            if(count == 1)
            {
                var b = m_stream.ReadByte();
                if(b < 0)
                {
                    throw new EndOfStreamException();
                }
                m_buffer[0] = (byte)b;
            }
            else
            {
                var bytesRead = m_stream.Read(m_buffer, 0, count);
                if(bytesRead != count)
                {
                    throw new EndOfStreamException();
                }
            }
        }

        #region Disposable
        public virtual void Dispose()
        {
            if(!m_leaveOpen)
            {
                m_stream.Dispose();
            }
        }
        #endregion
    }
}