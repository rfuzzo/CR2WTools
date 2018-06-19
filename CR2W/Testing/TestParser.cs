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
    public struct SName
    {
        public uint Offset;
        public uint CRC32;
        public string Value;
    }
    public struct SResource
    {
        public uint Offset;
        public string Type;
        public ushort Flags;
        public string Path;
    }
    public struct SObject
    {
        public uint TypeID;
        public uint Flags;
        public uint ParentID;
        public uint Size;
        public uint Offset;
        public uint Unknown4;
        public uint CRC32;
    }
    public struct SBuffer
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
        public uint Flags { get; set; }
        public ulong Date { get; set; }
        public uint BuildVersion { get; set; }
        public uint CR2WSize { get; set; }
        public uint BufferSize { get; set; }
        public uint CRC32 { get; set; }
        public uint NumChunks { get; set; }

        public List<CR2WObject> Chunks;
        public List<SEmbedded> EmbeddedFiles;
    }
    public class CR2WObject
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

        #region Header
        static List<string> prev = new List<string>();

        void Read(BinaryReader br)
        {
            if (!Magic.SequenceEqual(br.ReadBytes(4)))
            {
                throw new InvalidCR2WFileException("Not a CR2W file");
            }

            cr2w = new CR2WFile
            {
                FileVersion = br.ReadUInt32(),
                Flags = br.ReadUInt32(),
                Date = br.ReadUInt64(),
                BuildVersion = br.ReadUInt32(),
                CR2WSize = br.ReadUInt32(),
                BufferSize = br.ReadUInt32(),
                CRC32 = br.ReadUInt32(),
                NumChunks = br.ReadUInt32()
            };

            Console.WriteLine("File         {0}", Path);
            Console.WriteLine("FileVersion  {0}", cr2w.FileVersion);
            Console.WriteLine("Flags        {0}", cr2w.Flags);
            Console.WriteLine("Date         {0}", cr2w.Date);
            Console.WriteLine("BuildVersion {0}", cr2w.BuildVersion);
            Console.WriteLine("CR2WSize     {0}", cr2w.CR2WSize);
            Console.WriteLine("BufferSize   {0}", cr2w.BufferSize);
            Console.WriteLine("CRC32        {0}", cr2w.CRC32);
            Console.WriteLine("NumChunks    {0}", cr2w.NumChunks);

            GetHeaders(br);
            GetTable(br);
            GetNames(br);
            GetResources(br);
            GetObjects(br);
            GetBuffers(br);
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

        #endregion

        #region Blocks

        //Block 1 - Strings
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
                char c = br.ReadChar();
                if (c == 0)
                {
                    dictionary.Add(offset, sb.ToString());
                    sb.Clear();
                    offset = i;
                }
                else
                {
                    sb.Append(c);
                }
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

        //Block 2 - Names
        public List<SName> references;
        void GetNames(BinaryReader br)
        {
            references = new List<SName>();

            var start = headers[1].Offset;
            var size = headers[1].Size;

            br.BaseStream.Seek(start, SeekOrigin.Begin);

            for (int i = 0; i < size; i++)
            {
                var o = br.ReadUInt32();
                var c = br.ReadUInt32();
                var v = dictionary[o];
                references.Add(new SName()
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

        //Block 3 - Imports
        public List<SResource> handles;
        void GetResources(BinaryReader br)
        {
            handles = new List<SResource>();

            var start = headers[2].Offset;
            var size = headers[2].Size;

            br.BaseStream.Seek(start, SeekOrigin.Begin);

            for (int i = 0; i < size; i++)
            {
                var o = br.ReadUInt32();
                var t = br.ReadUInt16();
                var f = br.ReadUInt16();

                handles.Add(new SResource()
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

        //Block 5 - Objects
        List<CR2WObject> chunks;
        List<SObject> schunks;
        void GetObjects(BinaryReader br)
        {
            chunks = new List<CR2WObject>();
            schunks = new List<SObject>();

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
                ReadSingleObject(br);
            }

            for (int i = 0; i < size; i++)
            {
                ParseSingleObject(schunks[i], br, i);
            }
        }

        //Block 6 - Buffers
        List<SBuffer> block6;
        void GetBuffers(BinaryReader br)
        {
            block6 = new List<SBuffer>();

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
                block6.Add(new SBuffer()
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

        #endregion

        #region Chunks

        private void ReadSingleObject( BinaryReader br )
        {
            schunks.Add(new SObject()
            {
                TypeID      = br.ReadUInt16(),
                Flags       = br.ReadUInt16(),
                ParentID    = br.ReadUInt32(),
                Size        = br.ReadUInt32(),
                Offset      = br.ReadUInt32(),
                Unknown4    = br.ReadUInt32(),
                CRC32       = br.ReadUInt32(),
            });
        }

        private void ParseSingleObject(SObject sc, BinaryReader br, int id)
        {
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

        #endregion

        #region Variables

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
                Console.ReadKey();
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
                    Console.WriteLine(" {0}", ReadCR2WStringSingle(br));
                    return;
                case "StringAnsi":
                    Console.WriteLine(" {0}", ReadStringAnsi(br));
                    return;
                case "Bool":
                    Console.WriteLine(" {0}", br.ReadBoolean());
                    return;
                case "CName":
                    Console.WriteLine(" {0}", references[br.ReadUInt16()].Value);
                    return;
                case "CGUID":
                    Console.WriteLine(" {0}", new CGUID(br.ReadBytes(16)).ToString());
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
                case "SAppearanceAttachment":
                    Console.WriteLine();
                    Console.WriteLine("{0}{{", offset.Substring(1));
                    ReadVariable(br, offset);
                    var bytecount = br.ReadInt32();
                    br.ReadBytes(bytecount - 4);
                    Console.WriteLine("{0}Unknown Bytes: {1}", offset, bytecount - 4);
                    Console.WriteLine("{0}}}", offset.Substring(1));
                    return;
                case "IdTag":
                    Console.Write(" {0}", br.ReadByte());
                    Console.WriteLine(" - {0}", new CGUID(br.ReadBytes(16)).ToString());
                    Console.ReadKey();
                    return;
                case "EngineTransform":
                case "static":
                case "DeferredDataBuffer":
                case "SharedDataBuffer":
                case "EntityHandle":
                case "EngineQsTransform":
                case "TagList":
                case "CClipMapCookedData":
                case "DataBuffer":
                    Console.WriteLine(" {0} bytes", size);
                    br.ReadBytes(size);
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
                            var flag = br.ReadUInt16();
                            if(flag == 0)
                            {
                                break;
                            }
                            values.Add(references[flag].Value);
                        }
                        if(values.Count != 0)
                        {
                            Console.WriteLine(" {0}", Enum.Parse(myType, String.Join(",", values)));
                        }
                        else
                        {
                            Console.WriteLine(" {0}", "None");
                        }
                    }
                    else
                    {
                        Console.WriteLine(" {0}", references[br.ReadUInt16()].Value);
                    }
                    return;
                }
            }
            Console.WriteLine();
            Console.WriteLine("{0}{{", offset.Substring(1));
            ReadVariable(br, offset);
            Console.WriteLine("{0}}}", offset.Substring(1));
        }

        public static string ReadCR2WStringSingle(BinaryReader br)
        {
            var b = br.ReadByte();
            var nxt = (b & (1 << 6)) != 0;
            var utf = (b & (1 << 7)) == 0;
            int len = b & ((1 << 6) - 1);
            if (nxt)
            {
                len += 64 * br.ReadByte();
            }
            if (utf)
            {
                return Encoding.Unicode.GetString(br.ReadBytes(len * 2));
            }
            return Encoding.ASCII.GetString(br.ReadBytes(len));
        }

        public static string ReadStringAnsi(BinaryReader br)
        {
            var b = br.ReadByte();
            var nxt = (b & (1 << 7)) != 0;
            int len = b & ((1 << 7) - 1);

            if (nxt)
            {
                return Encoding.Unicode.GetString(br.ReadBytes(len * 2));
            }
            else
            {
                return Encoding.ASCII.GetString(br.ReadBytes(len));
            }
        }

        #endregion

        #region Embedded

        private void ReadSingleEmbeddedFile( BinaryReader br )
        {
            var u1          = br.ReadUInt32();
            var path        = br.ReadUInt32();
            var u3          = br.ReadUInt32();
            var u4          = br.ReadUInt32();
            var offset      = br.ReadUInt32();
            var len         = br.ReadUInt32();

            Console.WriteLine("Block 7 Item:");
            Console.WriteLine("\tu1     {0}", u1);
            Console.WriteLine("\tpath   {0} {1}", path, dictionary[path]);
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

        #endregion
    }
}
