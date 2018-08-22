using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CR2W.Types;
using CR2W.CRC32;
using CR2W.FNV1A;

/*
 *      TEST PARSER
 *      This is just a test parser purley for experimentation
 * 
 *      Not to be used for any 'proper' use.
 *      Proper parser is CR2WBinaryReader
 */

namespace CR2W.IO
{
    public sealed class CR2WTestReader : BinaryReader
    {
        #region Internal Structs
        internal struct SFileHeader
        {
            public uint fileversion;
            public uint flags;
            public ulong timestamp;
            public uint buildversion;
            public uint disksize;
            public uint memsize;
            public uint crc32;
            public uint numchunks;
        }
        internal struct STableHeader
        {
            public uint Offset;
            public uint Size;
            public uint CRC32;
        }
        internal struct SName
        {
            public uint Offset;
            public uint Hash;
            public string Value;
        }
        internal struct SResource
        {
            public uint Offset;
            public string Type;
            public ushort Flags;
            public string Path;
        }
        internal struct SObject
        {
            public uint TypeID;
            public uint Flags;
            public uint ParentID;
            public uint Size;
            public uint Offset;
            public uint Template;
            public uint CRC32;
        }
        internal struct SBuffer
        {
            public uint Flags;
            public uint ID;
            public uint Offset;
            public uint DiskSize;
            public uint MemSize;
            public uint CRC32;
        }
        internal struct SEmbedded
        {
            public uint Id;
            public uint Path;
            public ulong Hash;
            public uint Offset;
            public uint Length;
        }

        internal class CSectorData
        {
            public uint Unknown1;
            public uint Unknown2;
            public SSectorDataResource[] resources;
            public SSectorDataObject[] objects;
            public byte[] blockdata;
        }
        internal struct SSectorDataResource
        {
            public float box0;
            public float box1;
            public float box2;
            public float box3;
            public float box4;
            public float box5;
            public ulong patchHash;
        }
        internal struct SSectorDataObject
        {
            public byte type;
            public byte flags;
            public ushort radius;
            public ulong offset;
            public float positionX;
            public float positionY;
            public float positionZ;
        }
        #endregion

        #region Props/Vars

        public TextWriter Writer { get; set; }

        public string FilePath { get; set; }

        private SFileHeader        fileheader;
        STableHeader[]             tableheaders;
        Dictionary<uint, string>   strings;
        List<SName>                names;
        List<SResource>            resources;
        List<STable4Item>          table4;
        List<SObject>              objects;
        List<SBuffer>              buffers;
        List<SEmbedded>            embedded;

        readonly uint Magic = 0x57325243;

        #endregion

        #region Constructors

        public CR2WTestReader(string path, TextWriter writer) 
            : base(new FileStream(path, FileMode.Open, FileAccess.Read), Encoding.ASCII, false)
        {
            BaseStream.Seek(0, SeekOrigin.Begin);
            FilePath = path;
            Writer = writer;
        }

        public CR2WTestReader(byte[] data, TextWriter writer)
            : base(new MemoryStream(data), Encoding.ASCII, false)
        {
            BaseStream.Seek(0, SeekOrigin.Begin);
            Writer = writer;
        }

        #endregion

        #region Header
        public void ReadAll()
        {
            BaseStream.Seek(0, SeekOrigin.Begin);
            
            if (Magic != ReadUInt32())
            {
                throw new Exception("Not a CR2W file");
            }
            
            fileheader.fileversion  = ReadUInt32();
            
            if(!(fileheader.fileversion >= 159 && fileheader.fileversion <= 163))
            {
                throw new Exception($"Unknown Version: {fileheader.fileversion}");
            }
            
            fileheader.flags        = ReadUInt32();
            fileheader.timestamp    = ReadUInt64();
            fileheader.buildversion = ReadUInt32();
            fileheader.disksize     = ReadUInt32();
            fileheader.memsize      = ReadUInt32();
            fileheader.crc32        = ReadUInt32();
            fileheader.numchunks    = ReadUInt32();

            var ts = new CDateTime(fileheader.timestamp);

            Writer.WriteLine("FileName:       {0}", Path.GetFileName(FilePath));
            Writer.WriteLine("FileVersion:    {0}", fileheader.fileversion);
            Writer.WriteLine("Flags:          {0}", fileheader.flags);
            Writer.WriteLine("DateTime:       {0}.{1}", ts.ToString(), ts.Value.Millisecond);
            Writer.WriteLine("BuildVersion:   {0}", fileheader.buildversion);
            Writer.WriteLine("DiskSize:       {0}", fileheader.disksize);
            Writer.WriteLine("MemSize:        {0}", fileheader.memsize);
            Writer.WriteLine("CRC32:          0x{0:X}", fileheader.crc32);
            Writer.WriteLine("NumChunks:      {0}", fileheader.numchunks);
            
            GetHeaders();
            
            Writer.WriteLine("\nComputed CRC32: 0x{0:X}", CalculateHeaderCRC32(fileheader));
            
            GetStrings();
            GetNames();
            GetResources();
            GetTable4();
            GetObjects();
            GetBuffers();
            GetEmbedded();

            ReadObjectData();
        }
        private uint CalculateHeaderCRC32(SFileHeader fileheader)
        {
            var b = new List<Byte>();
            b.AddRange(BitConverter.GetBytes(0x57325243));
            b.AddRange(BitConverter.GetBytes(fileheader.fileversion));
            b.AddRange(BitConverter.GetBytes(fileheader.flags));
            b.AddRange(BitConverter.GetBytes(fileheader.timestamp));
            b.AddRange(BitConverter.GetBytes(fileheader.buildversion));
            b.AddRange(BitConverter.GetBytes(fileheader.disksize));
            b.AddRange(BitConverter.GetBytes(fileheader.memsize));
            b.AddRange(BitConverter.GetBytes(0xDEADBEEF));
            b.AddRange(BitConverter.GetBytes(fileheader.numchunks));
            foreach (var h in tableheaders)
            {
                b.AddRange(BitConverter.GetBytes(h.Offset));
                b.AddRange(BitConverter.GetBytes(h.Size));
                b.AddRange(BitConverter.GetBytes(h.CRC32));
            }
            return Crc32Algorithm.Compute(b.ToArray());
        }
        void GetHeaders()
        {
            tableheaders = new STableHeader[10];
            for (int i = 0; i < 10; i++)
            {
                tableheaders[i] = new STableHeader()
                {
                    Offset  = ReadUInt32(),
                    Size    = ReadUInt32(),
                    CRC32   = ReadUInt32(),
                };
            }

            Writer.WriteLine("\n");
            Writer.WriteLine("\tHeaders");
            Writer.WriteLine("\n");
            Writer.WriteLine("|ID |Offset    |Size      |CRC32");
            Writer.WriteLine("|---|----------|----------|----------");
            for (int i = 0; i < tableheaders.Length; i++)
            {
                var h = tableheaders[i];
                Writer.WriteLine("|{0}|{1}|{2}|0x{3:X8}", 
                    Convert.ToString(i + 1).PadRight(3), 
                    Convert.ToString(h.Offset).PadRight(10), 
                    Convert.ToString(h.Size).PadRight(10), 
                    h.CRC32);
            }
        }
        #endregion

        #region Tables
        void GetStrings()
        {
            var start = tableheaders[0].Offset;
            var size = tableheaders[0].Size;

            strings = new Dictionary<uint, string>();
            BaseStream.Seek(start, SeekOrigin.Begin);

            StringBuilder sb = new StringBuilder();

            uint offset = 0;
            for (uint i = 1; i <= size; i++)
            {
                char c = ReadChar();
                if (c == 0)
                {
                    strings.Add(offset, sb.ToString());
                    sb.Clear();
                    offset = i;
                }
                else
                {
                    sb.Append(c);
                }
            }

            Writer.WriteLine("\n");
            Writer.WriteLine("\tTable  1");
            Writer.WriteLine("\tSize   {0}", size);
            Writer.WriteLine("\tOffset {0}", start);
            Writer.WriteLine("\n");

            var j = 0;
            Writer.WriteLine("|Index     |Offset    |Value");
            Writer.WriteLine("|----------|----------|---------------------------------------");
            foreach (KeyValuePair<uint, string> entry in strings)
            {
                Writer.WriteLine("|{0}|{1}|{2}", Convert.ToString(j).PadRight(10), Convert.ToString(entry.Key).PadRight(10), entry.Value);
                j += 1;
            }
        }
        void GetNames()
        {
            names = new List<SName>();

            var start = tableheaders[1].Offset;
            var size = tableheaders[1].Size;

            BaseStream.Seek(start, SeekOrigin.Begin);

            for (int i = 0; i < size; i++)
            {
                var o = ReadUInt32();
                var h = ReadUInt32();
                var v = strings[o];
                names.Add(new SName()
                {
                    Offset = o,
                    Hash = h,
                    Value = v,
                });
            }

            Writer.WriteLine("\n");
            Writer.WriteLine("\tTable  2");
            Writer.WriteLine("\tSize   {0}", size);
            Writer.WriteLine("\tOffset {0}", start);
            Writer.WriteLine("\n");
            Writer.WriteLine("|Offset    |Hash           |Computed       |Value");
            Writer.WriteLine("|----------|---------------|---------------|---------------------------");
            foreach (var r in names)
            {
                Writer.WriteLine("|{0}|{1}|{2}|{3}", Convert.ToString(r.Offset).PadRight(10), $"0x{r.Hash:X}".PadRight(15), $"0x{FNV1A32HashAlgorithm.HashString(r.Value):X}".PadRight(15), r.Value);
            }
        }
        void GetResources()
        {
            var start = tableheaders[2].Offset;
            var size = tableheaders[2].Size;

            if (size == 0)
                return;

            resources = new List<SResource>();
            BaseStream.Seek(start, SeekOrigin.Begin);

            for (int i = 0; i < size; i++)
            {
                var o = ReadUInt32();
                var t = ReadUInt16();
                var f = ReadUInt16();

                resources.Add(new SResource()
                {
                    Offset = o,
                    Type = names[t].Value,
                    Flags = f,
                    Path = strings[o],
                });
            }
            Writer.WriteLine("\n");
            Writer.WriteLine("\tTable  3");
            Writer.WriteLine("\tSize   {0}", size);
            Writer.WriteLine("\tOffset {0}", start);
            Writer.WriteLine("\n");

            Writer.WriteLine("|Type                     |Path                                                                                                |Flags");
            Writer.WriteLine("|-------------------------|----------------------------------------------------------------------------------------------------|--------");
            foreach (var h in resources)
            {
                Writer.WriteLine("|{0}|{1}|{2}", h.Type.PadRight(25), h.Path.PadRight(100), h.Flags);
            }
        }
        void GetTable4()
        {
            var start = tableheaders[3].Offset;
            var size = tableheaders[3].Size;

            if (size == 0)
                return;

            table4 = new List<STable4Item>();
            BaseStream.Seek(start, SeekOrigin.Begin);

            for (int i = 0; i < size; i++)
            {
                table4.Add(new STable4Item()
                {
                    classId = ReadUInt16(),
                    unknown1 = ReadUInt16(),
                    propertyId = ReadUInt16(),
                    unknown2 = ReadUInt16(),
                    hash = ReadUInt64(),
                });
            }
            Writer.WriteLine("\n");
            Writer.WriteLine("\tTable  4");
            Writer.WriteLine("\tSize   {0}", size);
            Writer.WriteLine("\tOffset {0}", start);
            Writer.WriteLine("\n");

            Writer.WriteLine("|ClassName                |Unknown1   |PropertyName             |Unknown2   |Hash");
            Writer.WriteLine("|-------------------------|-----------|-------------------------|-----------|-------------------");
            foreach (var i in table4)
            {
                Writer.WriteLine("|{0}|{1}|{2}|{3}|{4}",
                    names[i.classId].Value.PadRight(25),
                    $"{i.unknown1}".PadRight(11),
                    names[i.propertyId].Value.PadRight(25),
                    $"{i.unknown2}".PadRight(11),
                    $"0x{i.hash:X}".PadRight(11));
            }
        }
        void GetObjects()
        {
            var start = tableheaders[4].Offset;
            var size = tableheaders[4].Size;

            objects = new List<SObject>();
            BaseStream.Seek(start, SeekOrigin.Begin);

            for (int i = 0; i < size; i++)
            {
                objects.Add(new SObject()
                {
                    TypeID      = ReadUInt16(),
                    Flags       = ReadUInt16(),
                    ParentID    = ReadUInt32(),
                    Size        = ReadUInt32(),
                    Offset      = ReadUInt32(),
                    Template    = ReadUInt32(),
                    CRC32       = ReadUInt32(),
                });
            }

            Writer.WriteLine("\n");
            Writer.WriteLine("\tTable  5");
            Writer.WriteLine("\tSize   {0}", size);
            Writer.WriteLine("\tOffset {0}", start);
            Writer.WriteLine("\n");
            Writer.WriteLine("|Type                          |Flags     |Parent    |Size      |Offset    |Template  |CRC32");
            Writer.WriteLine("|------------------------------|----------|----------|----------|----------|----------|----------");
            foreach (var o in objects)
            {
                Writer.WriteLine("|{0}|{1}|{2}|{3}|{4}|{5}|{6}", 
                    names[Convert.ToInt32(o.TypeID)].Value.PadRight(30),
                    Convert.ToString(o.Flags).PadRight(10),
                    Convert.ToString(o.ParentID).PadRight(10),
                    Convert.ToString(o.Size).PadRight(10),
                    Convert.ToString(o.Offset).PadRight(10),
                    Convert.ToString(o.Template).PadRight(10),
                    Convert.ToString(o.CRC32));
            }
        }
        void GetBuffers()
        {
            var start = tableheaders[5].Offset;
            var size = tableheaders[5].Size;

            if (size == 0)
                return;

            buffers = new List<SBuffer>();
            BaseStream.Seek(start, SeekOrigin.Begin);

            Writer.WriteLine("\n");
            Writer.WriteLine("\tTable 6");
            Writer.WriteLine("\tSize   {0}", size);
            Writer.WriteLine("\tOffset {0}", start);
            Writer.WriteLine("\n");

            for (int i = 0; i < size; i++)
            {
                buffers.Add(new SBuffer()
                {
                    Flags    = ReadUInt32(),
                    ID       = ReadUInt32(),
                    Offset   = ReadUInt32(),
                    DiskSize = ReadUInt32(),
                    MemSize  = ReadUInt32(),
                    CRC32    = ReadUInt32()
                });
            }

            Writer.WriteLine("|Flags          |ID   |Offset         |DiskSize       |MemSize        |CRC32");
            Writer.WriteLine("|---------------|-----|---------------|---------------|---------------|---------------");
            foreach (var b in buffers)
            {
                Writer.WriteLine("|{0}|{1}|{2}|{3}|{4}|{5}", Convert.ToString(b.Flags).PadRight(15),
                                                  Convert.ToString(b.ID).PadRight(5),
                                                  Convert.ToString(b.Offset).PadRight(15),
                                                  Convert.ToString(b.DiskSize).PadRight(15),
                                                  Convert.ToString(b.MemSize).PadRight(15),
                                                  b.CRC32);
            }
        }
        void GetEmbedded()
        {
            var start = tableheaders[6].Offset;
            var size = tableheaders[6].Size;

            if (size == 0)
                return;

            embedded = new List<SEmbedded>();
            BaseStream.Seek(start, SeekOrigin.Begin);

            Writer.WriteLine("\n");
            Writer.WriteLine("\tTable 7");
            Writer.WriteLine("\tSize   {0}", size);
            Writer.WriteLine("\tOffset {0}", start);
            Writer.WriteLine("\n");

            for (int i = 0; i < size; i++)
            {
                embedded.Add(new SEmbedded()
                {
                    Id      = ReadUInt32(),
                    Path    = ReadUInt32(),
                    Hash    = ReadUInt64(),
                    Offset  = ReadUInt32(),
                    Length  = ReadUInt32(),
                });
            }

            if (size == 0)
                return;

            Writer.WriteLine("|Id   |Path                                                                                                |Hash                     |Offset         |Length");
            Writer.WriteLine("|-----|----------------------------------------------------------------------------------------------------|-------------------------|---------------|---------------");
            foreach (var e in embedded)
            {
                Writer.WriteLine("|{0}|{1}|{2}|{3}|{4}", Convert.ToString(e.Id).PadRight(5),
                                                  Convert.ToString(strings[e.Path]).PadRight(100),
                                                  Convert.ToString(e.Hash).PadRight(25),
                                                  Convert.ToString(e.Offset).PadRight(15),
                                                  Convert.ToString(e.Length));
            }
        }
        #endregion

        #region Data
        private void ReadObjectData()
        {
            Writer.WriteLine("\n");
            Writer.WriteLine("\tObject Data");
            Writer.WriteLine("\n");

            foreach (var obj in objects)
            {
                BaseStream.Seek(obj.Offset, SeekOrigin.Begin);
                var end = obj.Offset + obj.Size;
                var type = names[Convert.ToInt32(obj.TypeID)].Value;

                Writer.WriteLine(type);
                Writer.WriteLine("{");
                switch (type)
                {
                    case "CSectorData":
                        {
                            var data = ReadCSectorData();
                            PrintCSectorData(data);
                        }
                        break;
                    case "CClipMapCookedData":
                        {
                            Writer.WriteLine("\tBytes: {0}", obj.Size);
                            BaseStream.Seek(obj.Size, SeekOrigin.Current);
                        }
                        break;
                    default:
                        {
                            ReadVariable("\t");
                        }
                        break;
                }
                Writer.WriteLine("}");
                if (end - BaseStream.Position > 0)
                {
                    switch (type)
                    {
                        case "CSwfResource":
                            {
                                var length = ReadInt32();
                                var swf = ReadBytes(length);
                                Writer.WriteLine("SWF Bytes: {0}", swf.Length);
                            }
                            break;
                        case "CRagdoll":
                            {
                                var length = ReadInt32();
                                var xmlstr = Encoding.UTF8.GetString(ReadBytes(length));
                                Writer.WriteLine(xmlstr);
                            }
                            break;
                        case "CBitmapTexture":
                            {
                                Writer.WriteLine("Zero:      {0}", ReadUInt32());
                                Writer.WriteLine("MipCount:  {0}", ReadUInt32());
                                Writer.WriteLine("Width:     {0}", ReadUInt32());
                                Writer.WriteLine("Height:    {0}", ReadUInt32());
                                Writer.WriteLine("Unknown5:  {0}", ReadUInt32());
                                Writer.WriteLine("Unknown6:  {0}", ReadUInt32());
                            }
                            break;
                        case "CCubeTexture":
                            {
                                Writer.WriteLine(Encoding.UTF8.GetString(ReadBytes(Convert.ToInt32(end - BaseStream.Position))));
                            }
                            break;
                    }
                    var unknown = ReadBytes(Convert.ToInt32(end - BaseStream.Position));
                    Writer.WriteLine("Unknown Bytes: {0}", unknown.Length);
                }
                else
                {
                    Writer.WriteLine("Unknown Bytes: 0");
                }
                Writer.WriteLine();
            }
        }
        private void ReadBufferData()
        {

        }
        private void ReadEmbeddedData()
        {

        }
        #endregion

        #region Variables
        void ReadVariable(string offset)
        {
            ReadByte();
            while (true)
            {
                var nameId = ReadInt16();
                if(nameId == 0)
                {
                    break;
                }
                var typeId = ReadInt16();
                var size = ReadInt32() - 4;
                Writer.Write("{0}{1} {2}", offset, names[nameId].Value, names[typeId].Value);
                var start = BaseStream.Position;
                ParseVariale(names[typeId].Value, size, $"\t{offset}");
                var end = BaseStream.Position;
                if (end - start != size)
                {
                    Writer.WriteLine();
                    Writer.WriteLine("ERROR!!!!!!!!!");
                    Writer.WriteLine("Expected Size: {0}", size);
                    Writer.WriteLine("Actual Size:   {0}", end - start);
                }
            }
        }
        void ParseVariale(string type, int size, string offset)
        {
            var arr = type.Split(new char[] { ':' }, 2);
            switch (arr[0])
            {
                case "Uint8":
                    {
                        Writer.WriteLine(" {0}", ReadByte());
                    }
                    return;
                case "Uint16":
                    {
                        Writer.WriteLine(" {0}", ReadUInt16());
                    }
                    return;
                case "Uint32":
                    {
                        Writer.WriteLine(" {0}", ReadUInt32());
                    }
                    return;
                case "Uint64":
                    {
                        Writer.WriteLine(" {0}", ReadUInt64());
                    }
                    return;
                case "Int8":
                    {
                        Writer.WriteLine(" {0}", ReadSByte());
                    }
                    return;
                case "Int16":
                    {
                        Writer.WriteLine(" {0}", ReadInt16());
                    }
                    return;
                case "Int32":
                    {
                        Writer.WriteLine(" {0}", ReadInt32());
                    }
                    return;
                case "Int64":
                    {
                        Writer.WriteLine(" {0}", ReadInt64());
                    }
                    return;
                case "Float":
                    {
                        Writer.WriteLine(" {0}", ReadSingle());
                    }
                    return;
                case "Double":
                    {
                        Writer.WriteLine(" {0}", ReadDouble());
                    }
                    return;
                case "String":
                    {
                        var length = ReadVLQInt32();
                        if (length < 0)
                        {
                            Writer.WriteLine(" {0}", Encoding.ASCII.GetString(ReadBytes(length * -1)));
                        }
                        else
                        {
                            Writer.WriteLine(" {0}", Encoding.Unicode.GetString(ReadBytes(length * 2)));
                        }
                    }
                    return;
                case "StringAnsi":
                    {
                        var b = ReadByte();
                        var nxt = (b & (1 << 7)) != 0;
                        int len = b & ((1 << 7) - 1);

                        if (nxt)
                        {
                            Writer.WriteLine(" {0}", Encoding.Unicode.GetString(ReadBytes(len * 2)));
                        }
                        else
                        {
                            Writer.WriteLine(" {0}", Encoding.ASCII.GetString(ReadBytes(len)));
                        }
                    }
                    return;
                case "Bool":
                    {
                        Writer.WriteLine(" {0}", ReadBoolean());
                    }
                    return;
                case "CName":
                    {
                        Writer.WriteLine(" {0}", names[ReadUInt16()].Value);
                    }
                    return;
                case "CGUID":
                    {
                        Writer.WriteLine(" {0}", new CGUID(ReadBytes(16)).ToString());
                    }
                    return;
                case "LocalizedString":
                    {
                        Writer.WriteLine(" {0}", ReadUInt32());
                    }
                    return;
                case "ptr":
                    {
                        Writer.WriteLine(" Object {0}", ReadUInt32());
                    }
                    return;
                case "soft":
                    {
                        var res = resources[ReadUInt16() - 1];
                        Writer.WriteLine(" {0} {1} ({2})", res.Type, res.Path, res.Flags);
                    }
                    return;
                case "array":
                    {
                        var len = ReadUInt32();
                        arr = arr[1].Split(new char[] { ',' }, 3);
                        Writer.WriteLine(" {0}", len);
                        Writer.WriteLine("{0}{{", offset.Substring(1));
                        for (uint i = 0; i < len; i++)
                        {
                            Writer.Write("{0}Id {1}:", offset, i);
                            ParseVariale(arr[2], size, $"\t{offset}");
                        }
                        Writer.WriteLine("{0}}}", offset.Substring(1));
                    }
                    return;
                case "handle":
                    {
                        var id = ReadInt32();
                        if (id >= 0)
                        {
                            Writer.WriteLine(" Object: {0}", id);
                        }
                        else
                        {
                            id *= -1;
                            var res = resources[id - 1];
                            Writer.WriteLine(" {0} {1} ({2})", res.Type, res.Path, res.Flags);
                        }
                    }
                    return;
                case "SAppearanceAttachment":
                    {
                        Writer.WriteLine();
                        Writer.WriteLine("{0}{{", offset.Substring(1));
                        ReadVariable(offset);
                        var bytecount = ReadInt32();
                        var unknown = ReadBytes(bytecount - 4);
                        Writer.WriteLine("{0}Unknown Bytes: {1}", offset, bytecount - 4);
                        Writer.WriteLine("{0}}}", offset.Substring(1));
                    }
                    return;
                case "IdTag":
                    {
                        var dynamic = ReadBoolean();
                        var guid = new CGUID(ReadBytes(16));
                        if(dynamic)
                        {
                            Writer.WriteLine(" [Dynamic: {0}]", guid.ToString());
                        }
                        else
                        {
                            Writer.WriteLine(" [Static: {0}]", guid.ToString());
                        }
                    }
                    return;
                case "EngineTransform":
                    {
                        Writer.Write(" [ ");
                        var flags = ReadByte();
                        if ((flags & 1) == 1)
                        {
                            Writer.Write("Posistion:{0},{1},{2} ", ReadSingle(), ReadSingle(), ReadSingle());
                        }
                        if ((flags & 2) == 2)
                        {
                            Writer.Write("Rotation:{0},{1},{2} ", ReadSingle(), ReadSingle(), ReadSingle());
                        }
                        if ((flags & 4) == 4)
                        {
                            Writer.Write("Scale:{0},{1},{2} ", ReadSingle(), ReadSingle(), ReadSingle());
                        }
                        Writer.WriteLine("]");
                    }
                    return;
                case "EngineQsTransform":
                    {
                        Writer.Write("[ ");
                        var flags = ReadByte();
                        if ((flags & 1) == 1)
                        {
                            Writer.Write("Posistion:{0},{1},{2} ", ReadSingle(), ReadSingle(), ReadSingle());
                        }
                        if ((flags & 2) == 2)
                        {
                            Writer.Write("Rotation:{0},{1},{2},{3} ", ReadSingle(), ReadSingle(), ReadSingle(), ReadSingle());
                        }
                        if ((flags & 4) == 4)
                        {
                            Writer.Write("Scale:{0},{1},{2} ", ReadSingle(), ReadSingle(), ReadSingle());
                        }
                        Writer.WriteLine("]");
                    }
                    return;
                case "TagList":
                    {
                        var count = ReadByte();
                        var tags = new string[count];
                        for (var i = 0; i < count; i++)
                        {
                            tags[i] = names[ReadUInt16()].Value;
                        }
                        Writer.WriteLine(" [{0}]", string.Join(",", tags));
                    }
                    return;
                case "EntityHandle":
                    {
                        /*
                         *  Read the first byte which will tell you what type of entity handle it is.
                         *  Values:
                         *      0 - None - 0 bytes
                         *      1 - Entity Guid - 32 bytes
                         *      2 - IdTag - 17 bytes
                         *      
                         *      Then read off that variable type.
                         *      
                         *      IdTag:
                         *          1 Byte - 0 = Static, 1 = Dynamic
                         *          16 Bytes - Guid Value
                         *      Entity:
                         *          16 Bytes - Guid Value
                         *          16 Bytes - Unknown
                         *      
                         */
                        var handletype = ReadByte();
                        switch (handletype)
                        {
                            //Entity
                            case 1:
                                var eguid = new CGUID(ReadBytes(16));
                                var unkn = ReadBytes(16);
                                Writer.WriteLine(" [Entity - {0}]", eguid.ToString());
                                break;
                            //IdTag
                            case 2:
                                var dynamic = ReadBoolean();
                                var guid = new CGUID(ReadBytes(16));
                                if (dynamic)
                                {
                                    Writer.WriteLine(" [Dynamic: {0}]", guid.ToString());
                                }
                                else
                                {
                                    Writer.WriteLine(" [Static: {0}]", guid.ToString());
                                }
                                break;
                        }
                    }
                    return;
                case "static":
                    {
                        var length = ReadUInt32();
                        arr = arr[1].Split(new char[] { ',' }, 2);
                        Writer.WriteLine(" {0}", length);
                        Writer.WriteLine("{0}{{", offset.Substring(1));
                        for (uint i = 0; i < length; i++)
                        {
                            Writer.Write("{0}Id {1}:", offset, i);
                            ParseVariale(arr[1], size, $"\t{offset}");
                        }
                        Writer.WriteLine("{0}}}", offset.Substring(1));
                    }
                    return;
                case "CDateTime":
                    {
                        var datetime = new CDateTime(ReadUInt64());
                        Writer.WriteLine(" {0}.{1}", datetime.ToString(), datetime.Value.Millisecond);
                    }
                    return;
                case "SharedDataBuffer":
                    {
                        var datasize = ReadInt32();
                        var bytes = ReadBytes(datasize);
                        Writer.WriteLine(" {0} bytes", datasize);
                    }
                    return;
                case "DataBuffer":
                    {
                        var datasize = ReadInt32();
                        var bytes = ReadBytes(datasize);
                        Writer.WriteLine(" {0} bytes", datasize);
                    }
                    return;
                case "DeferredDataBuffer":
                    {
                        Writer.WriteLine(" {0}", ReadUInt16());
                    }
                    return;
                case "CPhysicalCollision":
                    {
                        var unknown = ReadUInt32();
                        var nameCount = ReadByte();
                        
                        Writer.WriteLine();
                        Writer.WriteLine("{0}{{", offset.Substring(1));
                        Writer.WriteLine("{0}unknown Uint32 {1}", offset, unknown);
                        Writer.WriteLine("{0}Types", offset);
                        Writer.WriteLine("{0}{{", offset);
                        for (byte i = 0; i < nameCount; i++)
                        {
                            Writer.WriteLine("\t{0}Id {1}: {2}", offset, i, names[ReadUInt16()].Value);
                        }
                        Writer.WriteLine("{0}}}", offset);
                        Writer.WriteLine("{0}Bytes {1}", offset, String.Join(", ", ReadBytes(16)));
                        Writer.WriteLine("{0}}}", offset.Substring(1));
                    }
                    return;
            }

            Type myType = Type.GetType($"CR2W.Types.W3.{type}");
            if (myType != null)
            {
                if (myType.IsEnum)
                {
                    if (myType.IsDefined(typeof(FlagsAttribute), false))
                    {
                        var values = new List<string>();
                        while (true)
                        {
                            var flag = ReadUInt16();
                            if(flag == 0)
                            {
                                break;
                            }
                            values.Add(names[flag].Value);
                        }
                        if(values.Count != 0)
                        {
                            Writer.WriteLine(" {0}", Enum.Parse(myType, String.Join(",", values)));
                        }
                        else
                        {
                            Writer.WriteLine(" {0}", "None");
                        }
                    }
                    else
                    {
                        var value = names[ReadUInt16()].Value;
                        Writer.WriteLine(" {0}", value);
                    }
                    return;
                }
            }

            Writer.WriteLine();
            Writer.WriteLine("{0}{{", offset.Substring(1));
            ReadVariable(offset);
            Writer.WriteLine("{0}}}", offset.Substring(1));
        }
        #endregion

        #region Specific Parsers
        private CSectorData ReadCSectorData()
        {
            var temp = new CSectorData()
            {
                Unknown1 = ReadUInt32(),
                Unknown2 = ReadUInt32(),
            };

            var numresources = ReadVLQInt32();
            temp.resources = new SSectorDataResource[numresources];
            for (int i = 0; i < numresources; i++)
            {
                temp.resources[i] = new SSectorDataResource()
                {
                    box0 = ReadSingle(),
                    box1 = ReadSingle(),
                    box2 = ReadSingle(),
                    box3 = ReadSingle(),
                    box4 = ReadSingle(),
                    box5 = ReadSingle(),
                    patchHash = ReadUInt64(),
                };
            }
            
            var numobjects = ReadVLQInt32();
            temp.objects = new SSectorDataObject[numobjects];
            for (int i = 0; i < numobjects; i++)
            {
                temp.objects[i] = new SSectorDataObject()
                {
                    type = ReadByte(),
                    flags = ReadByte(),
                    radius = ReadUInt16(),
                    offset = ReadUInt64(),
                    positionX = ReadSingle(),
                    positionY = ReadSingle(),
                    positionZ = ReadSingle(),
                };
            }
            
            var datasize = ReadVLQInt32();
            temp.blockdata = ReadBytes(datasize);

            return temp;
        }
        private void PrintCSectorData(CSectorData temp)
        {
            Writer.WriteLine("\tUnknown1   {0}", temp.Unknown1);
            Writer.WriteLine("\tUnknown2   {0}", temp.Unknown2);
            Writer.WriteLine("\tresources  {0}", temp.resources.Length);
            Writer.WriteLine("\t{");
            for (int i = 0; i < temp.resources.Length; i++)
            {
                Writer.WriteLine("\t\tId {0}:", i);
                Writer.WriteLine("\t\t{");
                Writer.WriteLine("\t\t\tBox0:      {0}", temp.resources[i].box0);
                Writer.WriteLine("\t\t\tBox1:      {0}", temp.resources[i].box1);
                Writer.WriteLine("\t\t\tBox2:      {0}", temp.resources[i].box2);
                Writer.WriteLine("\t\t\tBox3:      {0}", temp.resources[i].box3);
                Writer.WriteLine("\t\t\tBox4:      {0}", temp.resources[i].box4);
                Writer.WriteLine("\t\t\tBox5:      {0}", temp.resources[i].box5);
                Writer.WriteLine("\t\t\tPatchHash: {0}", temp.resources[i].patchHash);
                Writer.WriteLine("\t\t}");
            }
            Writer.WriteLine("\t}");
            Writer.WriteLine("\tobjects {0}", temp.objects.Length);
            Writer.WriteLine("\t{");
            for (int i = 0; i < temp.objects.Length; i++)
            {
                Writer.WriteLine("\t\tId {0}:", i);
                Writer.WriteLine("\t\t{");
                Writer.WriteLine("\t\t\tType:            {0}", temp.objects[i].type);
                Writer.WriteLine("\t\t\tFlags:           {0}", temp.objects[i].flags);
                Writer.WriteLine("\t\t\tRadius:          {0}", temp.objects[i].radius);
                Writer.WriteLine("\t\t\tOffset:          {0}", temp.objects[i].offset);
                Writer.WriteLine("\t\t\tPositionX:       {0}", temp.objects[i].positionX);
                Writer.WriteLine("\t\t\tPositionY:       {0}", temp.objects[i].positionY);
                Writer.WriteLine("\t\t\tPositionZ:       {0}", temp.objects[i].positionZ);
                Writer.WriteLine("\t\t}");
            }
            Writer.WriteLine("\t}");
            Writer.WriteLine("\tBlock Data: {0}", temp.blockdata.Length);
        }
        #endregion

        #region Supporting Functions
        /* - Format Info
         * 
         *  This is a format where each byte in the value is flagged.
         *  The First Byte has 2 flags as the first 2 bits
         *  The remaining bytes have only 1 flag as the first bit.
         *  
         *  First byte:
         *       01000111
         *       ^^^^^^^^
         *       |||____|_ 6 bit value
         *       ||_______ flag: next byte required
         *       |________ flag: signed value
         *  
         *  Next bytes:
         *       10000001
         *       ^^^^^^^^
         *       ||_____|_ 7 bit value
         *       |________ flag: next byte required
         *  
         *  --------------------------------------------------------------
         *  
         *  Example1:
         *  This example shows a 3 byte length value.
         *  
         *       011001111000110100000001
         *       ^^^^^^^^^^^^^^^^^^^^^^^^
         *       |      ||      ||______|_____ Third Byte (1 flag)
         *       |      ||______|_____________ Second Byte (1 flag)
         *       |______|_____________________ First Byte (2 flags)
         *  
         *  The first byte is read. 
         *  The two flags (first two bits) indicate if the 
         *  final number will be positive or negative and if the a following byte needs to be read.
         *  
         *  First Byte:
         *       0      - Positive
         *       1      - Next Needed
         *       100111 - Value
         *  
         *  A second byte is read as dictated from the last byte.
         *  The flag here indicates that another byte needs to be read as well
         *  
         *  Second Byte:
         *       1       - Next Needed
         *       0001101 - Value
         *  
         *  A third byte is read as dictated from the last byte.
         *  The flag here indicates that no more bytes need to be read.
         *  
         *  Thrid Byte:
         *       0       - Next Not Needed
         *       0000001 - Value
         *  
         *  The final value is a contatination of the values from each byte.
         *  The 6 bit value from the first byte and the two 7 bit values from the next two bytes.
         *  Each value is added onto the front of the final binary value.
         *  The final value is this:
         *  
         *  Value:
         *       00000010001101100111 = 9063
         *  
         *  --------------------------------------------------------------
         *  
         *  Example2:
         *       0111001000000111
         *       ^^^^^^^^^^^^^^^^
         *       |      ||______|____ Second Byte (1 flags)
         *       |______|____________ First Byte (2 flags)
         *  
         *  First Byte:
         *       0      - Positive
         *       1      - Next Needed
         *       110010 - Value
         *  
         *  Second Byte:
         *       0       - Next Not Needed
         *       0000111 - Value
         *  
         *  Value:
         *       0000111110010 = 498
         *  
         */
        public int ReadVLQInt32()
        {
            var b1 = ReadByte();
            var sign = (b1 & 128) == 128;
            var next = (b1 & 64) == 64;
            var size = b1 % 128 % 64;
            var offset = 6;
            while (next)
            {
                var b = ReadByte();
                size = (b % 128) << offset | size;
                next = (b & 128) == 128;
                offset += 7;
            }
            size = sign ? size * -1 : size;
            return size;
        }
        public uint ReadVLQUInt32()
        {
            var b1 = ReadByte();
            var next = (b1 & 128u) == 128u;
            uint size = b1 % 128u;
            var offset = 7;
            while (next)
            {
                var b = ReadByte();
                size = (b % 128u) << offset | size;
                next = (b & 128) == 128;
                offset += 7;
            }
            return size;
        }
        #endregion

        #region Cleaning Up
        protected override void Dispose(bool disposing)
        {
            strings     = null;
            names       = null;
            resources   = null;
            objects     = null;
            buffers     = null;
            embedded    = null;
            base.Dispose(disposing);
        }
        #endregion
    }
}