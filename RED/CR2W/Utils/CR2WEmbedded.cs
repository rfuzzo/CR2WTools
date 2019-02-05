using System.Runtime.InteropServices;

namespace RED.CR2W.Utils
{
    /// <summary>
    /// Represents a reference to a CR2W file embedded inside a parent file.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct CR2WEmbedded
    {
        public uint importIndex;
        public uint path;
        public ulong pathHash;
        public uint dataOffset;
        public uint dataSize;
    }
}