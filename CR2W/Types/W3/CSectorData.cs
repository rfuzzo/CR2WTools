using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.IO;

namespace CR2W.Types.W3
{
    public class CSectorData : ISerializable
    {
        public uint Unknown1 { get; set; }
        public byte Unknown2 { get; set; }

        public override ushort Flags { get; set; }
        public override uint Template { get; set; }

        public SSectorDataResource[] resources;
        public SSectorDataObject[]   objects;

        public byte[] blockdata;

        public override event SerializeEventHandler Serialize;
        public override event DeSerializeEventHandler DeSerialize;

        public override void OnSerialize(IFile source, REDEventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void OnDeSerialize(IFile source, REDEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
