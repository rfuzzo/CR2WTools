using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CR2W.Exceptions;
using CR2W.Types;
using CR2W.CRC32;


/*
 *      TEST PARSER
 *      This is just a test parser purley for experimentation
 *      Some parts are broken, and other parts are not written the best.
 * 
 *      Not to be used for any 'proper' use.
 *      Proper parser is in CR2W.IO
 */


namespace CR2W.Testing
{
    public struct SHeader
    {
        public uint Offset;
        public uint Size;
        public uint CRC32;
    }

    public struct SReference
    {
        public uint Offset;
        public uint CRC32;
        public string Value;
    }

    public struct SHandle
    {
        public uint Offset;
        public string Type;
        public ushort Flags;
        public string Path;
    }

    public struct SChunk
    {
        public uint TypeID;
        public uint Flags;
        public uint ParentID;
        public uint Size;
        public uint Offset;
        public uint Unknown4;
        public uint CRC32;
    }

    public struct SBlock6Item
    {
        public uint Unknown1;
        public uint ID;
        public uint Unknown3;
        public uint Unknown4;
        public uint Unknown5;
        public uint CRC32;
    }

    public struct SEmbedded
    {
        public uint Unknown1;
        public string Path;
        public uint Unknown3;
        public uint Unknown4;
        public CR2WFile File;
        public byte[] Fallback;
    }

    public class CR2WFile
    {
        public uint FileVersion { get; set; }
        public uint Unknown2 { get; set; }
        public uint Date { get; set; }
        public uint Time { get; set; }
        public uint Unknown5 { get; set; }
        public uint CR2WSize { get; set; }
        public uint BufferSize { get; set; }
        public uint CRC32 { get; set; }
        public uint Unknown9 { get; set; }

        public List<CR2WChunk> Chunks;
        public List<SEmbedded> EmbeddedFiles;
    }

    public class CR2WChunk
    {
        public CR2WFile Owner { get; private set; }

        public string Type { get; set; }
        public ushort Flags { get; set; }
        public uint ParentID { get; set; }
        public uint Size { get; set; }
        public uint Offset { get; set; }
        public uint Unknown4 { get; set; }
        public uint CRC32 { get; set; }

        public byte[] Data { get; set; }
    }

    public sealed class TestParser
    {
        public static string Path { get; set; }


        public static CR2WFile New( string path )
        {
            Path = path;
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"The file: '{path}' cannot be found.");
            }
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    return New(reader);
                }
            }
        }

        public static CR2WFile New( byte[] arr )
        {
            using (MemoryStream mem = new MemoryStream(arr))
            {
                using (BinaryReader br = new BinaryReader(mem))
                {
                    return New(br);
                }
            }
        }

        public static CR2WFile New(BinaryReader file)
        {
            var p = new TestParser();
            p.Read(file);
            return p.GetParsedFile();
        }

        CR2WFile cr2w;

        CR2WFile GetParsedFile()
        {
            return cr2w;
        }

        readonly byte[] Magic = { 67, 82, 50, 87 };

        void Read(BinaryReader br)
        {
            if (!Magic.SequenceEqual(br.ReadBytes(4)))
            {
                throw new InvalidCR2WFileException("Not a CR2W file");
            }

            cr2w = new CR2WFile
            {
                FileVersion = br.ReadUInt32(),
                Unknown2 = br.ReadUInt32(),
                Date = br.ReadUInt32(),
                Time = br.ReadUInt32(),
                Unknown5 = br.ReadUInt32(),
                CR2WSize = br.ReadUInt32(),
                BufferSize = br.ReadUInt32(),
                CRC32 = br.ReadUInt32(),
                Unknown9 = br.ReadUInt32()
            };

            Console.WriteLine("FileVersion  {0}", cr2w.FileVersion);
            Console.WriteLine("Unknown2     {0}", cr2w.Unknown2);
            Console.WriteLine("Date         {0}", cr2w.Date);
            Console.WriteLine("Time         {0}", cr2w.Time);
            Console.WriteLine("Unknown5     {0}", cr2w.Unknown5);
            Console.WriteLine("CR2WSize     {0}", cr2w.CR2WSize);
            Console.WriteLine("BufferSize   {0}", cr2w.BufferSize);
            Console.WriteLine("CRC32        {0}", cr2w.CRC32);
            Console.WriteLine("Unknown9     {0}", cr2w.Unknown9);

            /* - Only used for dubugging
            */

            GetHeaders(br);
            GetTable(br);
            GetReferences(br);
            GetHandles(br);
            GetChunks(br);
            ReadBlock6(br);
            ReadEmbedded(br);
        }

        SHeader[] headers;
        void GetHeaders(BinaryReader br)
        {
            headers = new SHeader[10];
            for (int i = 0; i < 10; i++)
            {
                headers[i] = new SHeader()
                {
                    Offset = br.ReadUInt32(),
                    Size = br.ReadUInt32(),
                    CRC32 = br.ReadUInt32(),
                };
            }

            Console.WriteLine("\n");
            Console.WriteLine("\tHeaders");
            Console.WriteLine("\n");
            Console.WriteLine("|ID |Offset    |Size      |CRC32");
            Console.WriteLine("|---|----------|----------|----------");
            for (int i = 0; i < headers.Length; i++)
            {
                var h = headers[i];
                Console.WriteLine("|{0}|{1}|{2}|{3}", Convert.ToString(i + 1).PadRight(3), Convert.ToString(h.Offset).PadRight(10), Convert.ToString(h.Size).PadRight(10), h.CRC32);
            }
            /* - Only used for dubugging
            */
        }

        //Block 1 - Table
        public Dictionary<uint, string> dictionary;
        void GetTable(BinaryReader br)
        {
            dictionary = new Dictionary<uint, string>();

            var start = headers[0].Offset;
            var size = headers[0].Size;

            br.BaseStream.Seek(start, SeekOrigin.Begin);

            StringBuilder sb = new StringBuilder();

            uint offset = 0;
            for (uint i = 1; i <= size; i++)
            {
                byte b = br.ReadByte();
                if (b == 0)
                {
                    dictionary.Add(offset, sb.ToString());
                    sb.Clear();
                    offset = i;
                }
                else
                {
                    sb.Append((char)b);
                }
            }

            if(dictionary.ContainsValue("CPhysicalCollision"))
            {
                Console.WriteLine(Path);
            }

            Console.WriteLine("\n");
            Console.WriteLine("\tBlock  1");
            Console.WriteLine("\tSize   {0}", size);
            Console.WriteLine("\tOffset {0}", start);
            Console.WriteLine("\n");

            var j = 0;
            Console.WriteLine("|Index     |Offset    |Value");
            Console.WriteLine("|----------|----------|---------------------------------------");
            foreach (KeyValuePair<uint, string> entry in dictionary)
            {
                Console.WriteLine("|{0}|{1}|{2}", Convert.ToString(j).PadRight(10), Convert.ToString(entry.Key).PadRight(10), entry.Value);
                j += 1;
            }
            /* - Only used for dubugging
            */
        }

        //Block 2 - References
        public List<SReference> references;
        void GetReferences(BinaryReader br)
        {
            references = new List<SReference>();

            var start = headers[1].Offset;
            var size = headers[1].Size;

            br.BaseStream.Seek(start, SeekOrigin.Begin);

            for (int i = 0; i < size; i++)
            {
                var o = br.ReadUInt32();
                var c = br.ReadUInt32();
                var v = dictionary[o];

                references.Add(new SReference()
                {
                    Offset = o,
                    CRC32 = c,
                    Value = v,
                });
            }

            Console.WriteLine("\n");
            Console.WriteLine("\tBlock  2");
            Console.WriteLine("\tSize   {0}", size);
            Console.WriteLine("\tOffset {0}", start);
            Console.WriteLine("\n");

            Console.WriteLine("|Offset    |CRC32          |Value");
            Console.WriteLine("|----------|---------------|---------------------------");
            foreach (var r in references)
            {
                Console.WriteLine("|{0}|{1}|{2}", Convert.ToString(r.Offset).PadRight(10), Convert.ToString(r.CRC32).PadRight(15), r.Value);
            }
            /* - Only used for dubugging
            */
        }

        //Block 3 - Handles
        public List<SHandle> handles;
        void GetHandles(BinaryReader br)
        {
            handles = new List<SHandle>();

            var start = headers[2].Offset;
            var size = headers[2].Size;

            br.BaseStream.Seek(start, SeekOrigin.Begin);

            for (int i = 0; i < size; i++)
            {
                var o = br.ReadUInt32();
                var t = br.ReadUInt16();
                var f = br.ReadUInt16();

                handles.Add(new SHandle()
                {
                    Offset = o,
                    Type = references[t].Value,
                    Flags = f,
                    Path = dictionary[o],
                });
            }

            Console.WriteLine("\n");
            Console.WriteLine("\tBlock  3");
            Console.WriteLine("\tSize   {0}", size);
            Console.WriteLine("\tOffset {0}", start);
            Console.WriteLine("\n");

            Console.WriteLine("|Type                |Path                                                             |Flags");
            Console.WriteLine("|--------------------|-----------------------------------------------------------------|--------");
            foreach (var h in handles)
            {
                Console.WriteLine("|{0}|{1}|{2}", h.Type.PadRight(20), h.Path.PadRight(65), h.Flags);
            }
            /* - Only used for dubugging
            */
        }

        //Block 5 - Chunks
        List<CR2WChunk> chunks;
        List<SChunk> schunks;
        void GetChunks(BinaryReader br)
        {
            chunks = new List<CR2WChunk>();
            schunks = new List<SChunk>();

            var start = headers[4].Offset;
            var size = headers[4].Size;

            br.BaseStream.Seek(start, SeekOrigin.Begin);

            Console.WriteLine("\n");
            Console.WriteLine("\tBlock  5");
            Console.WriteLine("\tSize   {0}", size);
            Console.WriteLine("\tOffset {0}", start);
            Console.WriteLine("\n");
            /* - Only used for dubugging
            */

            for (int i = 0; i < size; i++)
            {
                ReadSingleChunk(br);
            }

            for (int i = 0; i < size; i++)
            {
                ParseSingleChunk(schunks[i], br, i);
            }
        }

        //Block 6 - Unknown
        List<SBlock6Item> block6;
        static List<uint> prev = new List<uint>();
        void ReadBlock6(BinaryReader br)
        {
            block6 = new List<SBlock6Item>();

            var start = headers[5].Offset;
            var size = headers[5].Size;

            br.BaseStream.Seek(start, SeekOrigin.Begin);

            br.BaseStream.Seek(start, SeekOrigin.Begin);
            Console.WriteLine("\n");
            Console.WriteLine("\tBlock 6");
            Console.WriteLine("\tSize {0}", size);
            Console.WriteLine("\n");
            /* - Only used for dubugging
            */

            for (int i = 0; i < size; i++)
            {
                block6.Add(new SBlock6Item()
                {
                    Unknown1 = br.ReadUInt32(),
                    ID = br.ReadUInt32(),
                    Unknown3 = br.ReadUInt32(),
                    Unknown4 = br.ReadUInt32(),
                    Unknown5 = br.ReadUInt32(),
                    CRC32 = br.ReadUInt32()
                });
            }


            Console.WriteLine("|Unknown1       |ID   |Unknown3       |Unknown4       |Unknown5       |CRC32");
            Console.WriteLine("|---------------|-----|---------------|---------------|---------------|---------------");
            foreach (var b in block6)
            {
                Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|{5}", Convert.ToString(b.Unknown1).PadRight(15),
                                                  Convert.ToString(b.ID).PadRight(5),
                                                  Convert.ToString(b.Unknown3).PadRight(15),
                                                  Convert.ToString(b.Unknown4).PadRight(15),
                                                  Convert.ToString(b.Unknown5).PadRight(15),
                                                  b.CRC32);
            }

            /* - Only used for dubugging
            */
        }

        //Block 7 - Embedded Files
        List<SEmbedded> embeddedfiles;
        void ReadEmbedded(BinaryReader br)
        {
            embeddedfiles = new List<SEmbedded>();

            var start = headers[6].Offset;
            var size = headers[6].Size;

            br.BaseStream.Seek(start, SeekOrigin.Begin);

            Console.WriteLine("\n");
            Console.WriteLine("\tBlock 7");
            Console.WriteLine("\tSize {0}", size);
            Console.WriteLine("\n");
            /* - Only used for dubugging
            */

            for (int i = 0; i < size; i++)
            {
                ReadSingleEmbeddedFile(br);
            }
        }

        void ReadSingleChunk( BinaryReader br )
        {
            var typedid = br.ReadUInt16();
            schunks.Add(new SChunk()
            {
                TypeID      = typedid,
                Flags       = br.ReadUInt16(),
                ParentID    = br.ReadUInt32(),
                Size        = br.ReadUInt32(),
                Offset      = br.ReadUInt32(),
                Unknown4    = br.ReadUInt32(),
                CRC32       = br.ReadUInt32(),
            });
        }

        void ParseSingleChunk(SChunk sc, BinaryReader br, int id)
        {
            //Console.WriteLine("Chunk Item {0}:", id);

            var TypeID = sc.TypeID;
            var Flags = sc.Flags;
            var ParentID = sc.ParentID;
            var Size = sc.Size;
            var Offset = sc.Offset;
            var Unknown4 = sc.Unknown4;
            var CRC32 = sc.CRC32;

            Console.WriteLine("TypeID   {0} - {1}", TypeID, references[(int)TypeID].Value);
            Console.WriteLine("Flags    {0}", Flags);
            Console.WriteLine("ParentID {0}", ParentID);
            Console.WriteLine("Size     {0}", Size);
            Console.WriteLine("Offset   {0}", Offset);
            Console.WriteLine("Unknown4 {0}", Unknown4);
            Console.WriteLine("CRC32    {0}", CRC32);

            br.BaseStream.Seek(Convert.ToInt32(Offset), SeekOrigin.Begin);

            var varType = references[Convert.ToInt32(TypeID)].Value;

            var end = br.BaseStream.Position + Size;
            Console.WriteLine("Data");
            Console.WriteLine("{");
            ReadVariable(br, "\t");
            Console.WriteLine("}");

            if(end - br.BaseStream.Position != 0)
            {
                var unknown = br.ReadBytes(Convert.ToInt32(end - br.BaseStream.Position));
                Console.WriteLine("Unknown Bytes: {0}", unknown.Length);
            }
            else
            {
                Console.WriteLine("Unknown Bytes: 0");
            }
            Console.WriteLine();
        }

        private void ReadVariable( BinaryReader br, string offset )
        {
            br.ReadByte();
            while(true)
            {
                var nameId = br.ReadInt16();
                if(nameId == 0)
                {
                    break;
                }
                var typeId = br.ReadInt16();
                var size = br.ReadInt32() - 4;
                Console.Write("{0}{1} {2}", offset, references[nameId].Value, references[typeId].Value);
                ParseVariale(br, references[typeId].Value, size, $"\t{offset}");
            }
        }

        private void ParseVariale( BinaryReader br, string type, int size, string offset )
        {
            var arr = type.Split(new char[] { ':' }, 2);
            switch(arr[0])
            {
                case "Uint8":
                    Console.WriteLine(" {0}", br.ReadByte());
                    return;
                case "Uint16":
                    Console.WriteLine(" {0}", br.ReadUInt16());
                    return;
                case "Uint32":
                    Console.WriteLine(" {0}", br.ReadUInt32());
                    return;
                case "Uint64":
                    Console.WriteLine(" {0}", br.ReadUInt64());
                    return;
                case "Int8":
                    Console.WriteLine(" {0}", br.ReadSByte());
                    return;
                case "Int16":
                    Console.WriteLine(" {0}", br.ReadInt16());
                    return;
                case "Int32":
                    Console.WriteLine(" {0}", br.ReadInt32());
                    return;
                case "Int64":
                    Console.WriteLine(" {0}", br.ReadInt64());
                    return;
                case "Float":
                    Console.WriteLine(" {0}", br.ReadSingle());
                    return;
                case "Double":
                    Console.WriteLine(" {0}", br.ReadDouble());
                    return;
                case "String":
                    Console.WriteLine(" {0}", br.ReadCR2WStringSingle());
                    return;
                case "StringAnsi":
                    Console.WriteLine(" {0}", br.ReadStringAnsi());
                    return;
                case "Bool":
                    Console.WriteLine(" {0}", br.ReadBoolean());
                    return;
                case "CName":
                    Console.WriteLine(" {0}", references[br.ReadUInt16()].Value);
                    return;
                case "CGUID":
                    Console.WriteLine(" {0}", br.ReadGuid());
                    return;
                case "LocalizedString":
                    Console.WriteLine(" {0}", br.ReadUInt32());
                    return;
                case "ptr":
                    Console.WriteLine(" Chunk {0}", br.ReadUInt32());
                    return;
                case "soft":
                    var Id = br.ReadUInt16();
                    Console.WriteLine(" {0} {1} ({2})", handles[Id-1].Type, handles[Id-1].Path, handles[Id-1].Flags);
                    return;
                case "array":
                    var len = br.ReadUInt32();
                    arr = arr[1].Split(new char[] { ',' }, 3);
                    Console.WriteLine(" {0}", len);
                    Console.WriteLine("{0}{{", offset.Substring(1));
                    for (uint i = 0; i < len; i++)
                    {
                        Console.Write("{0}Id {1}:", offset, i);
                        ParseVariale(br, arr[2], size, $"\t{offset}");
                    }
                    Console.WriteLine("{0}}}", offset.Substring(1));
                    return;
                case "handle":
                    Console.WriteLine(" Chunk {0}", br.ReadInt32());
                    return;
                case "static":
                case "IdTag": 
                case "DeferredDataBuffer":
                case "SharedDataBuffer":
                case "EntityHandle":
                case "EngineTransform":
                case "TagList":
                case "CClipMapCookedData":
                case "DataBuffer":
                    Console.WriteLine("{0}{1} bytes", offset, size);
                    br.ReadBytes(size);
                    return;
            }
            Type myType = Type.GetType($"CR2W.Types.W3.{type}");
            if (myType != null)
            {
                if (myType.IsEnum)
                {
                    Console.WriteLine( " {0}", references[br.ReadUInt16()].Value );
                    return;
                }
            }
            Console.WriteLine();
            Console.WriteLine("{0}{{", offset.Substring(1));
            ReadVariable(br, offset);
            Console.WriteLine("{0}}}", offset.Substring(1));
        }

        //Obsolete / Old
        /*
        void ReadVariable(BinaryReader br, string type, string offset )
        {
            if(IsBaseType(type, br, out var value, offset))
            {
                Console.WriteLine("{0}Value: {1}", offset, value );
                return;
            }
            br.ReadByte();
            while ( br.BaseStream.Position < br.BaseStream.Length )
            {
                var nameId = br.ReadUInt16();
                if (nameId == 0)
                {
                    Console.WriteLine("{0}Unknown Bytes: {1}", offset, br.BaseStream.Length - br.BaseStream.Position);
                    return;
                }
                var typeId = br.ReadUInt16();
                var size = br.ReadUInt32()-4;

                var nameStr = references[nameId].Value;
                var typeStr = references[typeId].Value;

                Console.WriteLine("{0}{1} {2} {3}", offset, nameStr, typeStr, size);
                Console.WriteLine("{0}{{", offset );
                var varBytes = br.ReadBytes(Convert.ToInt32(size));
                using (var mem = new MemoryStream(varBytes))
                {
                    using (var varBr = new BinaryReader(mem))
                    {
                        ReadVariable(varBr, typeStr, $"\t{offset}" );
                    }
                }
                Console.WriteLine("{0}}}", offset);
            }
        }

        bool IsBaseType( string type, BinaryReader br, out string value, string offset )
        {
            var arr = type.Split(new char[] { ':', ',' }, 4);
            switch (arr[0])
            {
                case "Bool":
                    value = Convert.ToString( br.ReadByte() != 0 );
                    return true;
                case "Uint8":
                    value = Convert.ToString(br.ReadByte());
                    return true;
                case "Uint16":
                    value = Convert.ToString(br.ReadUInt16());
                    return true;
                case "Uint32":
                    value = Convert.ToString(br.ReadUInt32());
                    return true;
                case "Uint64":
                    value = Convert.ToString(br.ReadUInt64());
                    return true;
                case "Int8":
                    value = Convert.ToString(br.ReadSByte());
                    return true;
                case "Int16":
                    value = Convert.ToString(br.ReadInt16());
                    return true;
                case "Int32":
                    value = Convert.ToString(br.ReadInt32());
                    return true;
                case "Int64":
                    value = Convert.ToString(br.ReadInt64());
                    return true;
                case "String":
                    List<string> list = new List<string>();
                    while (br.BaseStream.Position < br.BaseStream.Length)
                    {
                        list.Add(br.ReadCR2WStringSingle());
                    }
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine("{0}Index: {1}", offset, i);
                        Console.WriteLine("{0}{{", offset);
                        Console.WriteLine("\t{0}Value: {1}", offset, list[i]);
                        Console.WriteLine("{0}}}", offset);
                    }
                    value = Convert.ToString(list.Count);
                    return true;
                case "CName":
                    value = references[br.ReadUInt16()].Value;
                    return true;
                case "Float":
                    value = Convert.ToString(br.ReadSingle());
                    return true;
                case "Double":
                    value = Convert.ToString(br.ReadDouble());
                    return true;
                case "CGUID":
                    value = new Guid(br.ReadBytes(16)).ToString();
                    return true;
                case "LocalizedString":
                    value = Convert.ToString(br.ReadUInt32());
                    return true;
                case "array":
                    var length = br.ReadUInt32();
                    for (int i = 0; i < length; i++)
                    {
                        Console.WriteLine("{0}Index: {1}", offset, i);
                        Console.WriteLine("{0}{{", offset);
                        ReadVariable(br, arr[3], $"\t{offset}");
                        Console.WriteLine("{0}}}", offset);
                    }
                    value = Convert.ToString(length);
                    return true;
                case "soft":
                    var id = br.ReadUInt16()-1;
                    value = String.Format( "{0} - {1}: {2} ({3})", id, handles[id].Type, handles[id].Path, handles[id].Flags );
                    return true;
                case "StringAnsi":
                    int lenn = br.ReadSByte();
                    if (lenn < 0)
                    {
                        lenn += 128;
                        lenn *= 2;
                        value = Encoding.Unicode.GetString(br.ReadBytes(lenn));
                    }
                    else
                    {
                        value = Encoding.Default.GetString(br.ReadBytes(lenn));
                    }
                    return true;
                case "IdTag":
                    value = Encoding.Default.GetString(br.ReadBytes(Convert.ToInt32(br.BaseStream.Length - br.BaseStream.Position)));
                    return true;
                case "handle":
                    value = $"Chunk Index: {Convert.ToString(br.ReadUInt32())}";
                    return true;
                case "ptr":
                    value = $"Chunk Index: {Convert.ToString(br.ReadUInt32())}";
                    return true;
                case "DeferredDataBuffer":
                case "SharedDataBuffer":
                case "EntityHandle":
                case "EngineTransform":
                case "TagList":
                case "CClipMapCookedData":
                case "DataBuffer":
                case "static":
                    value = type;
                    return true;
            }
            Type myType = Type.GetType($"CR2W.Types.W3.{type}");
            if(myType == null)
            {
                value = null;
                return false;
            }
            if(myType.IsEnum)
            {
                value = references[br.ReadUInt16()].Value;
                return true;
            }
            value = null;
            return false;
        }
        */
        //Obsolete / Old


        //Read a single embedded file from an item in block 7
        //Should only be called by ReadEmbedded().
        //The position of the reader should be at the start
        //of of any of the embedded files in block 7;
        void ReadSingleEmbeddedFile( BinaryReader br )
        {
            var u1          = br.ReadUInt32();
            var path        = br.ReadUInt32();
            var u3          = br.ReadUInt32();
            var u4          = br.ReadUInt32();
            var offset      = br.ReadUInt32();
            var len         = br.ReadUInt32();

            Console.WriteLine("Block 7 Item:");
            Console.WriteLine("\tu1     {0}", u1);
            Console.WriteLine("\tpath   {0}", path);
            Console.WriteLine("\tu3     {0}", u3);
            Console.WriteLine("\tu4     {0}", u4);
            Console.WriteLine("\toffset {0}", offset);
            Console.WriteLine("\tlen    {0}", len);
            /* - Only used for dubugging
            */
            var pos = br.BaseStream.Position;

            SEmbedded embedded = new SEmbedded
            {
                Unknown1    = u1,
                Path        = dictionary[path],
                Unknown3    = u3,
                Unknown4    = u4
            };

            byte[] embeddedBytes;
            br.BaseStream.Seek(offset, SeekOrigin.Begin);
            embeddedBytes = br.ReadBytes(Convert.ToInt32(len));
            //Console.WriteLine(Crc32Algorithm.Compute(embeddedBytes));

            try
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine("------------------------");
                Console.WriteLine("Embedded File");
                Console.WriteLine("------------------------");
                Console.ReadKey();
                /* - Only used for dubugging
                */
                embedded.File = TestParser.New(embeddedBytes);
            }
            catch(InvalidCR2WFileException)
            {
                embedded.Fallback = embeddedBytes;
            }
            
            embeddedfiles.Add(embedded);
            br.BaseStream.Seek(pos,SeekOrigin.Begin);
        }
    }
}
