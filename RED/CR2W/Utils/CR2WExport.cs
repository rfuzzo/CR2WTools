using System.Runtime.InteropServices;

namespace RED.CR2W.Utils
{
    /// <summary>
    /// Represents a reference to a serializable data object graph.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct CR2WExport
    {
        public ushort className;
        public ushort objectFlags;
        public uint parentID;
        public uint dataSize;
        public uint dataOffset;
        public int template;
        public uint crc32;
    }
}