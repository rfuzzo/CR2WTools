using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CR2W.Types;
using CR2W.CRC32;
using CR2W.Types.W3;
using CR2W.Exceptions;
using CR2W.Attributes;
using System.Xml;

namespace CR2W.IO
{
    public sealed class CR2WBinaryReader : BinaryReader
    {
        #region Constructors

        public CR2WBinaryReader( string filePath, Stream input, bool ignoreCrc = false) : base(input, Encoding.ASCII, false)
        {
            IgnoreCRC = ignoreCrc;
            FilePath = filePath;
            ReadAll();
        }

        #endregion

        #region Properties & Veriables

        //Ignore CRC32 checksums
        public bool IgnoreCRC { get; private set; } = false;

        //File path of the CR2W file
        public string FilePath { get; private set; } = "";

        //Magic Identifier 'CR2W' in byte[].
        private readonly byte[] Magic = { 67, 82, 50, 87 };

        //Resource instance.
        private CResource _resource;

        //Basic file details
        public uint Unknown2;
        public uint Date;
        public uint Time;
        public uint Unknown5;
        public uint CR2WSize;
        public uint BufferSize;
        public uint CRC32;
        public uint Unknown9;

        //File info, blocks and temp structs
        public SHeader[]                headers;
        public Dictionary<uint, string> stringtable;
        public string[]                 names;
        public SResource[]              resources;
        public SObject[]                objects;
        public SBuffer[]                buffers;
        public SEmbedded[]              embedded;

        //Get the parsed CResource file
        public CResource Resource
        {
            get
            {
                return _resource;
            }
        }

        #endregion

        #region Headers

        /// <summary>
        /// Read the whole file
        /// </summary>
        public void ReadAll()
        {
            BaseStream.Seek(0, SeekOrigin.Begin);

            if (!Magic.SequenceEqual(ReadBytes(4)))
            {
                throw new InvalidCR2WFileException("Not a CR2W file - Missing 'CR2W' magic header.");
            }

            var version = ReadUInt32();

            if( !(version == 162 || version == 163) )
            {
                throw new InvalidCR2WFileException($"This reader only supports CR2W versions 162 and 163. File version was read as {version}.");
            }

            //Base data.
            Unknown2     = ReadUInt32();
            Date         = ReadUInt32();
            Time         = ReadUInt32();
            Unknown5     = ReadUInt32();
            CR2WSize     = ReadUInt32();
            BufferSize   = ReadUInt32();
            CRC32        = ReadUInt32();
            Unknown9     = ReadUInt32();

            //Headers.
            ReadBlockHeaders();

            //Blocks.
            ReadStringTable();
            ReadNameArray();
            ReadResources();
            ReadObjects();
            ReadBuffers();
            ReadEmbedded();

            //Class Constructing
            CreateResource();
        }

        /// <summary>
        /// Read the 10 Block Headers
        /// </summary>
        /// <param name="br"></param>
        private void ReadBlockHeaders()
        {
            headers = new SHeader[10];
            for (int i = 0; i < 10; i++)
            {
                headers[i] = new SHeader()
                {
                    offset = ReadUInt32(),
                    size   = ReadUInt32(),
                    crc32  = ReadUInt32(),
                };
            }
        }

        #endregion

        #region Block Reading
        /* - Info
         *      Region for methods dedicated to reading the blocks in the file
         *      Block 1  - String Table
         *      Block 2  - Names
         *      Block 3  - Resources
         *      Block 4  - Nothing
         *      Block 5  - Objects
         *      Block 6  - Buffers
         *      Block 7  - Embedded Files
         *      Block 8  - Not used in this version
         *      Block 9  - Not used in this version
         *      Block 10 - Not used in this version
         */
        
        /// <summary>
        /// Block 1 - String Table
        /// </summary>
        private void ReadStringTable()
        {
            var start = headers[0].offset;
            var size = headers[0].size;
            var crc = headers[0].crc32;

            if(!IgnoreCRC)
            {
                BaseStream.Seek(start, SeekOrigin.Begin);
                if (Crc32Algorithm.Compute(ReadBytes(Convert.ToInt32(size))) != crc)
                {
                    throw new MismatchCRC32Exception("CRC32 Checksum failed for Block 1 - String Table");
                }
            }

            stringtable = new Dictionary<uint, string>();
            StringBuilder sb = new StringBuilder();
            BaseStream.Seek(start, SeekOrigin.Begin);
            uint offset = 0;
            for (uint i = 1; i <= size; i++)
            {
                byte b = ReadByte();
                if (b == 0)
                {
                    stringtable.Add(offset, sb.ToString());
                    sb.Clear();
                    offset = i;
                }
                else
                {
                    sb.Append((char)b);
                }
            }
        }

        /// <summary>
        /// Block 2 - Names
        /// </summary>
        private void ReadNameArray()
        {
            var start = headers[1].offset;
            var size = headers[1].size;
            var crc = headers[1].crc32;

            if (!IgnoreCRC)
            {
                BaseStream.Seek(start, SeekOrigin.Begin);
                if (Crc32Algorithm.Compute(ReadBytes(Convert.ToInt32(size)*8)) != crc)
                {
                    throw new MismatchCRC32Exception( "CRC32 Checksum failed for Block 2 - References" );
                }
            }

            names = new string[size];
            BaseStream.Seek(start, SeekOrigin.Begin);
            for (int i = 0; i < size; i++)
            {
                var o = ReadUInt32();
                var u = ReadUInt32();
                names[i] = stringtable[o];

                //'u' is currently unknown.
                //In WK and Sarcen's editor it was listed as a CRC32 checksum value
                //But that wouldn't make sense as the whole block has a valid CRC32 value in the header
                //For now i will just ignore until it's figured out.
            }
        }

        /// <summary>
        /// Block 3 - Resources
        /// </summary>
        private void ReadResources()
        {
            var start = headers[2].offset;
            var size = headers[2].size;
            var crc = headers[2].crc32;

            if (!IgnoreCRC)
            {
                BaseStream.Seek(start, SeekOrigin.Begin);
                if (Crc32Algorithm.Compute(ReadBytes(Convert.ToInt32(size)*8)) != crc)
                {
                    throw new MismatchCRC32Exception("CRC32 Checksum failed for Block 3 - Handles");
                }
            }

            resources = new SResource[size];
            BaseStream.Seek(start, SeekOrigin.Begin);
            for (int i = 0; i < size; i++)
            {
                var o = ReadUInt32();
                var t = ReadUInt16();
                var f = ReadUInt16();

                resources[i] = new SResource()
                {
                    type = names[t],
                    flags = f,
                    path = stringtable[o],
                };
            }
        }

        /* - Block 4
         *   This block is always of size 1 and all 
         *   data is null so no need to read it.
         *   Reconstructed in CR2WExporter
         *   
         *   It may be the case that the file is valid with
         *   this block empty.
         *   So: TODO - Check to see if the removal of the null
         *   data in the block will break the file.
         *   If not then no point reconstructing it later when saving
         */
        
        /// <summary>
        /// Block 5 - Objects
        /// </summary>
        private void ReadObjects()
        {
            var start = headers[4].offset;
            var size = headers[4].size;
            var crc = headers[4].crc32;

            if (!IgnoreCRC)
            {
                BaseStream.Seek(start, SeekOrigin.Begin);
                if (Crc32Algorithm.Compute(ReadBytes(Convert.ToInt32(size)*24)) != crc)
                {
                    throw new MismatchCRC32Exception("CRC32 Checksum failed for Block 5 - Chunks");
                }
            }

            objects = new SObject[size];
            BaseStream.Seek(start, SeekOrigin.Begin);
            for (int i = 0; i < size; i++)
            {
                var temp = new SObject()
                {
                    typeID = ReadUInt16(),
                    flags = ReadUInt16(),
                    parentID = ReadUInt32(),
                    size = ReadUInt32(),
                    offset = ReadUInt32(),
                    template = ReadUInt32(),
                };
                var crc32 = ReadUInt32();

                if (!IgnoreCRC)
                {
                    var pos = BaseStream.Position;
                    BaseStream.Seek(Convert.ToInt32(temp.offset), SeekOrigin.Begin);
                    if (Crc32Algorithm.Compute(ReadBytes(Convert.ToInt32(temp.size))) != crc32)
                    {
                        throw new MismatchCRC32Exception($"CRC32 checksum failed for chunk {i+1} ({names[temp.typeID]})");
                    }
                    BaseStream.Seek(pos, SeekOrigin.Begin);
                }
                objects[i] = temp;
            }
        }

        /// <summary>
        /// Block 6 - Buffers
        /// </summary>
        private void ReadBuffers()
        {
            var start = headers[5].offset;
            var size = headers[5].size;
            var crc = headers[5].crc32;

            if (!IgnoreCRC)
            {
                BaseStream.Seek(start, SeekOrigin.Begin);
                if (Crc32Algorithm.Compute(ReadBytes(Convert.ToInt32(size)*24)) != crc)
                {
                    throw new MismatchCRC32Exception("CRC32 Checksum failed for Block 6 - Buffers");
                }
            }

            buffers = new SBuffer[size];
            BaseStream.Seek(start, SeekOrigin.Begin);
            for (int i = 0; i < size; i++)
            {
                buffers[i] = new SBuffer()
                {
                    flags    = ReadUInt32(),
                    index    = ReadUInt32(),
                    offset   = ReadUInt32(),
                    diskSize = ReadUInt32(),
                    memSize  = ReadUInt32(),
                    crc32    = ReadUInt32()
                };
            }
        }

        /// <summary>
        /// Block 7 - Embedded
        /// </summary>
        private void ReadEmbedded()
        {
            var start = headers[6].offset;
            var size = headers[6].size;
            var crc = headers[6].crc32;

            if (!IgnoreCRC)
            {
                BaseStream.Seek(start, SeekOrigin.Begin);
                if (Crc32Algorithm.Compute(ReadBytes(Convert.ToInt32(size)*24)) != crc)
                {
                    throw new MismatchCRC32Exception("CRC32 Checksum failed for Block 7 - Embedded");
                }
            }

            embedded = new SEmbedded[size];
            BaseStream.Seek(start, SeekOrigin.Begin);
            for (int i = 0; i < size; i++)
            {
                var temp = new SEmbedded()
                {
                    unknown1  = ReadUInt32(),
                    path      = ReadUInt32(),
                    unknown3  = ReadUInt32(),
                    unknown4  = ReadUInt32(),
                };
                var offset    = ReadUInt32();
                var len       = ReadUInt32();

                var pos = BaseStream.Position;

                BaseStream.Seek(offset, SeekOrigin.Begin);
                temp.data = ReadBytes(Convert.ToInt32(len));
                embedded[i] = temp;

                BaseStream.Seek( pos, SeekOrigin.Begin );
            }
        }
        #endregion

        #region Resource
        /* - Info
         *      Region for creating the finished CResource
         *      from the data held in the buffers that blocks 5 and 7 point to.
         *      Block 5 - List of objects that together make a Single CResource object and 
         *                all the CObjects the are referenced by it.
         *      Block 7 - List of embedded CR2W files that the main CResource can use
         *      
         *      TODO - Come up with an elegant solution to hold the emebedded files.
         *          Option 1: Parse each as a new CResource and return each one with the main as a list.
         *          Option 2: Parse each as a new CResource and store with the main one.
         *          Option 3: Do not parse but just hold as a byte array until the user needs to change stuff.
         *          Option 4: Export as a new CR2W physical file that can be later parsed.
         */

        public void CreateResource()
        {
            var temp = objects[0];
            var type = names[temp.typeID];

            Type resType = Type.GetType($"CR2W.Types.W3.{type}");

            if (resType == null)
            {
                throw new UnknownObjectTypeException($"[UNKOWN TYPE] {type} could not be found");
            }

            if (!resType.IsSubclassOf(typeof(CResource)))
            {
                throw new InvalidOperationException($"[UNSUPPORTED TYPE] {type} is not a CResource");
            }

            BaseStream.Seek(temp.offset, SeekOrigin.Begin);

            _resource = (CResource)Activator.CreateInstance(resType);
            _resource.Flags = temp.flags;
            _resource.Template = temp.template;
            _resource.ParseBytes(this, temp.size);
        }

        #endregion

        #region Reading Variables
        /* - Info
         *      Region for methods for reading variables from data in block 5.
         *      
         */

        public CName ReadCName()
        {
            return new CName(names[ReadUInt16()]);
        }

        public CGUID ReadCGUID()
        {
            return new CGUID(ReadBytes(16));
        }

        public string ReadStringDefaultSingle()
        {
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
                return Encoding.Unicode.GetString(ReadBytes(len * 2));
            }
            return Encoding.ASCII.GetString(ReadBytes(len));
        }

        public string[] ReadStringDefaultGroup(uint size)
        {
            var strs = new List<string>();
            var start = BaseStream.Position;
            while (BaseStream.Position < start + size)
            {
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
                    strs.Add(Encoding.Unicode.GetString(ReadBytes(len * 2)));
                }
                else
                {
                    strs.Add(Encoding.ASCII.GetString(ReadBytes(len)));
                }
            }
            return strs.ToArray();
        }

        public string ReadStringAnsi()
        {
            var b = ReadByte();
            var nxt = (b & (1 << 7)) != 0;
            int len = b & ((1 << 7) - 1);

            if (nxt)
            {
                return Encoding.Unicode.GetString(ReadBytes(len * 2));
            }
            else
            {
                return Encoding.ASCII.GetString(ReadBytes(len));
            }
        }

        public LocalizedString ReadLocalizedString()
        {
            return new LocalizedString(ReadUInt32());
        }

        public XmlDocument ReadXMLDocument()
        {
            var length = ReadInt32();
            var xmlstr = Encoding.UTF8.GetString(ReadBytes(length));
            Console.WriteLine(xmlstr);
            var doc = new XmlDocument();
            doc.LoadXml(xmlstr);
            return doc;
        }
        #endregion

        #region Cleaning Up

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            //Most likely will want to clear some unneeded variables and whatnot
            //Anything that isn't needed like the headers and blocks 1,2,3.
            //Will not do until the data is mapped from block 5 and i can be
            //sure of what data will not be needed once that is done.
        }

        #endregion
    }
}
