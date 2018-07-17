using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.IO
{
    public struct SCR2WFile
    {
        public uint          verion;
        public uint          flags;
        public ulong         timeStamp;
        public uint          buildVersion;
        public uint          disksize;
        public uint          memsize;
        public uint          crc32;
        public uint          numchunks;

        public string        path;

        public SHeader[]     headers;

        public SString[]     strings;
        public SName[]       names;
        public SResource[]   resources;
        public STable4Item[] table4;
        public SObject[]     objects;
        public SBuffer[]     buffers;
        public SEmbedded[]   embedded;
    }
}
