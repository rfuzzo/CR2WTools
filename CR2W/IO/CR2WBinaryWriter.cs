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
        public const uint MAGIC = 0x57325243;
        public const uint VERSION = 0xA3;
        public const uint FLAGS = 0x0;
        public const uint BUILD = 0x12E9CE;
        public const uint DEADBEEF = 0xDEADBEEF;
        public const uint CHUNKS = 0x6;

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
        //1239502

        //CR2W versions
        //127
        //136
        //134
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
        public List<SObject>            objects;
        public List<SBuffer>            buffers;
        public List<SEmbedded>          embedded;

        public CR2WBinaryWriter(Stream stream) : base(stream, Encoding.ASCII, false)
        {
            headers     = new STableHeader[10];
            strings     = new Dictionary<uint, string>();
            names       = new List<SName>();
            resources   = new List<SResource>();
            objects     = new List<SObject>();
            buffers     = new List<SBuffer>();
            embedded    = new List<SEmbedded>();

            for (int i = 0; i < 10; i++)
            {
                headers[i] = new STableHeader();
            }

            names.Add(new SName() { value = "", hash = 0 });
        }

        public void Create( CResource resource )
        {

        }

        #region Table Construction

        /// <summary>
        /// Add a string value to Table 1. If that value already exists this will return the offset of the existing one.
        /// </summary>
        /// <param name="value">String value to add to the table</param>
        /// <returns>uint value of the offset that string has in the table</returns>
        private uint AddString( string value )
        {
            if(strings.ContainsValue(value))
                return strings.First(x => x.Value == value).Key;

            uint offset = 0;
            if(strings.Any())
            {
                var last = strings.Last();
                offset = Convert.ToUInt32(last.Key + last.Value.Length + 1);
            }
            strings.Add( offset, value );
            return offset;
        }

        /// <summary>
        /// Add a name value to Table 2, If that value already exists this will return the index of the existing one.
        /// </summary>
        /// <param name="value">Name value to add</param>
        /// <returns>Index of the name in table 2</returns>
        public ushort AddName( string value )
        {
            if (names.Where(n => n.value == value).Any())
            {
                return Convert.ToUInt16(names.IndexOf(names.First(n => n.value == value)));
            }
            uint h = FNV1A32HashAlgorithm.Compute(value);
            names.Add(new SName()
            {
                hash = h,
                value = value,
            });
            return Convert.ToUInt16(names.Count - 1);
        }

        /// <summary>
        /// Add a resource to Table 3. If that value already exists then this will return the index of the existing one. 
        /// </summary>
        /// <param name="type">Resource type class name</param>
        /// <param name="path">Depot path of the resource</param>
        /// <param name="flags">Resource flags</param>
        /// <returns>The index of the item in table 3</returns>
        public ushort AddResource( string type, string path, ushort flags )
        {
            if(resources.Where(r => r.type == type && r.path == path && r.flags == flags).Any())
            {
                return Convert.ToUInt16( resources.IndexOf(resources.First(r => r.type == type && r.path == path && r.flags == flags)));
            }
            resources.Add(new SResource()
            {
                type = type,
                path = path,
                flags = flags,
            });
            return Convert.ToUInt16(resources.Count - 1);
        }

        /// <summary>
        /// Format the data in Tables 2, and 3 into the data needed 
        /// for table 1 and set the values to be written to the file
        /// </summary>
        public void PrepareTables()
        {
            for (int i = 0; i < names.Count; i++)
            {
                names[i].offset = AddString(names[i].value);
            }
            for (int i = 0; i < resources.Count; i++)
            {
                resources[i].typeid = AddName(resources[i].type);
                names[resources[i].typeid].offset = AddString(resources[i].type);
                resources[i].offset = AddString(resources[i].path);
            }
        }

        /// <summary>
        /// Serialize the data in all the tables into byte array form 
        /// and save within their header object ready for writing, along 
        /// with calculated offsets, size and crc32 checksum.
        /// </summary>
        public void SerializeTables()
        {
            PrepareTables();

            uint shift = 160;
            byte[] data = null;

            #region Table 1 - Strings
            var table1 = new List<byte>();
            foreach (var s in strings)
            {
                table1.AddRange(Encoding.ASCII.GetBytes(s.Value));
                table1.Add(0);
            }
            data = table1.ToArray();
            headers[0].data = data;
            headers[0].size = Convert.ToUInt32(data.Length);
            headers[0].crc32 = Crc32Algorithm.Compute(data);
            headers[0].offset = shift;
            shift += Convert.ToUInt32(data.Length);
            #endregion

            #region Table 2 - Names
            var table2 = new List<byte>();
            foreach (var n in names)
            {
                table2.AddRange(BitConverter.GetBytes(n.offset));
                table2.AddRange(BitConverter.GetBytes(n.hash));
            }
            data = table2.ToArray();
            headers[1].data = data;
            headers[1].size = Convert.ToUInt32(names.Count);
            headers[1].crc32 = Crc32Algorithm.Compute(data);
            headers[1].offset = shift;
            shift += Convert.ToUInt32(data.Length);
            #endregion

            #region Table 3 - Resources
            var table3 = new List<byte>();
            foreach (var r in resources)
            {
                table3.AddRange(BitConverter.GetBytes(r.offset));
                table3.AddRange(BitConverter.GetBytes(r.typeid));
                table3.AddRange(BitConverter.GetBytes(r.flags));
            }
            data = table3.ToArray();
            headers[2].data = data;
            headers[2].size = Convert.ToUInt32(resources.Count);
            headers[2].crc32 = Crc32Algorithm.Compute(data);
            headers[2].offset = shift;
            shift += Convert.ToUInt32(data.Length);
            #endregion

            #region Table 4 - Nothing
            //This could be skipped.
            //ToDo: Check to see if this can be removed without an error in-game.
            headers[3].data = new byte[16];
            headers[3].size = 1;
            headers[3].crc32 = 0xecbb4b55;
            headers[3].offset = shift;
            shift += 16;
            #endregion


        }

        #endregion

        public void WriteAll()
        {
            SerializeTables();
            BaseStream.Seek(0, SeekOrigin.Begin);

            //File Header
            Write(MAGIC);       //CR2W
            Write(VERSION);     //Version
            Write(FLAGS);       //Flags
            WriteDateTime();    //DateTime
            Write(BUILD);       //Build
            Write(0);           //Disksize
            Write(0);           //MemSize
            Write(DEADBEEF);    //CRC32
            Write(CHUNKS);      //NumChunks

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
        }

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

        public void WriteDateTime()
        {
            var d = DateTime.Now;

            Write(((((UInt32)(d.Year)) & 0b1111_1111_1111) << 20
                        | (((UInt32)(d.Month) & 0b1_1111) << 15)
                        | ((((UInt32)(d.Day))) & 0b1_1111) << 10));

            Write((((UInt32)(d.Hour)) & 0b11_1111_1111) << 22
                       | ((((UInt32)d.Minute)) & 0b11_1111) << 16
                       | ((((UInt32)d.Second)) & 0b11_1111) << 10
                       | (((UInt32)(d.Millisecond)) & 0b11_11111111));
        }

        #endregion

    }
}
