using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.IO
{
    public class CR2WFile : IFile
    {
        public string           path;
        public SFileHeader      fileheader;
        public STableHeader[]   tableheaders;
        public SString[]        strings;
        public SName[]          names;
        public SResource[]      resources;
        public STable4Item[]    table4;
        public SObject[]        objects;
        public SBuffer[]        buffers;
        public SEmbedded[]      embedded;
    }

    public class SFileHeader
    {
        public uint verion;
        public uint flags;
        public ulong timeStamp;
        public uint buildVersion;
        public uint disksize;
        public uint memsize;
        public uint crc32;
        public uint numchunks;
    }

    public class STableHeader
    {
        public uint offset;
        public uint size;
        public uint crc32;

        public byte[] data;
    }

    public class SString
    {
        public uint offset;
        public string value;
    }

    public class SName
    {
        public uint offset;
        public uint hash;

        public string value;
    }

    public class SResource
    {
        public uint offset;
        public ushort typeid;
        public ushort flags;

        public string path;
        public string type;
    }

    public class STable4Item
    {
        public ushort classId;
        public ushort unknown1;
        public ushort propertyId;
        public ushort unknown2;
        public ulong hash;

        public string className;
        public string propertyName;
    }

    public class SObject
    {
        public uint index;
        public ushort typeID;
        public ushort flags;
        public uint parentID;
        public uint size;
        public uint offset;
        public uint template;
        public uint crc32;

        public byte[] data;
    }

    public class SBuffer
    {
        public uint flags;
        public uint index;
        public uint offset;
        public uint diskSize;
        public uint memSize;
        public uint crc32;

        public byte[] data;
    }

    public class SEmbedded
    {
        public uint importIndex;
        public uint path;
        public ulong pathHash;
        public uint offset;
        public uint length;

        public byte[] data;
    }
}