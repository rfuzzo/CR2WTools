using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CR2W.Types;
using CR2W.CRC32;
using CR2W.Types.W3;
using System.Xml;
using System.Reflection;

namespace CR2W.IO
{
    public sealed class CR2WBinaryReader : BinaryReader, IFile
    {
        #region Constructors

        public CR2WBinaryReader(string filePath, bool ignoreCrc = false) 
            : base(new FileStream(filePath, FileMode.Open, FileAccess.Read), Encoding.ASCII, false)
        {
            IgnoreCRC = ignoreCrc;
            FilePath = filePath;
            ReadAll();
        }

        public CR2WBinaryReader(byte[] rawbytes, bool ignoreCrc = false)
           : base( new MemoryStream(rawbytes), Encoding.ASCII, false )
        {
            IgnoreCRC = ignoreCrc;
            ReadAll();
        }

        #endregion

        #region Properties & Veriables

        //Ignore CRC32 checksums
        public bool IgnoreCRC { get; private set; } = false;

        //File path of the CR2W file
        public string FilePath { get; private set; } = "";

        //Magic Identifier 'CR2W' in uint.
        private readonly uint Magic = 0x57325243;

        //Table Item Sizes
        private readonly byte[] TableSize = { 1, 8, 8, 16, 24, 24, 24, 0, 0, 0 };

        //Basic file details.
        public uint Flags;
        public CDateTime TimeStamp;
        public uint BuildVersion;
        public uint CR2WSize;
        public uint BufferSize;
        public uint CRC32;
        public uint NumChunks;

        //Tables
        public STableHeader[]           headers;
        public Dictionary<uint, string> strings;
        public string[]                 names;
        public SResource[]              resources;
        public SObject[]                sobjs;
        public SBuffer[]                buffers;
        public SEmbedded[]              embedded;

        public CObject[]                objects;

        #endregion

        #region Headers

        /// <summary>
        /// Read the whole file
        /// </summary>
        public void ReadAll()
        {
            BaseStream.Seek(0, SeekOrigin.Begin);

            if (ReadUInt32() != Magic)
            {
                throw new InvalidCR2WFileException("Not a CR2W file - Missing 'CR2W' magic header.");
            }

            var version = ReadUInt32();

            if( !(version == 162 || version == 163) )
            {
                //throw new InvalidCR2WFileException($"This reader only supports CR2W versions 162 and 163. File version was read as {version}.");
            }

            //Base data.
            Flags        = ReadUInt32();
            TimeStamp    = ReadCDateTime();
            BuildVersion = ReadUInt32();
            CR2WSize     = ReadUInt32();
            BufferSize   = ReadUInt32();
            CRC32        = ReadUInt32();
            NumChunks    = ReadUInt32();

            //Headers.
            ReadTableHeaders();
            
            //Tables.
            ReadStrings();
            ReadNames();
            ReadResources();
            ReadObjects();
            ReadBuffers();
            ReadEmbedded();
        }

        /// <summary>
        /// Read the 10 Table Headers
        /// </summary>
        private void ReadTableHeaders()
        {
            headers = new STableHeader[10];
            for (int i = 0; i < 10; i++)
            {
                headers[i] = new STableHeader()
                {
                    offset = ReadUInt32(),
                    size   = ReadUInt32(),
                    crc32  = ReadUInt32(),
                };
            }
        }

        #endregion

        #region Table Reading
        /* - Info
         *      Region for methods dedicated to reading the tables in the file
         *      Table 1  - Strings
         *      Table 2  - Names
         *      Table 3  - Resources
         *      Table 4  - Nothing
         *      Table 5  - Objects
         *      Table 6  - Buffers
         *      Table 7  - Embedded Files
         *      Table 8  - Not used in this version
         *      Table 9  - Not used in this version
         *      Table 10 - Not used in this version
         */
        
        /// <summary>
        /// Table 1 - Strings
        /// </summary>
        private void ReadStrings()
        {
            var start = headers[0].offset;
            var size = headers[0].size;
            var crc = headers[0].crc32;

            if(!IgnoreCRC)
            {
                BaseStream.Seek(start, SeekOrigin.Begin);
                if (Crc32Algorithm.Compute(ReadBytes(Convert.ToInt32(size))) != crc)
                {
                    throw new MismatchCRC32Exception("CRC32 Checksum failed for Table 1 - Strings");
                }
            }

            strings = new Dictionary<uint, string>();
            StringBuilder sb = new StringBuilder();
            BaseStream.Seek(start, SeekOrigin.Begin);
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
        }

        /// <summary>
        /// Table 2 - Names
        /// </summary>
        private void ReadNames()
        {
            var start = headers[1].offset;
            var size = headers[1].size;
            var crc = headers[1].crc32;

            if (!IgnoreCRC)
            {
                BaseStream.Seek(start, SeekOrigin.Begin);
                if (Crc32Algorithm.Compute(ReadBytes(Convert.ToInt32(size)*8)) != crc)
                {
                    throw new MismatchCRC32Exception( "CRC32 Checksum failed for Table 2 - Names" );
                }
            }

            names = new string[size];
            BaseStream.Seek(start, SeekOrigin.Begin);
            for (int i = 0; i < size; i++)
            {
                var o = ReadUInt32();
                var u = ReadUInt32();
                names[i] = strings[o];
            }
        }

        /// <summary>
        /// Table 3 - Resources
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
                    throw new MismatchCRC32Exception("CRC32 Checksum failed for Table 3 - Resources");
                }
            }
            resources = new SResource[size];
            BaseStream.Seek(start, SeekOrigin.Begin);
            for (int i = 0; i < size; i++)
            {
                resources[i] = new SResource()
                {
                    path    = strings[ReadUInt32()],
                    type    = names[ReadUInt16()],
                    flags   = ReadUInt16(),
                };
            }
        }

        /* - Table 4
         *   This table is always of size 1 and all 
         *   data is 0 so no need to read it.
         *   Reconstructed in CR2WBinaryWriter
         *   
         *   It may be the case that the file is valid with
         *   this table empty.
         *   So: TODO - Check to see if the removal of the null
         *   data in the table will break the file.
         *   If not then no point reconstructing it later when saving
         */
        
        /// <summary>
        /// Table 5 - Objects
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
                    throw new MismatchCRC32Exception("CRC32 Checksum failed for Table 5 - CObjects");
                }
            }

            sobjs = new SObject[size];
            BaseStream.Seek(start, SeekOrigin.Begin);
            for (uint i = 0; i < size; i++)
            {
                sobjs[i] = new SObject()
                {
                    index       = i + 1,
                    typeID      = ReadUInt16(),
                    flags       = ReadUInt16(),
                    parentID    = ReadUInt32(),
                    size        = ReadUInt32(),
                    offset      = ReadUInt32(),
                    template    = ReadUInt32(),
                    crc32       = ReadUInt32(),
                };
            }
        }

        /// <summary>
        /// Table 6 - Buffers
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
                    throw new MismatchCRC32Exception("CRC32 Checksum failed for Table 6 - Buffers");
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
        /// Table 7 - Embedded
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
                    throw new MismatchCRC32Exception("CRC32 Checksum failed for Table 7 - Embedded");
                }
            }

            embedded = new SEmbedded[size];
            BaseStream.Seek(start, SeekOrigin.Begin);
            for (int i = 0; i < size; i++)
            {
                var temp = new SEmbedded()
                {
                    importIndex = ReadUInt32(),
                    path        = ReadUInt32(),
                    pathHash    = ReadUInt64(),
                    offset      = ReadUInt32(),
                    length      = ReadUInt32(),
                };

                var pos = BaseStream.Position;
                BaseStream.Seek(temp.offset, SeekOrigin.Begin);
                temp.data = ReadBytes(Convert.ToInt32(temp.length));
                embedded[i] = temp;
                BaseStream.Seek( pos, SeekOrigin.Begin );
            }
        }
        #endregion

        #region CObject Data
        /* - Info
         *      Region for creating the finished CResource
         *      from the data held in the buffers that tables 5 and 7 point to.
         *      Table 5 - List of objects that together make a Single CResource object and 
         *                all the CObjects the are referenced by it.
         *      Table 7 - List of embedded CR2W files that the main CResource can use
         *      
         *      TODO - Come up with an elegant solution to hold the emebedded files.
         *          Option 1: Parse each as a new CResource and return each one with the main as a list.
         *          Option 2: Parse each as a new CResource and store with the main one.
         *          Option 3: Do not parse but just hold as a byte array until the user needs to change stuff.
         *          Option 4: Export as a new CR2W physical file that can be later parsed.
         */

        //TO BE IMPROVED
        public CResource CreateResource()
        {
            objects = new CObject[sobjs.Length];

            for (int i = 0; i < sobjs.Length; i++)
            {
                objects[i] = CreateObject(sobjs[i]);
            }

            ;
            if(objects[0] is CResource res)
            {
                res.SetPath(FilePath);
                return res;
            }

            return null;
        }

        private CObject CreateObject(SObject obj)
        {
            var type = names[obj.typeID];
            Type resType = Type.GetType($"CR2W.Types.W3.{type}");


            if (resType == null)
            {
                throw new UnknownObjectTypeException($"{type} could not be found");
            }
           
            if (!resType.IsSubclassOf(typeof(CObject)) && !(resType == typeof(CSectorData)))
            {
                throw new InvalidOperationException($"{type} is not a CObject");
            }

            /*if (resType == typeof(CSectorData))
            {



            }
            else*/
            {
                BaseStream.Seek(obj.offset, SeekOrigin.Begin);

                CObject temp = (CObject)Activator.CreateInstance(resType);
                temp.Flags = obj.flags;
                temp.Template = obj.template;
                temp.ParentID = obj.parentID;

                if (obj.parentID > 0)
                {
                    objects[obj.parentID - 1].Children.Add(obj.index, temp);
                }

                temp.ParseBytes(this, obj.size);

                return temp;
            }
        }

        #endregion

        #region Buffer Data

        private void LoadBuffers()
        {
            for (int i = 0; i < buffers.Length; i++)
            {
                var path = $"{FilePath}.{i}.buffer";
            }
        }

        #endregion

        #region Embedded Data

        #endregion

        #region Reading Properties
        /* - Info
         *      Region for methods for reading properties.
         */
        
        /// <summary>
        /// Read a shared data buffer stream
        /// </summary>
        /// <returns>SharedDataBuffer class</returns>
        public SharedDataBuffer ReadSharedDataBuffer(uint size)
        {
            SharedDataBuffer databuffer = new SharedDataBuffer();

            //read raw bytes
            var insize = ReadUInt32();
            if (insize != 0)
            {
                var buffer = ReadBytes((int)insize);
                databuffer.data = buffer; //dbg

                //construct class
                using (var br = new CR2WBinaryReader(buffer, false))
                {
                    br.CreateResource();
                    List<CObject> toplevelObjects = br.objects?.Where(x => x.ParentID == 0).ToList();
                    databuffer.buffer = toplevelObjects;

                    //dbg
                    //List<CObject> bufferobjects = br.objects.ToList();
                    //databuffer.bufferlist = bufferobjects;
                }
            }
            
            return databuffer;
        }

        /// <summary>
        /// Read a shared data buffer stream
        /// </summary>
        /// <returns>SharedDataBuffer class</returns>
        public SStreamedAttachment ReadStreamedAttachment(uint size)
        {
            SStreamedAttachment instance = new SStreamedAttachment();
            List<string> header = new List<string>();

            //FIXME parse this as class?
            //first 0 byte
            ReadByte();
            //4 CNames 
            for (int i=0;i<4;i++)
            {
                var nameId = ReadInt16();
                var typeId = ReadInt16();
                var size2 = ReadUInt32() - 4;
                var value = ReadCName();
                header.Add(value);
            }
            instance.ParentName = header[0];
            instance.ParentClass = header[1];
            instance.ChildName = header[2];
            instance.ChildClass = header[3];
            //one byte array
            var nameId2 = ReadInt16();
            var typeId2 = ReadInt16();
            var size3 = ReadUInt32() - 4;
            
            //size again?
            var size4 = ReadUInt32();

            var bytestream = ReadBytes((int)size4);
            Array<byte> tempData = new Array<byte>();
            tempData.AddRange(bytestream);
            instance.Data = tempData;

            //var temp2 = ReadUInt16();

            //construct object
            /*
            Type resType = Type.GetType($"CR2W.Types.W3.{instance.ChildClass}");
            if (resType == null)
            {
                throw new UnknownObjectTypeException($"{instance.ChildClass} could not be found");
            }

            if (!resType.IsSubclassOf(typeof(CObject)) && !(resType == typeof(CSectorData)))
            {
                throw new InvalidOperationException($"{instance.ChildClass} is not a CObject");
            }
            CObject temp = (CObject)Activator.CreateInstance(resType);
            temp.ParseBytes(this, size3);
            instance.Child = temp;
            */

            using (var br = new CR2WBinaryReader(bytestream, false))
            {
                br.CreateResource();
                CObject child = br.objects?.First();
                instance.Child = child;
            }


            return instance;
        }

        /// <summary>
        /// Read a CPhysicalCollision struct
        /// </summary>
        /// <returns>CPhysicalCollision struct</returns>
        public CPhysicalCollision ReadPhysicalCollision(uint size)
        {
            CPhysicalCollision physicalCollision = new CPhysicalCollision();
            //dbg
            long posBegin = this.BaseStream.Position;

            //read raw bytes
            //handle parent
            uint parent = ReadUInt32();
            physicalCollision.Parent = parent;

            //array collision types
            var arsize = ReadByte();
            Array<CName> ardata = new Array<CName>();
            for (int i=0;i<arsize;i++)
            {
                ardata.Add(ReadCName());
            }
            physicalCollision.CollisionTypes = ardata;



            //b - 128
            //b - 4
            //2b - 4 name - name
            //b - 0
            //4b - -0.5
            //b - 212
            //b - 215
            //b - 32
            //b - 0
            //b - 0
            //b - 0


            long posEnd = this.BaseStream.Position;
            int bytesLeft = (int)(size - (posEnd - posBegin));
            var unknownBytes = ReadBytes(bytesLeft);
            physicalCollision.UnknownBytes = unknownBytes;

            return physicalCollision;
        }

        /// <summary>
        /// Read a 2 byte CName from the current stream
        /// </summary>
        /// <returns>CName value</returns>
        public CName ReadCName()
        {
            return new CName(names[ReadUInt16()]);
        }

        /// <summary>
        /// Read a 16 byte CGUID from the current stream.
        /// </summary>
        /// <returns>CGUID Value</returns>
        public CGUID ReadCGUID()
        {
            return new CGUID(ReadBytes(16));
        }

        /// <summary>
        /// Read a single string from the current stream, prefixed with a VQLvariable indicating the length.
        /// </summary>
        /// <returns>string value read</returns>
        public override string ReadString()
        {
            var length = ReadVLQInt32();
            if (length < 0)
            {
                return Encoding.ASCII.GetString(ReadBytes(length * -1));
            }
            return Encoding.Unicode.GetString(ReadBytes(length * 2));
        }

        /// <summary>
        /// Read a single ANSI encoded string from the current stream.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Read a 4 byte localized string key from the current stream.
        /// </summary>
        /// <returns>Localized string key</returns>
        public LocalizedString ReadLocalizedString()
        {
            return new LocalizedString
            {
                ID = ReadUInt32()
            };
        }

        /// <summary>
        /// Read an 8 byte CDateTime value from the current stream.
        /// </summary>
        /// <returns>CDatetime value</returns>
        public CDateTime ReadCDateTime()
        {
            return new CDateTime(ReadUInt64());
        }

        /// <summary>
        /// Read a single 2 byte enumarator from the current stream, or if the enumarator is a flags enumarator, read 
        /// a list of 2 byte enumarator flags from the current stream.
        /// </summary>
        /// <param name="enumType"></param>
        /// <returns></returns>
        public object ReadEnumerator( Type enumType )
        {
            if(!enumType.IsEnum)
            {
                throw new ArgumentException($"Type '{enumType.Name}' is not a enumumerator.");
            }
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
                    flags.Add(names[id]);
                }
                if(flags.Any())
                {
                    return Enum.Parse(enumType, String.Join(",", flags));
                }
                return null;
            }
            else
            {
                var id = ReadUInt16();
                return Enum.Parse(enumType, names[id]);
            }
        }

        /// <summary>
        /// Read an Engine transform object from the current stream
        /// </summary>
        /// <returns>Engine Transform value</returns>
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
                e.Roll  = ReadSingle();
                e.Yaw   = ReadSingle();
            }
            if ((flags & 4) == 4)
            {
                e.ScaleX = ReadSingle();
                e.ScaleY = ReadSingle();
                e.ScaleZ = ReadSingle();
            }
            return e;
        }

        /// <summary>
        /// Read an EngineQsTransform object from the current stream
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Read a tag list from the current stream where the first byte is the list length.
        /// </summary>
        /// <returns></returns>
        public TagList ReadTagList()
        {
            var size = ReadByte();
            var list = new TagList();
            string[] tags = new string[size];
            for (var i = 0; i < size; i++)
            {
                //ToDo - Add in the way tags are stored in a tag list.
                //       I will keep tag list as a struct and not a class.
                //var nameId = ReadUInt16();
                var nameId = ReadUInt16();
                string str = names[nameId];
                tags[i] = str;
            }
            list.tags = tags;

            return list;
        }

        /// <summary>
        /// Read a 17 byte long IdTag struct from the current stream.
        /// </summary>
        /// <returns>IdTagObject</returns>
        public IdTag ReadIdTag()
        {
            return new IdTag
            {
                Flags = ReadByte(),
                ID = ReadCGUID()
            };
        }

        /// <summary>
        /// Read an 18 byte long EntityHandle struct from the current stream.
        /// </summary>
        /// <returns>EntityHandle Struct</returns>
        public EntityHandle ReadEntityHandle()
        {
            var handletype = ReadByte();

            if(handletype == 1)
            {
                return new EntityHandle()
                {
                    HandleType = handletype,
                    Value = new CGUID(ReadBytes(16)),
                    Unknown = ReadBytes(16),
                };
            }
            else if(handletype == 2)
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

        #endregion

        #region Supporting Functions

        /// <summary>
        /// Read a variable length quantity value from the current stream where the 
        /// first byte stores 6 bits of the final value, 
        /// and remaining bytes contain 7 bits of the value.
        /// </summary>
        /// <returns>
        /// Int32 of the final value. 
        /// </returns>
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
            return sign ? size * -1 : size;
        }

        #endregion

        #region Cleaning Up

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            //Most likely will want to clear some unneeded variables and whatnot
            //Anything that isn't needed like the headers and tables 1,2,3.
            //Will not do until the data is mapped from table 5 and i can be
            //sure of what data will not be needed once that is done.
        }

        #endregion
    }
}
