using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CR2W.Types;
using CR2W.CRC32;
using CR2W.FNV1A;
using System.Threading;

/*
 *      TEST PARSER
 *      This is just a test parser purley for experimentation
 * 
 *      Not to be used for any 'proper' use.
 *      Proper parser is CR2WBinaryReader
 */

namespace CR2W.IO
{
    public sealed class CR2WTestReader2 : BinaryReader
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

        public class CVector
        {
            public int index;
            public string name;
            public string type;
            public uint size;
            public List<int> children;
            public object value;
            public byte[] unknown;

            public CVector()
            {
                children = new List<int>();
            }
        }

        #endregion

        #region Props/Vars

        public TextWriter Writer { get; set; }

        public string FilePath { get; set; }

        private SFileHeader fileheader;
        STableHeader[] tableheaders;
        Dictionary<uint, string> strings;
        List<SName> names;
        List<SResource> resources;
        List<SObject> objects;
        List<SBuffer> buffers;
        List<SEmbedded> embedded;

        readonly uint Magic = 0x57325243;

        public readonly List<CVector> Vectors = new List<CVector>();

        #endregion

        #region Constructors

        public CR2WTestReader2(string path, TextWriter writer)
            : base(new FileStream(path, FileMode.Open, FileAccess.Read), Encoding.ASCII, false)
        {
            BaseStream.Seek(0, SeekOrigin.Begin);
            FilePath = path;
            Writer = writer;
        }

        public CR2WTestReader2(byte[] data, TextWriter writer)
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

            fileheader.fileversion = ReadUInt32();

            if (!(fileheader.fileversion == 162 || fileheader.fileversion == 163))
            {
                throw new Exception($"Unknown Version: {fileheader.fileversion}");
            }

            fileheader.flags = ReadUInt32();
            fileheader.timestamp = ReadUInt64();
            fileheader.buildversion = ReadUInt32();
            fileheader.disksize = ReadUInt32();
            fileheader.memsize = ReadUInt32();
            fileheader.crc32 = ReadUInt32();
            fileheader.numchunks = ReadUInt32();

            Writer.WriteLine("FileVersion:    {0}", fileheader.fileversion);
            Writer.WriteLine("Flags:          {0}", fileheader.flags);
            Writer.WriteLine("DateTime:       {0}", fileheader.timestamp);
            Writer.WriteLine("BuildVersion:   {0}", fileheader.buildversion);
            Writer.WriteLine("DiskSize:       {0}", fileheader.disksize);
            Writer.WriteLine("MemSize:        {0}", fileheader.memsize);
            Writer.WriteLine("CRC32:          0x{0:X}", fileheader.crc32);
            Writer.WriteLine("NumChunks:      {0:x}", fileheader.numchunks);

            GetHeaders();
            GetStrings();
            GetNames();
            GetResources();
            GetObjects();
            GetBuffers();
            GetEmbedded();

            ReadObjectData();
        }

        void GetHeaders()
        {
            tableheaders = new STableHeader[10];
            for (int i = 0; i < 10; i++)
            {
                tableheaders[i] = new STableHeader()
                {
                    Offset = ReadUInt32(),
                    Size = ReadUInt32(),
                    CRC32 = ReadUInt32(),
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
                Writer.WriteLine("|{0}|{1}|{2}|{3}", Convert.ToString(i + 1).PadRight(3), Convert.ToString(h.Offset).PadRight(10), Convert.ToString(h.Size).PadRight(10), h.CRC32);
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
                Writer.WriteLine("|{0}|{1}|{2}|{3}", Convert.ToString(r.Offset).PadRight(10), Convert.ToString(r.Hash).PadRight(15), Convert.ToString(FNV1A32HashAlgorithm.HashString(r.Value)).PadRight(15), r.Value);
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
                    TypeID = ReadUInt16(),
                    Flags = ReadUInt16(),
                    ParentID = ReadUInt32(),
                    Size = ReadUInt32(),
                    Offset = ReadUInt32(),
                    Template = ReadUInt32(),
                    CRC32 = ReadUInt32(),
                });
            }

            Writer.WriteLine("\n");
            Writer.WriteLine("\tTable  5");
            Writer.WriteLine("\tSize   {0}", size);
            Writer.WriteLine("\tOffset {0}", start);
            Writer.WriteLine("\n");
            Writer.WriteLine("|Type                                                   |Flags     |Parent    |Size      |Offset    |Template  |CRC32");
            Writer.WriteLine("|-------------------------------------------------------|----------|----------|----------|----------|----------|----------");
            foreach (var o in objects)
            {
                Writer.WriteLine("|{0}|{1}|{2}|{3}|{4}|{5}|{6}",
                    names[Convert.ToInt32(o.TypeID)].Value.PadRight(55),
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
                    Flags = ReadUInt32(),
                    ID = ReadUInt32(),
                    Offset = ReadUInt32(),
                    DiskSize = ReadUInt32(),
                    MemSize = ReadUInt32(),
                    CRC32 = ReadUInt32()
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
                    Id = ReadUInt32(),
                    Path = ReadUInt32(),
                    Hash = ReadUInt64(),
                    Offset = ReadUInt32(),
                    Length = ReadUInt32(),
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

                var vector = new CVector()
                {
                    type = names[Convert.ToInt32(obj.TypeID)].Value,
                    size = obj.Size,
                    index = Vectors.Count,
                };
                Vectors.Add(vector);
                ReadVariable(vector);

                var unknsize = end - BaseStream.Position;
                if (unknsize != 0)
                {
                    vector.unknown = ReadBytes(Convert.ToInt32(unknsize));
                }
            }

            foreach (var v in Vectors)
            {
                Writer.WriteLine("Vector:   {0}", v.index);
                Writer.WriteLine("Name:     {0}", v.name);
                Writer.WriteLine("Type:     {0}", v.type);
                if(v.children.Count != 0)
                {
                    Writer.WriteLine("Children: {0}", String.Join(",", v.children));
                }
                if(v.value != null)
                {
                    Writer.WriteLine("Value:    {0}", v.value.ToString());
                }
                if(v.unknown != null)
                {
                    Writer.WriteLine("Unknown:  {0} bytes", v.unknown.Length);
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
        void ReadVariable(CVector parent)
        {
            ReadByte();
            while (true)
            {
                var nameId = ReadUInt16();
                if (nameId == 0)
                {
                    break;
                }
                var typeId = ReadUInt16();
                var size = ReadUInt32() - 4;

                var end = BaseStream.Position + size;

                var index = Vectors.Count;
                parent.children.Add(index);
                var child = new CVector()
                {
                    index = index,
                    name = names[nameId].Value,
                    type = names[typeId].Value,
                    size = size,
                };
                Vectors.Add(child);
                ParseVariale(child);

                var unknsize = end - BaseStream.Position;
                if(unknsize != 0)
                {
                    child.unknown = ReadBytes(Convert.ToInt32(unknsize));
                }
            }
        }
        void ParseVariale(CVector vector)
        {
            Console.WriteLine("{0} : {1}", vector.name, vector.type);
            var arr = vector.type.Split(new char[] { ':' }, 2);
            switch (arr[0])
            {
                case "Uint8":               vector.value = ReadByte();                  return;
                case "Uint16":              vector.value = ReadUInt16();                return;
                case "Uint32":              vector.value = ReadUInt32();                return;
                case "Uint64":              vector.value = ReadUInt64();                return;
                case "Int8":                vector.value = ReadSByte();                 return;
                case "Int16":               vector.value = ReadInt16();                 return;
                case "Int32":               vector.value = ReadInt32();                 return;
                case "Int64":               vector.value = ReadInt64();                 return;
                case "Float":               vector.value = ReadSingle();                return;
                case "Double":              vector.value = ReadDouble();                return;
                case "String":              vector.value = ReadString();                return;
                case "StringAnsi":          vector.value = ReadStringAnsi();            return;
                case "Bool":                vector.value = ReadBoolean();               return;
                case "CName":               vector.value = ReadCName();                 return;
                case "CGUID":               vector.value = ReadCGUID();                 return;
                case "LocalizedString":     vector.value = ReadLocalizedString();       return;
                case "IdTag":               vector.value = ReadIdTag();                 return;
                case "EngineTransform":     vector.value = ReadEngineTransform();       return;
                case "EngineQsTransform":   vector.value = ReadEngineQsTransform();     return;
                case "TagList":             vector.value = ReadTagList();               return;
                case "EntityHandle":        vector.value = ReadEntityHandle();          return;
                case "CDateTime":           vector.value = ReadCDateTime();             return;
                case "DataBuffer":          vector.value = ReadDataBuffer();            return;
                case "SharedDataBuffer":    vector.value = ReadSharedDataBuffer();      return;
                case "DeferredDataBuffer":  vector.value = ReadDeferredDataBuffer();    return;
                case "array":
                    {
                        var len = ReadUInt32();
                        arr = arr[1].Split(new char[] { ',' }, 3);
                        for (uint i = 0; i < len; i++)
                        {
                            var index = Vectors.Count;
                            vector.children.Add(index);
                            var arrvector = new CVector()
                            {
                                index = index,
                                name = $"{vector.name}[{i}]",
                                type = arr[2],
                            };
                            Vectors.Add(arrvector);
                            ParseVariale(arrvector);
                        }
                    }
                    return;
                case "ptr":     vector.value = ReadUInt32(); return;
                case "soft":    vector.value = ReadUInt16(); return;
                case "handle":  vector.value = ReadInt32();  return;
                case "static":
                    {
                        var len = ReadUInt32();
                        arr = arr[1].Split(new char[] { ',' }, 3);
                        for (uint i = 0; i < len; i++)
                        {
                            var index = Vectors.Count;
                            vector.children.Add(index);
                            var arrvector = new CVector()
                            {
                                index = index,
                                name = $"{vector.name}[{i}]",
                                type = arr[1],
                            };
                            Vectors.Add(arrvector);
                            ParseVariale(arrvector);
                        }
                    }
                    return;
            }

            Type myType = Type.GetType($"CR2W.Types.W3.{vector.type}");
            if (myType != null)
            {
                if (myType.IsEnum)
                {
                    vector.value = ReadEnumerator(myType);
                    return;
                }
            }

            ReadVariable(vector);
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
        /*  - Format Info
         *  
         *  DateTime is stored as a 64 bit number with a structure as follows:
         *  
         *  0000001101101111010111001001011001111101101000000110010000000000
         *  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
         *  |        ||    ||    ||        ||         ||    ||   ||________|__ Empty
         *  |        ||    ||    ||        ||         ||    ||___|____________ Day - 1
         *  |        ||    ||    ||        ||         ||____|_________________ Month - 1
         *  |        ||    ||    ||        ||_________|_______________________ Year
         *  |        ||    ||    ||________|__________________________________ Milisecond
         *  |        ||    ||____|____________________________________________ Second
         *  |        ||____|__________________________________________________ Minuite
         *  |________|________________________________________________________ Hour
         *    
         *  In this case the date would be:
         *  
         *  0000001101101111010111001001011001111101101000000110010000000000
         *  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
         *  |13      ||47  ||23  ||150     ||2010     ||0   ||25 ||0       |
         *  
         *  26/01/2010 13:47:23:150
         *
         */
        public CDateTime ReadCDateTime()
        {
            var date = ReadInt32();
            var time = ReadInt32();

            var year = date >> 20;
            var month = date >> 15 & 0x1F;
            var day = date >> 10 & 0x1F;
            var hour = time >> 22;
            var minute = time >> 16 & 0x3F;
            var second = time >> 10 & 0x3F;
            var millisecond = time & 0b11_11111111;

            return new CDateTime(new DateTime(year, month + 1, day + 1, hour, minute, second, millisecond));
        }
        public override string ReadString()
        {
            var length = ReadVLQInt32();
            if (length < 0)
            {
                return Encoding.ASCII.GetString(ReadBytes(length * -1));
            }
            return Encoding.Unicode.GetString(ReadBytes(length * 2));
        }
        public string ReadStringAnsi()
        {
            var b = ReadByte();
            var uni = (b & (1 << 7)) != 0;
            int len = b & ((1 << 7) - 1);

            if (uni)
            {
                return Encoding.Unicode.GetString(ReadBytes(len * 2));
            }
            return Encoding.ASCII.GetString(ReadBytes(len));
        }
        public CName ReadCName()
        {
            return new CName(names[ReadUInt16()].Value);
        }
        public CGUID ReadCGUID()
        {
            return new CGUID(ReadBytes(16));
        }
        public LocalizedString ReadLocalizedString()
        {
            return new LocalizedString()
            {
                ID = ReadUInt32(),
            };
        }
        public IdTag ReadIdTag()
        {
            return new IdTag()
            {
                Flags = ReadByte(),
                ID = ReadCGUID(),
            };
        }
        public EngineTransform ReadEngineTransform()
        {
            var e = new EngineTransform();
            var flags = ReadByte();
            if ((flags & 1) == 1)
            {
                e.PositionX = ReadSingle();
                e.PositionY = ReadSingle();
                e.PositionZ = ReadSingle();
            }
            if ((flags & 2) == 2)
            {
                e.Pitch = ReadSingle();
                e.Roll = ReadSingle();
                e.Yaw = ReadSingle();
            }
            if ((flags & 4) == 4)
            {
                e.ScaleX = ReadSingle();
                e.ScaleY = ReadSingle();
                e.ScaleZ = ReadSingle();
            }
            return e;
        }
        public EngineQsTransform ReadEngineQsTransform()
        {
            var e = new EngineQsTransform();
            var flags = ReadByte();
            if ((flags & 1) == 1)
            {
                e.PositionX = ReadSingle();
                e.PositionY = ReadSingle();
                e.PositionZ = ReadSingle();
            }
            if ((flags & 2) == 2)
            {
                e.Pitch = ReadSingle();
                e.Roll = ReadSingle();
                e.Yaw = ReadSingle();
                e.RotW = ReadSingle();
            }
            if ((flags & 4) == 4)
            {
                e.ScaleX = ReadSingle();
                e.ScaleY = ReadSingle();
                e.ScaleZ = ReadSingle();
            }
            return e;
        }
        public TagList ReadTagList()
        {
            var size = ReadByte();
            var list = new TagList()
            {
                tags = new string[size],
            };
            for (var i = 0; i < size; i++)
            {
                list.tags[i] = names[ReadUInt16()].Value;
            }
            return list;
        }
        public EntityHandle ReadEntityHandle()
        {
            var handletype = ReadByte();

            if (handletype == 1)
            {
                return new EntityHandle()
                {
                    HandleType = handletype,
                    Value = new CGUID(ReadBytes(16)),
                    Unknown = ReadBytes(16),
                };
            }
            else if (handletype == 2)
            {
                return new EntityHandle()
                {
                    HandleType = handletype,
                    TagType = ReadByte(),
                    Value = new CGUID(ReadBytes(16)),
                };
            }
            return new EntityHandle()
            {
                HandleType = handletype
            };
        }
        public SharedDataBuffer ReadSharedDataBuffer()
        {
            var size = ReadInt32();
            return new SharedDataBuffer()
            {
                data = ReadBytes(size),
            };
        }
        public DataBuffer ReadDataBuffer()
        {
            var size = ReadInt32();
            return new DataBuffer()
            {
                data = ReadBytes(size),
            };
        }
        public DeferredDataBuffer ReadDeferredDataBuffer()
        {
            return new DeferredDataBuffer()
            {
                value = ReadUInt16()
            };
        }
        public object ReadEnumerator(Type enumType)
        {
            if (enumType.IsDefined(typeof(FlagsAttribute), false))
            {
                var flags = new List<string>();
                while (true)
                {
                    var id = ReadUInt16();
                    if (id == 0)
                    {
                        break;
                    }
                    flags.Add(names[id].Value);
                }
                if (flags.Any())
                {
                    return Enum.Parse(enumType, String.Join(",", flags));
                }
                return null;
            }
            else
            {
                var id = ReadUInt16();
                return Enum.Parse(enumType, names[id].Value);
            }
        }
        #endregion

        #region Cleaning Up
        protected override void Dispose(bool disposing)
        {
            strings = null;
            names = null;
            resources = null;
            objects = null;
            buffers = null;
            embedded = null;
            base.Dispose(disposing);
        }
        #endregion
    }
}