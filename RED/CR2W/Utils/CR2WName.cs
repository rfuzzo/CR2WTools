using System.Runtime.InteropServices;

namespace RED.CR2W.Utils
{
    /// <summary>
    /// Represnts a CName reference. 
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct CR2WName
    {
        public uint value;
        public uint hash;
    }
}
