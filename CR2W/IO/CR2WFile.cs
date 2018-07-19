using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.IO
{
    public class CR2WFile : IFile
    {
        public string        path;

        public uint          verion;
        public uint          flags;
        public ulong         timeStamp;
        public uint          buildVersion;
        public uint          disksize;
        public uint          memsize;
        public uint          crc32;
        public uint          numchunks;

        public SHeader[]     headers;

        public SString[]     strings;
        public SName[]       names;
        public SResource[]   resources;
        public STable4Item[] table4;
        public SObject[]     objects;
        public SBuffer[]     buffers;
        public SEmbedded[]   embedded;
    }

    public class SHeader
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
        public uint var1;
        public uint var2;
        public uint var3;
        public uint var4;
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