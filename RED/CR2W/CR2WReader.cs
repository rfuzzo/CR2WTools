using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using RED.Core;
using RED.CRC32;
using RED.CR2W.Utils;
using RED.IO;
using RED.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace RED.CR2W
{
    public class ObjectInfo
    {
        public ushort NameID { get; set; }
        public object Instance { get; set; }
        public byte[] Data { get; set; }
    }

    /// <summary>
    /// Reads a Witcher Resource Class File
    /// </summary>
    public sealed class CR2WReader : REDBinaryReader
    {
        #region Properties & Variables
        private CR2WHeader                 m_header;
        private Dictionary<uint, string>   m_strings;
        private CR2WName[]                 m_names;
        private CR2WImport[]               m_imports;
        private CR2WProperty[]             m_properties;
        private CR2WExport[]               m_exports;
        private CR2WBuffer[]               m_buffers;
        private CR2WEmbedded[]             m_embedded;

        private object[] m_object;

        private bool m_ignoreErrors;
        private bool m_isValid;
        private bool m_hasInternalBuffers;

        public bool IgnoreErrors => m_ignoreErrors;
        public bool IsValidFile => m_isValid;
        public bool HasInternalBuffers => m_hasInternalBuffers;

        public const uint MAGIC = 0x57325243; // W2RC (le) Witcher 2 Resource Class

        #endregion

        #region Constructors
        public CR2WReader(Stream stream)
            : this(stream, false)
        {

        }
        public CR2WReader(byte[] bytes)
            : this(bytes, false)
        {

        }
        public CR2WReader(byte[] bytes, bool ignoreErrors)
            : this(new MemoryStream(bytes, false), false)
        {

        }
        public CR2WReader(Stream stream, bool ignoreErrors)
            : base(stream, false)
        {
            m_ignoreErrors = ignoreErrors;

            LoadFileData();
            LogTables();
        }
        #endregion

        #region Headers and Tables
        private void LoadFileData()
        {
            if (BaseStream.Length - BaseStream.Position < 160)
                throw new InvalidCR2WFileException("File size falls below the minimum for a valid CR2W file.");

            var idString = ReadUInt32();
            
            if (idString != MAGIC)
                throw new InvalidCR2WFileException($"Invalid Magic: '0x{idString:X8}'.");
            
            m_header = ReadStruct<CR2WHeader>();
            
            if (m_header.version < 159 || m_header.version > 163)
                throw new InvalidCR2WFileException($"Invalid Version: '{m_header.version}'.");
            
            if (!IgnoreErrors && m_header.CalculateCRC32() != m_header.crc32)
                throw new MismatchCRC32Exception("CRC32 checksum failed for file header.");

            m_strings    = ReadStringTable();
            m_names      = ReadTable<CR2WName>(1);
            m_imports    = ReadTable<CR2WImport>(2);
            m_properties = ReadTable<CR2WProperty>(3);
            m_exports    = ReadTable<CR2WExport>(4);
            m_buffers    = ReadTable<CR2WBuffer>(5);
            m_embedded   = ReadTable<CR2WEmbedded>(6);

            m_hasInternalBuffers = m_header.fileSize > m_header.objectSize;

            m_isValid = true;
        }
        private Dictionary<uint, string> ReadStringTable()
        {
            BaseStream.Seek(m_header[0].offset, SeekOrigin.Begin);
            var temp = ReadBytes((int)m_header[0].size);

            if (!m_ignoreErrors && Crc32Algorithm.Compute(temp) != m_header[0].crc32)
                throw new MismatchCRC32Exception("CRC32 checksum failed for table 1 - Strings");

            var strings = new Dictionary<uint, string>();
            var sb = new StringBuilder();
            var offset = 0u;
            for (uint i = 0; i < temp.Length; i++)
            {
                var b = temp[i];
                if (b == 0)
                {
                    m_strings.Add(offset, sb.ToString());
                    sb.Clear();
                    offset = i + 1;
                }
                else
                {
                    sb.Append((char)b);
                }
            }

            return strings;
        }
        private T[] ReadTable<T>(int index) where T : struct
        {
            BaseStream.Seek(m_header[index].offset, SeekOrigin.Begin);

            var hash = new Crc32Algorithm(false);
            var table = ReadStructs<T>(m_header[index].size, hash);

            if (!m_ignoreErrors && m_header[index].crc32 != hash.HashUInt32)
                throw new MismatchCRC32Exception($"CRC32 checksum failed for table {index} - {typeof(T).Name}");

            return table;
        }
        #endregion

        #region Objects
        public void QueueObjects()
        {
            var objects = new ObjectInfo[m_exports.Length];
            for (int i = 0; i < m_exports.Length; i++)
            {
                var e = m_exports[i];

                var className = GetCName(e.className);
                var type = AssemblyDictionary.GetTypeByName(className);
                if(type == null)
                {
                    throw new Exception($"Unknown Type: '{className}'");
                }

                BaseStream.Seek(e.dataOffset, SeekOrigin.Begin);
                var objData = ReadBytes((int)e.dataSize);
                if(!IgnoreErrors && Crc32Algorithm.Compute(objData) != e.crc32)
                {
                    throw new MismatchCRC32Exception();
                }

                var instance = Activator.CreateInstance(type);
                if(instance is CObject obj)
                {
                    obj.Template = e.template;
                    obj.Flags = (ECObjectFlags)e.objectFlags;
                }

                objects[i] = new ObjectInfo()
                {
                    Instance = instance,
                    NameID   = e.className,
                    Data     = objData,
                };
            }
        }

        private void DeSerializeObjects()
        {
            
        }

        #endregion

        public override CName ReadCName()
        {
            var index = ReadUInt16();
            return GetCName(index);
        }
        public CName GetCName(ushort index)
        {
            var n = m_names[index];
            return new CName(m_strings[n.value]);
        }

        #region Cleaning Up
        public override void Dispose()
        {
            base.Dispose();

            m_header     = null;
            m_strings    = null;
            m_names      = null;
            m_imports    = null;
            m_properties = null;
            m_exports    = null;
            m_buffers    = null;
            m_embedded   = null;
        }
        #endregion

        #region Debug
        public void LogTables()
        {
            Debug.WriteLine("File Header:");
            Debug.WriteLine("Version:   {0}", m_header.version);
            Debug.WriteLine("Flags:     {0}", m_header.flags);
            Debug.WriteLine("DateTime:  {0}", new CDateTime(m_header.timeStamp));
            Debug.WriteLine("Build:     {0}", m_header.buildVersion);
            Debug.WriteLine("ObjSize:   {0}", m_header.objectSize);
            Debug.WriteLine("FileSize:  {0}", m_header.fileSize);
            Debug.WriteLine("CRC32      0x{0:X8}", m_header.crc32);
            Debug.WriteLine("NumChunks: {0}", m_header.numChunks);

            Debug.WriteLine($"\nTable Headers:");
            Debug.WriteLine("Offset     Size        CRC32");
            foreach (var item in m_header.tableHeaders)
                Debug.WriteLine("{0,-11}{1,-11} 0x{2:X8}",
                    item.offset, 
                    item.size, 
                    item.crc32);
            
            Debug.WriteLine("\nStrings: {0}", m_strings.Count);
            Debug.WriteLine("Offset     Value");
            foreach (var item in m_strings)
                Debug.WriteLine("{0,-11}{1}", 
                    item.Key,
                    item.Value);
            
            Debug.WriteLine("\nNames: {0}", m_names.Length);
            Debug.WriteLine("Index Offset      Hash");
            for (ushort i = 0; i < m_names.Length; i++)
                Debug.WriteLine("{0,-6}{1,-11} 0x{2:X8}", 
                    i, 
                    m_names[i].value, 
                    m_names[i].hash);
            
            Debug.WriteLine("\nImports: {0}", m_imports.Length);
            Debug.WriteLine("Class Path       Flags");
            foreach (var item in m_imports)
                Debug.WriteLine("{0,-6}{1,-11}{2,-6}",
                    item.className, 
                    item.depotPath, 
                    item.flags);
            
            Debug.WriteLine("\nProperties: {0}", m_properties.Length);
            Debug.WriteLine("Class Flags Prop  Flags  Hash");
            foreach (var item in m_properties)
                Debug.WriteLine("{0,-6}{1,-6}{2,-6}{3,-6} 0x{4:X16}", 
                    item.className, 
                    item.classFlags, 
                    item.propertyName, 
                    item.propertyFlags, 
                    item.hash);
            
            Debug.WriteLine("\nExports: {0}", m_exports.Length);
            Debug.WriteLine("Class Flags Parent     Offset     Size       Template    CRC32");
            foreach (var item in m_exports)
                Debug.WriteLine("{0,-6}{1,-6}{2,-11}{3,-11}{4,-11}{5,-11} 0x{6:X8}", 
                    item.className, 
                    item.objectFlags, 
                    item.parentID, 
                    item.dataOffset, 
                    item.dataSize, 
                    item.template, 
                    item.crc32);
            
            Debug.WriteLine("\nBuffers: {0}", m_buffers.Length);
            Debug.WriteLine("Flags      Index      Offset     DiskSize   MemSize     CRC32");
            foreach (var item in m_buffers)
                Debug.WriteLine("{0,-11}{1,-11}{2,-11}{3,-11}{4,-11} 0x{5:X8}", 
                    item.flags, 
                    item.index, 
                    item.offset, 
                    item.diskSize, 
                    item.memSize, 
                    item.crc32);
            
            Debug.WriteLine("\nEmbedded: {0}", m_embedded.Length);
            foreach (var item in m_embedded)
                Debug.WriteLine("{0,-11}{1,-11}{2,-11}{3,-11} 0x{4:X16}", 
                    item.path, 
                    item.importIndex, 
                    item.dataOffset, 
                    item.dataSize, 
                    item.pathHash);
        }
        #endregion
    }
}