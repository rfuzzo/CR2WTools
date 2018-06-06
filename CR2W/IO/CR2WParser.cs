using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CR2W.Exceptions;
using CR2W.Types.W3;
using CR2W.CRC32;

namespace CR2W.IO
{
    public sealed class CR2WParser
    {
        #region Initializers

        /* - Info
         *      Region for Methods to parse a new CR2W file and get the CResource
         */
        
        /// <summary>
        /// Create a new CResource from a file path. 
        /// </summary>
        /// <param name="path">Path of the CR2W file to load</param>
        /// <returns>CResource instance</returns>
        /// <exception cref="FileNotFoundException"/>
        /// <exception cref="InvalidCR2WFileException"/>
        /// <exception cref="MismatchCRC32Exception"/>
        public static CResource New(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"The file: '{path}' cannot be found.");
            }
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(stream))
                {
                    return Create(br);
                }
            }
        }

        private static CResource Create(BinaryReader br)
        {
            var p = new CR2WParser();
            p.Read(br);
            return p.Resource;
        }

        #endregion

        #region Properties & Veriables

        //Resource instance.
        private CResource _resource;

        //Magic Identifier 'CR2W' in byte[].
        readonly byte[] Magic = { 67, 82, 50, 87 };

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
        public List<string>             references;
        public List<SHandle>            handles;
        public List<SChunk>             chunks;
        public List<SBlock6Item>        block6;
        public List<SEmbedded>          embedded;

        /// <summary>
        /// Get the parsed CResource file
        /// </summary>
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
        /// <param name="br"></param>
        private void Read(BinaryReader br)
        {
            if (!Magic.SequenceEqual(br.ReadBytes(4)))
            {
                throw new InvalidCR2WFileException("Not a CR2W file - Missing 'CR2W' magic header");
            }

            var version = br.ReadUInt32();

            if( !(version == 162 || version == 163) )
            {
                throw new InvalidCR2WFileException($"This reader only supports CR2W versions 162 and 163. File version was read as {version}");
            }

            //Base data.
            Unknown2     = br.ReadUInt32();
            Date         = br.ReadUInt32();
            Time         = br.ReadUInt32();
            Unknown5     = br.ReadUInt32();
            CR2WSize     = br.ReadUInt32();
            BufferSize   = br.ReadUInt32();
            CRC32        = br.ReadUInt32();
            Unknown9     = br.ReadUInt32();

            //Headers.
            ReadBlockHeaders(br);

            //Blocks.
            ReadStringTable(br);
            ReadReferences(br);
            ReadHandles(br);
            ReadChunks(br);
            ReadBlock6(br);
            ReadEmbedded(br);

            //Resource.
            CreateResource();

            //Clear uneeded data.
            headers = null;
            stringtable = null;
        }

        /// <summary>
        /// Read the 10 Block Headers
        /// </summary>
        /// <param name="br"></param>
        private void ReadBlockHeaders(BinaryReader br)
        {
            headers = new SHeader[10];
            for (int i = 0; i < 10; i++)
            {
                headers[i] = new SHeader()
                {
                    offset = br.ReadUInt32(),
                    size   = br.ReadUInt32(),
                    crc32  = br.ReadUInt32(),
                };
            }
        }

        #endregion

        #region Block Reading
        /* - Info
         *      Region for methods dedicated to reading the blocks in the file
         *      Block 1  - NULL seperated string table
         *      Block 2  - References
         *      Block 3  - Handles
         *      Block 4  - Nothing
         *      Block 5  - Chunks
         *      Block 6  - Unknown ( Seeds? )
         *      Block 7  - Embedded Files
         *      Block 8  - Not used in this version
         *      Block 9  - Not used in this version
         *      Block 10 - Not used in this version
         */

        /// <summary>
        /// Block 1 - String Table
        /// </summary>
        /// <param name="br"></param>
        private void ReadStringTable(BinaryReader br)
        {
            var start = headers[0].offset;
            var size = headers[0].size;
            var crc = headers[0].crc32;

            br.BaseStream.Seek(start, SeekOrigin.Begin);
            if (Crc32Algorithm.Compute(br.ReadBytes(Convert.ToInt32(size))) != crc)
            {
                throw new MismatchCRC32Exception("CRC32 Checksum failed for Block 1 - String Table");
            }

            stringtable = new Dictionary<uint, string>();
            StringBuilder sb = new StringBuilder();

            br.BaseStream.Seek(start, SeekOrigin.Begin);
            uint offset = 0;
            for (uint i = 1; i <= size; i++)
            {
                byte b = br.ReadByte();
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
        /// Block 2 - References
        /// </summary>
        /// <param name="br"></param>
        private void ReadReferences(BinaryReader br)
        {
            var start = headers[1].offset;
            var size = headers[1].size;
            var crc = headers[1].crc32;

            br.BaseStream.Seek(start, SeekOrigin.Begin);
            if (Crc32Algorithm.Compute(br.ReadBytes(Convert.ToInt32(size)*8)) != crc)
            {
                throw new MismatchCRC32Exception( "CRC32 Checksum failed for Block 2 - References" );
            }

            references = new List<string>();
            br.BaseStream.Seek(start, SeekOrigin.Begin);
            for (int i = 0; i < size; i++)
            {
                var o = br.ReadUInt32();
                var u = br.ReadUInt32();
                references.Add(stringtable[o]);

                //'u' is currently unknown.
                //In WK and Sarcen's editor it was listed as a CRC32 checksum value
                //But that wouldn't make sense as the whole block has a valid CRC32 value in the header
                //For now i will just ignore until it's figured out.
            }
        }

        /// <summary>
        /// Block 3 - Handles
        /// </summary>
        /// <param name="br"></param>
        private void ReadHandles(BinaryReader br)
        {
            var start = headers[2].offset;
            var size = headers[2].size;
            var crc = headers[2].crc32;

            br.BaseStream.Seek(start, SeekOrigin.Begin);
            if (Crc32Algorithm.Compute(br.ReadBytes(Convert.ToInt32(size)*8)) != crc)
            {
                throw new MismatchCRC32Exception("CRC32 Checksum failed for Block 3 - Handles");
            }

            handles = new List<SHandle>();

            br.BaseStream.Seek(start, SeekOrigin.Begin);
            for (int i = 0; i < size; i++)
            {
                var o = br.ReadUInt32();
                var t = br.ReadUInt16();
                var f = br.ReadUInt16();

                handles.Add(new SHandle()
                {
                    type = references[t],
                    flags = f,
                    path = stringtable[o],
                });
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
        /// Block 5 - Chunks
        /// </summary>
        /// <param name="br"></param>
        private void ReadChunks(BinaryReader br)
        {
            var start = headers[4].offset;
            var size = headers[4].size;
            var crc = headers[4].crc32;

            br.BaseStream.Seek(start, SeekOrigin.Begin);
            if (Crc32Algorithm.Compute(br.ReadBytes(Convert.ToInt32(size)*24)) != crc)
            {
                throw new MismatchCRC32Exception("CRC32 Checksum failed for Block 5 - Chunks");
            }

            chunks = new List<SChunk>();

            br.BaseStream.Seek(start, SeekOrigin.Begin);
            for (int i = 0; i < size; i++)
            {
                var _typeID      = br.ReadUInt16();
                var _flags       = br.ReadUInt16();
                var _parentID    = br.ReadUInt32();
                var _size        = br.ReadUInt32();
                var _offset      = br.ReadUInt32();
                var _unknown4    = br.ReadUInt32();
                var _crc32       = br.ReadUInt32();

                var pos = br.BaseStream.Position;
                var temp = new SChunk()
                {
                    type = references[_typeID],
                    flags = _flags,
                    parentID = _parentID,
                };

                br.BaseStream.Seek(Convert.ToInt32(_offset), SeekOrigin.Begin);
                temp.data = br.ReadBytes(Convert.ToInt32(_size));

                if( Crc32Algorithm.Compute(temp.data) != _crc32 )
                {
                    throw new MismatchCRC32Exception($"CRC32 checksum failed for chunk {i+1} ({references[_typeID]})");
                }

                chunks.Add(temp);
                br.BaseStream.Seek(pos, SeekOrigin.Begin);
            }
        }

        /// <summary>
        /// Block 6 - Unknown
        /// </summary>
        /// <param name="br"></param>
        /* - Notes
         * 
         *  This block might contain seed information?
         *  Cannot rememeber what file it was, but within that file 
         *  variables within block 5 had info that alligned
         *  very closely to the block 6 items.
         *  
         *  Block 6 structure:
         *      UInt32 - Unknown1
         *               This value is always 0, could be an unsued placeholder in this version
         *      UInt32 - Id
         *               Index of its position in the array. i.e. 1 is first in the array 2 second (0 is not the beginning)
         *      UInt32 - Unknown
         *               No idea - Vast majority of files have this set to 0, except a handfull, when not zero no obvious pattern
         *      UInt32 - Unknown
         *      UInt32 - Unknown
         *               These two values are always the same
         *               With w2ter files values are only ever the following 2048, 8196, 32768, 131072, 524288, 2097152
         *               With any other file that has info in block 6 the values do not appear to have any sort of pattern.
         *      UInt32 - CRC32?
         *               This could be a CRC32 checksum value (as was in sarcens editor) but honestly no idea.
         *               Nothing to checksum against, the whole of block 6 has a valid CRC32 checksum in the header
         *               and a block 6 item does not point to any other bytes.
         *               
         *     Of all CR2W files that have data in Block 6:
         *              100% of .w2mesh         28738/28738
         *              75%  of .w2anims        355/472
         *              100% of .reddest        67/67
         *              100% of .w2ter          1411/1411
         *              2%   of .w3occlusion    163/6144
         *     
         *     This is therefore very likley to be mesh related data.
         *     
         */
        private void ReadBlock6(BinaryReader br)
        {
            var start = headers[5].offset;
            var size = headers[5].size;
            var crc = headers[5].crc32;

            br.BaseStream.Seek(start, SeekOrigin.Begin);
            if (Crc32Algorithm.Compute(br.ReadBytes(Convert.ToInt32(size)*24)) != crc)
            {
                throw new MismatchCRC32Exception("CRC32 Checksum failed for Block 6 - Unknown");
            }

            block6 = new List<SBlock6Item>();

            br.BaseStream.Seek(start, SeekOrigin.Begin);
            for (int i = 0; i < size; i++)
            {
                block6.Add(new SBlock6Item()
                {
                    unknown1 = br.ReadUInt32(),
                    id       = br.ReadUInt32(),
                    unknown3 = br.ReadUInt32(),
                    unknown4 = br.ReadUInt32(),
                    unknown5 = br.ReadUInt32(),
                    unknown6 = br.ReadUInt32()
                });
            }
        }

        /// <summary>
        /// Block 7 - Embedded CR2W Files
        /// </summary>
        /// <param name="br"></param>
        private void ReadEmbedded(BinaryReader br)
        {
            var start = headers[6].offset;
            var size = headers[6].size;
            var crc = headers[6].crc32;

            br.BaseStream.Seek(start, SeekOrigin.Begin);
            if (Crc32Algorithm.Compute(br.ReadBytes(Convert.ToInt32(size)*24)) != crc)
            {
                throw new MismatchCRC32Exception("CRC32 Checksum failed for Block 7 - Embedded");
            }

            embedded = new List<SEmbedded>();

            br.BaseStream.Seek(start, SeekOrigin.Begin);
            for (int i = 0; i < size; i++)
            {
                var temp = new SEmbedded()
                {
                    unknown1  = br.ReadUInt32(),
                    path      = br.ReadUInt32(),
                    unknown3  = br.ReadUInt32(),
                    unknown4  = br.ReadUInt32(),
                };
                var offset    = br.ReadUInt32();
                var len       = br.ReadUInt32();

                var pos = br.BaseStream.Position;

                br.BaseStream.Seek(offset, SeekOrigin.Begin);
                temp.data = br.ReadBytes(Convert.ToInt32(len));
                embedded.Add(temp);

                br.BaseStream.Seek( pos, SeekOrigin.Begin );
            }
        }
        #endregion

        #region Resource
        /* - Info
         *      Region for creating the finished CResource
         *      from the data held in the buffers that blocks 5 and 7 poitnt to.
         *      Block 5 - List of chunks that together make a Single CResource object and 
         *                all the CObjects the are referenced by it.
         *      Block 7 - List of embedded CR2W files that the main CResource can use
         *      
         *      TODO - Come up with an elegant solution to hold the emebedded files.
         *          Option 1: Parse each as a new CResource and return each one with the main as a list.
         *          Option 2: Parse each as a new CResource and store with the main one.
         *          Option 3: Do not parse but just hold as a byte array until the user needs to change stuff.
         *          Option 4: Export as a new CR2W physical file that can be later parsed.
         */

        void CreateResource()
        {
            var chunk = chunks[0];

            Type resType = Type.GetType($"CR2W.Types.W3.{chunk.type}");

            if (resType == null)
            {
                throw new UnknownObjectTypeException($"[UNKOWN TYPE] {chunk.type} could not be found");
            }

            if (!resType.IsSubclassOf(typeof(CResource)))
            {
                throw new InvalidOperationException($"[UNSUPPORTED TYPE] {chunk.type} is not a CResource");
            }

            var br = new BinaryReader(new MemoryStream(chunk.data));

            _resource = (CResource)Activator.CreateInstance(resType);
            _resource.Flags = chunk.flags;
            _resource.ParseBytes(br, this);

            br.Dispose();
        }

        #endregion
    }
}
