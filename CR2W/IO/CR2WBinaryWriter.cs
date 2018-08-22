using CR2W.Types.W3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CR2W.CRC32;
using CR2W.Types;
using CR2W.FNV1A;

namespace CR2W.IO
{
    //WIP

    public sealed class CR2WBinaryWriter : BinaryWriter
    {
        public const uint MAGIC     = 0x57325243;   // 'CR2W'
        public const uint VERSION   = 0xA3;         // 163
        public const uint FLAGS     = 0x0;          // 0
        public const uint BUILD     = 0x12E9CE;     // 1239502
        public const uint DEADBEEF  = 0xDEADBEEF;   // 3735928559
        public const uint CHUNKS    = 0x06;         // 6

        public const uint TABLE_01_SIZE = 1;
        public const uint TABLE_02_SIZE = 8;
        public const uint TABLE_03_SIZE = 8;
        public const uint TABLE_04_SIZE = 16;
        public const uint TABLE_05_SIZE = 24;
        public const uint TABLE_06_SIZE = 24;
        public const uint TABLE_07_SIZE = 24;
        public const uint TABLE_08_SIZE = 0;
        public const uint TABLE_09_SIZE = 0;
        public const uint TABLE_10_SIZE = 0;

        public uint FILESIZE => Convert.ToUInt32(BaseStream.Length);

        public readonly ulong CREATIONTIME = CDateTime.Now.ToUInt64();

        //Build versions
        //894871
        //941235
        //981372
        //988299
        //1007547
        //1088431
        //1101707
        //1133885
        //1150341
        //1162672
        //1163393
        //1168504
        //1231176
        //1239502

        //CR2W versions
        //127
        //134
        //136
        //137
        //152
        //156
        //157
        //159
        //161
        //162
        //163

        public STableHeader[]           headers;
        public Dictionary<uint, string> strings;
        public List<SName>              names;
        public List<SResource>          resources;
        public List<STable4Item>        table4items;
        public List<SObject>            objects;
        public List<SBuffer>            buffers;
        public List<SEmbedded>          embedded;

        public CR2WBinaryWriter(Stream stream) : base(stream, Encoding.ASCII, false)
        {
            headers     = new STableHeader[10];
            strings     = new Dictionary<uint, string>();
            names       = new List<SName>();
            resources   = new List<SResource>();
            table4items = new List<STable4Item>();
            objects     = new List<SObject>();
            buffers     = new List<SBuffer>();
            embedded    = new List<SEmbedded>();

            for (int i = 0; i < 10; i++)
            {
                headers[i] = new STableHeader();
            }

            AddTable4Item("", 0, "", 0, 0);
        }

        #region Table Contruction
        private uint AddString(string value)
        {
            if(strings.ContainsValue(value))
            {
                return strings.First(s => s.Value == value).Key;
            }
            var offset = 0u;
            if(strings.Any())
            {
                var last = strings.Last();
                offset = last.Key + (uint)last.Value.Length + 1u;
            }
            strings.Add(offset, value);
            return offset;
        }
        public ushort AddName( string value )
        {
            var hash = FNV1A32HashAlgorithm.HashString(value);
            var index = names.FindIndex(n => n.hash == hash);
            if(index >= 0)
            {
                return Convert.ToUInt16(index);
            }
            names.Add(new SName
            {
                offset = AddString(value),
                hash = hash,
            });
            return Convert.ToUInt16(names.Count - 1);
        }
        public ushort AddResource( string type, string path, ushort flags )
        {
            var index = resources.FindIndex(r => r.type == type && r.path == path && r.flags == flags);
            if (index >= 0)
            {
                return Convert.ToUInt16(index);
            }
            resources.Add(new SResource()
            {
                type = type,
                path = path,
                flags = flags,
            });
            return Convert.ToUInt16(resources.Count);
        }
        public void AddTable4Item( string className, ushort unk1, string propertyName, ushort unk2, ulong hash )
        {
            table4items.Add( new STable4Item()
            {
                classId = AddName(className),
                unknown1 = unk1,
                propertyId = AddName(propertyName),
                unknown2 = unk2,
                hash = hash,
            });
        }
        #endregion

        #region Serialization
        public void SerializeTables()
        {
            #region Preparation
            foreach (var r in resources)
            {
                r.typeid = AddName(r.type);
                r.offset = AddString(r.path);
            }
            #endregion

            uint shift = 160;
            byte[] data = null;
            var temp = new List<byte>();

            #region Table 1 - Strings
            foreach (var s in strings)
            {
                temp.AddRange(Encoding.ASCII.GetBytes(s.Value));
                temp.Add(0);
            }
            data = temp.ToArray();
            temp.Clear();
            headers[0].data = data;
            headers[0].size = Convert.ToUInt32(data.Length);
            headers[0].crc32 = Crc32Algorithm.Compute(data);
            headers[0].offset = data.Length > 0 ? shift : 0;
            shift += Convert.ToUInt32(data.Length);
            #endregion

            #region Table 2 - Names
            foreach (var n in names)
            {
                temp.AddRange(BitConverter.GetBytes(n.offset));
                temp.AddRange(BitConverter.GetBytes(n.hash));
            }
            data = temp.ToArray();
            temp.Clear();
            headers[1].data = data;
            headers[1].size = Convert.ToUInt32(names.Count);
            headers[1].crc32 = Crc32Algorithm.Compute(data);
            headers[1].offset = data.Length > 0 ? shift : 0;
            shift += Convert.ToUInt32(data.Length);
            #endregion

            #region Table 3 - Resources
            foreach (var r in resources)
            {
                temp.AddRange(BitConverter.GetBytes(r.offset));
                temp.AddRange(BitConverter.GetBytes(r.typeid));
                temp.AddRange(BitConverter.GetBytes(r.flags));
            }
            data = temp.ToArray();
            temp.Clear();
            headers[2].data = data;
            headers[2].size = Convert.ToUInt32(resources.Count);
            headers[2].crc32 = Crc32Algorithm.Compute(data);
            headers[2].offset = data.Length > 0 ? shift : 0;
            shift += Convert.ToUInt32(data.Length);
            #endregion

            #region Table 4 - Unknown
            foreach (var i in table4items)
            {
                temp.AddRange(BitConverter.GetBytes(i.classId));
                temp.AddRange(BitConverter.GetBytes(i.unknown1));
                temp.AddRange(BitConverter.GetBytes(i.propertyId));
                temp.AddRange(BitConverter.GetBytes(i.unknown2));
                temp.AddRange(BitConverter.GetBytes(i.hash));
            }
            data = temp.ToArray();
            temp.Clear();
            headers[3].data = data;
            headers[3].size = Convert.ToUInt32(table4items.Count); ;
            headers[3].crc32 = Crc32Algorithm.Compute(data);
            headers[3].offset = data.Length > 0 ? shift : 0;
            shift += Convert.ToUInt32(data.Length);
            #endregion

            #region Table 5 - Objects
            uint tempoffset = shift + 24u * (uint)objects.Count;
            foreach (var o in objects)
            {
                o.offset += tempoffset;

                temp.AddRange(BitConverter.GetBytes(o.typeID));
                temp.AddRange(BitConverter.GetBytes(o.flags));
                temp.AddRange(BitConverter.GetBytes(o.parentID));
                temp.AddRange(BitConverter.GetBytes(o.size));
                temp.AddRange(BitConverter.GetBytes(o.offset));
                temp.AddRange(BitConverter.GetBytes(o.template));
                temp.AddRange(BitConverter.GetBytes(o.crc32));
            }
            data = temp.ToArray();
            temp.Clear();
            headers[4].data = data;
            headers[4].size = Convert.ToUInt32(objects.Count);
            headers[4].crc32 = Crc32Algorithm.Compute(data);
            headers[4].offset = data.Length > 0 ? shift : 0;
            shift += Convert.ToUInt32(data.Length);
            #endregion

            #region Table 6 - Buffers
            foreach (var b in buffers)
            {
                temp.AddRange(BitConverter.GetBytes(b.flags));
                temp.AddRange(BitConverter.GetBytes(b.index));
                temp.AddRange(BitConverter.GetBytes(b.offset));
                temp.AddRange(BitConverter.GetBytes(b.diskSize));
                temp.AddRange(BitConverter.GetBytes(b.memSize));
                temp.AddRange(BitConverter.GetBytes(b.crc32));
            }
            data = temp.ToArray();
            headers[5].data = data;
            headers[5].size = Convert.ToUInt32(buffers.Count);
            headers[5].crc32 = Crc32Algorithm.Compute(data);
            headers[5].offset = data.Length > 0 ? shift : 0;
            shift += Convert.ToUInt32(data.Length);
            #endregion

            #region Table 7 - Embedded
            foreach (var e in embedded)
            {
                temp.AddRange(BitConverter.GetBytes(e.importIndex));
                temp.AddRange(BitConverter.GetBytes(e.path));
                temp.AddRange(BitConverter.GetBytes(e.pathHash));
                temp.AddRange(BitConverter.GetBytes(e.offset));
                temp.AddRange(BitConverter.GetBytes(e.length));
            }
            data = temp.ToArray();
            headers[6].data = data;
            headers[6].size = Convert.ToUInt32(embedded.Count);
            headers[6].crc32 = Crc32Algorithm.Compute(data);
            headers[6].offset = data.Length > 0 ? shift : 0;
            shift += Convert.ToUInt32(data.Length);
            #endregion
        }
        public void WriteAll()
        {
            SerializeTables();
            BaseStream.Seek(0, SeekOrigin.Begin);

            //File Header
            Write(MAGIC);           //CR2W
            Write(VERSION);         //Version
            Write(FLAGS);           //Flags
            Write(CREATIONTIME);    //DateTime
            Write(BUILD);           //Build
            Write(0u);              //Disksize
            Write(0u);              //MemSize
            Write(DEADBEEF);        //CRC32
            Write(CHUNKS);          //NumChunks

            // 10 Table Headers
            foreach (var h in headers)
            {
                Write(h.offset);
                Write(h.size);
                Write(h.crc32);
            }

            // Table Data
            foreach (var h in headers)
            {
                if(h.data != null)
                {
                    Write(h.data);
                }
            }

            // Objects
            foreach (var o in objects)
            {
                Write(o.data);
            }

            // Embedded CR2W Files
            foreach (var e in embedded)
            {
                Write(e.data);
            }

            // Write the final 2 size vars to the header and then write the crc checksum
            BaseStream.Seek(24, SeekOrigin.Begin);
            Write(FILESIZE);
            Write(FILESIZE);
            // Awful solution - Fix this!
            var final = ((MemoryStream)BaseStream).ToArray();
            var crc = Crc32Algorithm.Compute(final, 0, 160);
            Write(crc);
        }
        #endregion

        #region Supporting Functions
        public void WriteVLQInt32(int value)
        {
            bool negative = value < 0;
            value = Math.Abs(value);
            byte b = (byte)(value & 0x3F);
            value >>= 6;
            if (negative)
            {
                b |= 0x80;
            }
            bool cont = value != 0;
            if (cont)
            {
                b |= 0x40;
            }
            Write(b);
            while (cont)
            {
                b = (byte)(value & 0x7F);
                value >>= 7;
                cont = value != 0;
                if (cont)
                {
                    b |= 0x80;
                }
                Write(b);
            }
        }
        public override void Write(string value)
        {
            //Check to see if the string needs to be encoded in unicode.
            var isUniCode = Encoding.ASCII.GetByteCount(value) != value.Length;
            this.Write(value, isUniCode);
        }
        private void Write(string value, bool isUniCode)
        {
            byte[] bytes = null;
            var length = 0;
            if(isUniCode)
            {
                bytes = Encoding.Unicode.GetBytes(value);
                length = bytes.Length;
            }
            else
            {
                bytes = Encoding.ASCII.GetBytes(value);
                length = bytes.Length * -1;
            }
            WriteVLQInt32(length);
            Write(bytes);
        }
        #endregion
    }
}
