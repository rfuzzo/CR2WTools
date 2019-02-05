using System.Runtime.InteropServices;

namespace RED.CR2W.Utils
{
    /// <summary>
    /// Represents a reference to an exteranl depot CResource file.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct CR2WImport
    {
        public uint depotPath;
        public ushort className;
        public ushort flags;
    }
}
