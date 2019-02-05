using System;
using System.Runtime.InteropServices;
using RED.CRC32;

/*
 *  Notes:
 *  
 *  Object size: 
 *      This referes to how big the resource class is.
 *      From the beginning of the file (from 'CR2W' header)
 *      to the end of the last object in the objects block.
 *      It does not include the buffers or embedded files.
 *      
 *      
 *  File size: 
 *      This referes to the single CR2W file size excluding embedded files.
 *      From the beginning of the file (from 'CR2W' header)
 *      to the end of the last buffer.
 *      
 *      There is no value that referes to the size including embedded, 
 *      as the header referes exclusively to its own CR2W file.
 */

namespace RED.CR2W.Utils
{
    /// <summary>
    /// Represents a header for a CR2W file ranging between versions 152 - 163.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal class CR2WHeader
    {
        public uint version;
        public uint flags;
        public ulong timeStamp;
        public uint buildVersion;
        public uint objectSize;
        public uint fileSize;
        public uint crc32;
        public uint numChunks;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public CR2WTable[] tableHeaders;

        public CR2WHeader()
        {
            tableHeaders = new CR2WTable[10];
        }

        /// <summary>
        /// Get acsess to a table header via index.
        /// </summary>
        /// <param name="index">The index of the table header.</param>
        /// <returns>The table header object.</returns>
        public CR2WTable this[int index]
        {
            get
            {
                return tableHeaders[index];
            }
            set
            {
                tableHeaders[index] = value;
            }
        }

        /// <summary>
        /// Calculate a CRC32 value for this file header instance.
        /// </summary>
        /// <returns>The CRC32 value.</returns>
        public uint CalculateCRC32()
        {
            var hash = new Crc32Algorithm(false);
            hash.Append(0x57325243);
            hash.Append(version);
            hash.Append(flags);
            hash.Append(timeStamp);
            hash.Append(buildVersion);
            hash.Append(objectSize);
            hash.Append(fileSize);
            hash.Append(0xDEADBEEF);
            hash.Append(numChunks);
            foreach (var h in tableHeaders)
            {
                hash.Append(h.offset);
                hash.Append(h.size);
                hash.Append(h.crc32);
            }
            return hash.HashUInt32;
        }

        /// <summary>
        /// Calculate a CRC32 value for this file header instance, and set <see cref="CR2WHeader.crc32"/> to that value.
        /// </summary>
        public void SetCRC32()
        {
            this.crc32 = CalculateCRC32();
        }
    }
}