using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.IO;

namespace CR2W.Types.W3
{
    public class CSectorData : ISerializable, IReferencable
    {
        public uint Unknown1 { get; set; }
        public byte Unknown2 { get; set; }

        public SSectorDataResource[] resources;
        public SSectorDataObject[]   objects;

        public byte[] blockdata;

        public event SerializeEventHandler Serialize;
        public event DeSerializeEventHandler DeSerialize;

        public void ParseBytes(CR2WBinaryReader br, uint size)
        {
            throw new NotImplementedException();
        }
    }
}
