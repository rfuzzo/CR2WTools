using System.Runtime.InteropServices;

namespace RED.DDS.Utils
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DDSStruct
    {
        public uint size; // equals size of struct (which is part of the data file!) 124
        public uint flags;
        public uint height;
        public uint width;
        public uint sizeorpitch;
        public uint depth;
        public uint mipmapcount;
        public uint alphabitdepth;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public uint[] reserved;

        public DDSPixelForamtStruct pixelformat;
        public DDSCapsStruct ddscaps;

        public uint texturestage;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DDSPixelForamtStruct
    {
        public uint size;   // equals size of struct (which is part of the data file!) 32
        public uint flags;
        public uint fourcc;
        public uint rgbbitcount;
        public uint rbitmask;
        public uint gbitmask;
        public uint bbitmask;
        public uint alphabitmask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DDSCapsStruct
    {
        public uint caps1;
        public uint caps2;
        public uint caps3;
        public uint caps4;
    }
}
