using System.Runtime.InteropServices;

namespace RED.CR2W.Utils
{
    /// <summary>
    /// Represents a reference to either an external or internal data buffer.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct CR2WBuffer
    {
        public uint flags;
        public uint index;
        public uint offset;
        public uint diskSize;
        public uint memSize;
        public uint crc32;
    }
}
