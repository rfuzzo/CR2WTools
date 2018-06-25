using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CR2W.Types;

/*
 *      TEST PARSER
 *      This is just a test parser purley for experimentation
 * 
 *      Not to be used for any 'proper' use.
 *      Proper parser is in CR2W.IO
 */

namespace CR2W.Testing
{
    internal struct SHeader
    {
        public uint Offset;
        public uint Size;
        public uint CRC32;
    }
    internal struct SName
    {
        public uint Offset;
        public uint CRC32;
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
        public uint  Id;
        public uint  Path;
        public ulong Hash;
        public uint  Offset;
        public uint  Length;
    }

    public sealed class CR2WTestReader : BinaryReader
    {
        public TextWriter Writer { get; set; }

        public string   Path            { get; set; }
        public uint     FileVersion     { get; set; }
        public uint     Flags           { get; set; }
        public DateTime TimeStamp       { get; set; }
        public uint     BuildVersion    { get; set; }
        public uint     CR2WSize        { get; set; }
        public uint     BufferSize      { get; set; }
        public uint     CRC32           { get; set; }
        public uint     NumChunks       { get; set; }

        SHeader[] headers;

        Dictionary<uint, string>    strings;
        List<SName>                 names;
        List<SResource>             resources;
        List<SObject>               objects;
        List<SBuffer>               buffers;
        List<SEmbedded>             embedded;

        readonly byte[] Magic = { 67, 82, 50, 87 };

        public CR2WTestReader(string path, TextWriter writer) 
            : base(new FileStream(path, FileMode.Open, FileAccess.Read), Encoding.ASCII, false)
        {
            BaseStream.Seek(0, SeekOrigin.Begin);
            Path = path;
            Writer = writer;
        }

        #region Header
        public void ReadAll()
        {
            if (!Magic.SequenceEqual(ReadBytes(4)))
            {
                throw new Exception("Not a CR2W file");
            }

            FileVersion     = ReadUInt32();

            if(!(FileVersion == 162 || FileVersion == 163))
            {
                throw new Exception($"Unknown Version: {FileVersion}");
            }

            Flags           = ReadUInt32();
            {
                var date    = ReadInt32();
                var time    = ReadInt32();

                var year    = date >> 20;
                var month   = date >> 15 & 0x1F;
                var day     = date >> 10 & 0x1F;
                var hour    = time >> 22;
                var minute  = time >> 16 & 0x3F;
                var second  = time >> 10 & 0x3F;
                var millisecond = time & 0b11_11111111;

                TimeStamp = new DateTime(year, month, day, hour, minute, second, millisecond);
            }
            BuildVersion    = ReadUInt32();
            CR2WSize        = ReadUInt32();
            BufferSize      = ReadUInt32();
            CRC32           = ReadUInt32();
            NumChunks       = ReadUInt32();

            Writer.WriteLine("FileVersion:  {0}", FileVersion);
            Writer.WriteLine("Flags:        {0}", Flags);
            Writer.WriteLine("DateTime:     {0}", TimeStamp.ToString());
            Writer.WriteLine("BuildVersion: {0}", BuildVersion);
            Writer.WriteLine("CR2WSize:     {0}", CR2WSize);
            Writer.WriteLine("BufferSize:   {0}", BufferSize);
            Writer.WriteLine("CRC32:        {0}", CRC32);
            Writer.WriteLine("NumChunks:    {0}", NumChunks);
            
            GetHeaders();
            GetStrings();
            GetNames();
            GetResources();
            GetObjects();
            GetBuffers();
            GetEmbedded();
        }
        void GetHeaders()
        {
            headers = new SHeader[10];
            for (int i = 0; i < 10; i++)
            {
                headers[i] = new SHeader()
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
            for (int i = 0; i < headers.Length; i++)
            {
                var h = headers[i];
                Writer.WriteLine("|{0}|{1}|{2}|{3}", Convert.ToString(i + 1).PadRight(3), Convert.ToString(h.Offset).PadRight(10), Convert.ToString(h.Size).PadRight(10), h.CRC32);
            }
        }
        #endregion

        #region Tables
        void GetStrings()
        {
            var start = headers[0].Offset;
            var size = headers[0].Size;

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

            var start = headers[1].Offset;
            var size = headers[1].Size;

            BaseStream.Seek(start, SeekOrigin.Begin);

            for (int i = 0; i < size; i++)
            {
                var o = ReadUInt32();
                var c = ReadUInt32();
                var v = strings[o];
                names.Add(new SName()
                {
                    Offset = o,
                    CRC32 = c,
                    Value = v,
                });
            }

            Writer.WriteLine("\n");
            Writer.WriteLine("\tTable  2");
            Writer.WriteLine("\tSize   {0}", size);
            Writer.WriteLine("\tOffset {0}", start);
            Writer.WriteLine("\n");
            Writer.WriteLine("|Offset    |Hash           |Value");
            Writer.WriteLine("|----------|---------------|---------------------------");
            foreach (var r in names)
            {
                Writer.WriteLine("|{0}|{1}|{2}", Convert.ToString(r.Offset).PadRight(10), Convert.ToString(r.CRC32).PadRight(15), r.Value);
            }
        }
        void GetResources()
        {
            var start = headers[2].Offset;
            var size = headers[2].Size;

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

            Writer.WriteLine("|Type                |Path                                                             |Flags");
            Writer.WriteLine("|--------------------|-----------------------------------------------------------------|--------");
            foreach (var h in resources)
            {
                Writer.WriteLine("|{0}|{1}|{2}", h.Type.PadRight(20), h.Path.PadRight(65), h.Flags);
            }
        }
        void GetObjects()
        {
            var start = headers[4].Offset;
            var size = headers[4].Size;

            objects = new List<SObject>();
            BaseStream.Seek(start, SeekOrigin.Begin);

            Writer.WriteLine("\n");
            Writer.WriteLine("\tTable  5");
            Writer.WriteLine("\tSize   {0}", size);
            Writer.WriteLine("\tOffset {0}", start);
            Writer.WriteLine("\n");

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

                Writer.WriteLine("Index     {0}", i);
                Writer.WriteLine("TypeId    {0} - {1}", objects[i].TypeID, names[Convert.ToInt32(objects[i].TypeID)].Value);
                Writer.WriteLine("Flags     {0}", objects[i].Flags);
                Writer.WriteLine("Parent    {0}", objects[i].ParentID);
                Writer.WriteLine("Size      {0}", objects[i].Size);
                Writer.WriteLine("Offset    {0}", objects[i].Offset);
                Writer.WriteLine("Template  {0}", objects[i].Template);
                Writer.WriteLine("CRC32     {0}", objects[i].CRC32);

                var pos = BaseStream.Position;
                var end = pos + objects[i].Size;

                BaseStream.Seek(Convert.ToInt32(objects[i].Offset), SeekOrigin.Begin);

                Writer.WriteLine("Data");
                Writer.WriteLine("{");
                ReadVariable("\t");
                Writer.WriteLine("}");

                if (end - BaseStream.Position > 0)
                {
                    var unknown = ReadBytes(Convert.ToInt32(end - BaseStream.Position));
                    Writer.WriteLine("Unknown Bytes: {0}", unknown.Length);
                }
                else
                {
                    Writer.WriteLine("Unknown Bytes: 0");
                }
                Writer.WriteLine();
                BaseStream.Seek(pos, SeekOrigin.Begin);
            }
        }
        void GetBuffers()
        {
            var start = headers[5].Offset;
            var size = headers[5].Size;

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
            var start = headers[6].Offset;
            var size = headers[6].Size;

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

            Writer.WriteLine("|Id   |Path                                                        |Hash                     |Offset         |Length");
            Writer.WriteLine("|-----|------------------------------------------------------------|-------------------------|---------------|---------------");
            foreach (var e in embedded)
            {
                Writer.WriteLine("|{0}|{1}|{2}|{3}|{4}", Convert.ToString(e.Id).PadRight(5),
                                                  Convert.ToString(strings[e.Path]).PadRight(60),
                                                  Convert.ToString(e.Hash).PadRight(25),
                                                  Convert.ToString(e.Offset).PadRight(15),
                                                  Convert.ToString(e.Length));
            }
        }
        #endregion

        #region Variables
        void ReadVariable(string offset)
        {
            ReadByte();
            while(true)
            {
                var nameId = ReadInt16();
                if(nameId == 0)
                {
                    break;
                }
                var typeId = ReadInt16();
                var size = ReadInt32() - 4;
                Writer.Write("{0}{1} {2}", offset, names[nameId].Value, names[typeId].Value);

                if(names[nameId].Value == "flatCompiledData")
                {
                    ParseVariale("FlatCompiledData", size, $"\t{offset}");
                }
                else
                {
                    ParseVariale(names[typeId].Value, size, $"\t{offset}");
                }
            }
        }
        void ParseVariale(string type, int size, string offset )
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
                        var end = BaseStream.Position + size;

                        var b = ReadByte();
                        var nxt = (b & (1 << 6)) != 0;
                        var utf = (b & (1 << 7)) == 0;
                        int len = b & ((1 << 6) - 1);
                        if (nxt)
                        {
                            len += 64 * ReadByte();
                        }
                        if (utf)
                        {
                            Writer.WriteLine(" {0}", Encoding.Unicode.GetString(ReadBytes(len * 2)));
                        }
                        Writer.WriteLine(" {0}", Encoding.ASCII.GetString(ReadBytes(len)));
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
                        Writer.WriteLine(" Chunk {0}", ReadUInt32());
                    }
                    return;
                case "soft":
                    {
                        var Id = ReadUInt16();
                        Writer.WriteLine(" {0} {1} ({2})", resources[Id - 1].Type, resources[Id - 1].Path, resources[Id - 1].Flags);
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
                            Writer.WriteLine(" {0} {1} ({2})", resources[id - 1].Type, resources[id - 1].Path, resources[id - 1].Flags);
                        }
                    }
                    return;
                case "SAppearanceAttachment":
                    {
                        Writer.WriteLine();
                        Writer.WriteLine("{0}{{", offset.Substring(1));
                        ReadVariable(offset);
                        var bytecount = ReadInt32();
                        ReadBytes(bytecount - 4);
                        Writer.WriteLine("{0}Unknown Bytes: {1}", offset, bytecount - 4);
                        Writer.WriteLine("{0}}}", offset.Substring(1));
                    }
                    return;
                case "IdTag":
                    {
                        Writer.Write(" {0}", ReadByte());
                        Writer.WriteLine(" - {0}", new CGUID(ReadBytes(16)).ToString());
                    }
                    return;
                case "EngineTransform":
                    {
                        Writer.Write(" [");
                        var flags = ReadByte();
                        if ((flags & 1) == 1)
                        {
                            Writer.Write(" PosX:{0}", ReadSingle());
                            Writer.Write(", PosY:{0}", ReadSingle());
                            Writer.Write(", PosZ:{0}", ReadSingle());
                        }
                        if ((flags & 2) == 2)
                        {
                            if ((flags & 1) == 1)
                            {
                                Writer.Write(", ");
                            }
                            Writer.Write("RotX:{0}", ReadSingle());
                            Writer.Write(", RotY:{0}", ReadSingle());
                            Writer.Write(", RotZ:{0}", ReadSingle());
                        }
                        if ((flags & 4) == 4)
                        {
                            if((flags & 4) == 4)
                            {
                                Writer.Write(", ");
                            }
                            Writer.Write(" ScaleX:{0}", ReadSingle());
                            Writer.Write(", ScaleY:{0}", ReadSingle());
                            Writer.Write(", ScaleZ:{0}", ReadSingle());
                        }
                        Writer.WriteLine("]");
                    }
                    return;
                case "EngineQsTransform":
                    {
                        Writer.Write("[");
                        var flags = ReadByte();
                        if ((flags & 1) == 1)
                        {
                            Writer.Write("PosX:{0}", ReadSingle());
                            Writer.Write(",PosY:{0}", ReadSingle());
                            Writer.Write(",PosZ:{0}", ReadSingle());
                        }
                        if ((flags & 2) == 2)
                        {
                            Writer.Write("RotX:{0}", ReadSingle());
                            Writer.Write(",RotY:{0}", ReadSingle());
                            Writer.Write(",RotZ:{0}", ReadSingle());
                            Writer.Write(",RotW:{0}", ReadSingle());
                        }
                        if ((flags & 4) == 4)
                        {
                            Writer.Write("ScaleX:{0}", ReadSingle());
                            Writer.Write(",ScaleY:{0}", ReadSingle());
                            Writer.Write(",ScaleZ:{0}", ReadSingle());
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
                        Writer.WriteLine("[{0}]", string.Join(",", tags));
                    }
                    return;
                case "FlatCompiledData":
                    {
                        var len = ReadInt32();
                        Console.WriteLine(" |{0}|", Encoding.UTF8.GetString(ReadBytes(len)));
                    }
                    return;
                case "static":
                case "DeferredDataBuffer":
                case "SharedDataBuffer":
                case "EntityHandle":
                case "CClipMapCookedData":
                case "DataBuffer":
                    {
                        Writer.WriteLine(" {0} bytes", size);
                        BaseStream.Seek(size, SeekOrigin.Current);
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
                        Writer.WriteLine(" {0}", names[ReadUInt16()].Value);
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
    }
}
