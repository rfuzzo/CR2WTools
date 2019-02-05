using System.Runtime.InteropServices;

namespace RED.CR2W.Utils
{
    /// <summary>
    /// Represents a property of a REDEngine class.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    internal struct CR2WProperty
    {
        public ushort className;
        public ushort classFlags;
        public ushort propertyName;
        public ushort propertyFlags;
        public ulong hash;
    }
}
