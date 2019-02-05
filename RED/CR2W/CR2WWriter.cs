using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using RED.Core;
using RED.CRC32;
using RED.FNV1A;
using RED.CR2W.Utils;
using System.Reflection;
using RED.Reflection;
using RED.IO;

namespace RED.CR2W
{
    public sealed class CR2WWriter : REDBinaryWriter
    {
        public const uint MAGIC = 0x57325243;       // 'CR2W'
        public const uint VERSION = 0xA3;           // 163
        public const uint FLAGS = 0x0;              // 0
        public const uint BUILD = 0x12E9CE;         // 1239502
        public const uint DEADBEEF = 0xDEADBEEF;    // 3735928559
        public const uint CHUNKS = 0x06;            // 6

        public ulong CREATIONTIME => CDateTime.Now.ToUInt64();

        private uint OBJECTSIZE => Convert.ToUInt32(BaseStream.Length);
        private uint FILESIZE => Convert.ToUInt32(BaseStream.Length);

        private long CalculateDataOffset()
        {
            var offset = 160L;
            checked
            {
                offset += m_strings.Sum(s => s.Value.Length + 1);
                offset += m_names.Count * Marshal.SizeOf<CR2WName>();
                offset += m_imports.Count * Marshal.SizeOf<CR2WImport>();
                offset += m_properties.Count * Marshal.SizeOf<CR2WProperty>();
                offset += m_exports.Count * Marshal.SizeOf<CR2WExport>();
                offset += m_buffers.Count * Marshal.SizeOf<CR2WBuffer>();
                offset += m_embedded.Count * Marshal.SizeOf<CR2WEmbedded>();
            }
            return offset;
        }

        private CR2WHeader                m_header;
        private Dictionary<uint, string>  m_strings;
        private List<CR2WName>            m_names;
        private List<CR2WImport>          m_imports;
        private List<CR2WProperty>        m_properties;
        private List<CR2WExport>          m_exports;
        private List<CR2WBuffer>          m_buffers;
        private List<CR2WEmbedded>        m_embedded;

        private FNV1A32HashAlgorithm m_fnv1a32;

        public CR2WWriter(Stream stream)
            : base(stream, false)
        {
            m_header     = new CR2WHeader();
            m_strings    = new Dictionary<uint, string>();
            m_names      = new List<CR2WName>();
            m_imports    = new List<CR2WImport>();
            m_properties = new List<CR2WProperty>();
            m_exports    = new List<CR2WExport>();
            m_buffers    = new List<CR2WBuffer>();
            m_embedded   = new List<CR2WEmbedded>();


            //AddProperty(null);
        }

        public void Serialize()
        {
            WriteTables();
        }

        #region TableConstruction
        private UInt16 AddName(CName value)
        {
            var index = m_names.FindIndex(n => n.hash == (uint)value.GetHashCode());
            if (index >= 0)
            {
                return Convert.ToUInt16(index);
            }
            m_names.Add(new CR2WName
            {
                //value = m_strings.AddString(value, out var isNew),
                hash = (uint)value.GetHashCode(),
            });
            return Convert.ToUInt16(m_names.Count - 1);
        }
        private UInt16 AddImport(object value)
        {
            //var index = m_imports.FindIndex(i => i.Equals(value));
            //if(index > 0)
            //{
            //    return (ushort)(index + 1);
            //}
            //m_imports.Add(new CR2WImport()
            //{
            //    className = AddName(value.ClassName),
            //    //depotPath = m_strings.AddString(value.DepotPath, out var isNew),
            //    flags = value.Flags,
            //});
            return (ushort)m_imports.Count;
        }
        private UInt16 AddProperty(FieldInfo info)
        {
            var propertyName = info == null ? string.Empty : info.Name;
            var className = info == null ? string.Empty : info.DeclaringType.Name;

            var fnv1a = new FNV1A64HashAlgorithm();

            fnv1a.AppendString(className, true);
            fnv1a.AppendString(propertyName, true);

            var index = m_properties.FindIndex(i => i.hash == fnv1a.HashUInt64);
            if (index >= 0)
            {
                return Convert.ToUInt16(index);
            }
            m_properties.Add(new CR2WProperty()
            {
                className = AddName(className),
                classFlags = 0,
                propertyName = AddName(propertyName),
                propertyFlags = 0,
                hash = fnv1a.HashUInt64,
            });
            fnv1a.Dispose();
            return Convert.ToUInt16(m_properties.Count);
        }
        #endregion

        #region Tables and Headers
        public void WriteTables()
        {
            BaseStream.Seek(160, SeekOrigin.Begin);

            WriteTable(m_names, 1);
            WriteTable(m_imports, 2);
            WriteTable(m_properties, 3);
            WriteTable(m_exports, 4);
            WriteTable(m_buffers, 5);
            WriteTable(m_embedded, 6);

            BaseStream.Seek(0, SeekOrigin.Begin);

            m_header.version       = VERSION;
            m_header.flags         = FLAGS;
            m_header.timeStamp     = CREATIONTIME;
            m_header.objectSize    = OBJECTSIZE;
            m_header.fileSize      = FILESIZE;
            m_header.buildVersion  = BUILD;
            m_header.numChunks     = CHUNKS;

            m_header.SetCRC32();

            Write(MAGIC);
            WriteStruct(m_header);
        }
        private void WriteTable<T>(IList<T> array, int index) where T : struct
        {
            if (array.Count == 0)
                return;

            var hash = new Crc32Algorithm(false);
            var start = Convert.ToUInt32(BaseStream.Position);
            WriteStructs<T>(array.ToArray(), hash);

            m_header[index] = new CR2WTable()
            {
                offset = start,
                size = (uint)array.Count,
                crc32 = hash.HashUInt32,
            };
        }
        #endregion

        #region Data
        public void WriteData()
        {




        }
        #endregion

        #region Cleaning Up
        public override void Dispose()
        {
            base.Dispose();
            m_strings    = null;
            m_names      = null;
            m_imports    = null;
            m_properties = null;
            m_exports    = null;
            m_buffers    = null;
            m_embedded   = null;
        }
        #endregion

        public override void Write(CName value)
        {
            throw new NotImplementedException();
        }
    }
}