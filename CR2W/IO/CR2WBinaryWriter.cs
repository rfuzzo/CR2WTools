using CR2W.Types.W3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CR2W.CRC32;
using CR2W.Types;

namespace CR2W.IO
{
    public sealed class CR2WBinaryWriter : BinaryWriter
    {
        public SHeader[]                headers;
        public Dictionary<uint, string> strings;
        public List<SName>              names;
        public List<SResource>          resources;
        public List<SObject>            objects;
        public List<SBuffer>            buffers;
        public List<SEmbedded>          embedded;

        public CR2WBinaryWriter() : base(new MemoryStream(), Encoding.ASCII, false)
        {
            headers     = new SHeader[10];
            strings     = new Dictionary<uint, string>();
            names       = new List<SName>();
            resources   = new List<SResource>();
            objects     = new List<SObject>();
            buffers     = new List<SBuffer>();
            embedded    = new List<SEmbedded>();

            AddName("");
        }

        public void Create( CResource resource )
        {

        }

        /// <summary>
        /// Add a string value to Table 1. If that value already exists this will retun the offset of the existing one.
        /// </summary>
        /// <param name="value">String value to add to the table</param>
        /// <returns>uint value of the offset that string has in the table</returns>
        public uint AddString( string value )
        {
            if(strings.ContainsValue(value))
            {
                return strings.First(x => x.Value == value).Key;
            }
            var last = strings.Last();
            var offset = Convert.ToUInt32(last.Key + last.Value.Length + 1);
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
            //TODO! - Calculate Hash Here!
            uint h = 0;
            uint of = AddString(value);

            if (names.Where(n => n.offset == of).Any())
            {
                return Convert.ToUInt16(names.IndexOf(names.First(n => n.offset == of)));
            }
            names.Add(new SName()
            {
                hash = h,
                offset = of,
            });
            return Convert.ToUInt16(names.Count - 1);
        }

        /// <summary>
        /// Add a resource to Table 3. If that value already exists then this will return the index of the existing one. 
        /// </summary>
        /// <param name="type">Resource type class name</param>
        /// <param name="path">Depot path of the resource</param>
        /// <param name="f">Resource flags</param>
        /// <returns>The index of the item in table 3</returns>
        public ushort AddResource( string type, string path, ushort f )
        {
            var id = AddName(type);
            var of = AddString(path);

            if(resources.Where(r => r.offset == of && r.typeid == id && r.flags == f).Any())
            {
                return Convert.ToUInt16( resources.IndexOf(resources.First(r => r.offset == of && r.typeid == id && r.flags == f)));
            }
            resources.Add(new SResource()
            {
                typeid = id,
                offset = of,
                flags = f,
            });
            return Convert.ToUInt16(resources.Count - 1);
        }

        public uint AddObject(SObject value)
        {
            var bytes = ((MemoryStream)BaseStream).ToArray();

            value.crc32 = Crc32Algorithm.Compute(bytes);
            value.size = Convert.ToUInt32(bytes.Length);
            value.data = bytes;
            objects.Add(value);

            BaseStream.SetLength(0);
            return Convert.ToUInt32(objects.Count);
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

        #endregion

    }
}
