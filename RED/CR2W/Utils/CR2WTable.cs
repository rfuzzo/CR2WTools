using System.Runtime.InteropServices;

namespace RED.CR2W.Utils
{
    /// <summary>
    /// Represents the header of a table in a CR2W file.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct CR2WTable
    {
        public uint offset;
        public uint size;
        public uint crc32;
    }
}