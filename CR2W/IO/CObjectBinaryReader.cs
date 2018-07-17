using CR2W.Types.W3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.IO
{
    class CObjectBinaryReader : BinaryReader
    {
        public static CObject ReadCObject(SObject template, CR2WBinaryReader parent)
        {
            using (var mem = new MemoryStream(template.data))
            {
                template.data = null;
                using (var br = new CObjectBinaryReader(mem, template, parent))
                {
                    return br.ReadAll();
                }
            }
        }

        public SObject ObjectData         { get; set; }
        public CR2WBinaryReader Parent  { get; set; }

        public CObjectBinaryReader(Stream data, SObject objdata, CR2WBinaryReader parent) : base(data, Encoding.ASCII, false)
        {
            ObjectData = objdata;
            Parent = parent;
        }

        public CObject ReadAll()
        {
            var type = Parent.names[ObjectData.typeID];
            Type resType = Type.GetType($"CR2W.Types.W3.{type}");

            if (resType == null)
                throw new UnknownObjectTypeException($"{type} could not be found");

            if (!resType.IsSubclassOf(typeof(CObject)))
                throw new InvalidOperationException($"{type} is not a CObject");

            BaseStream.Seek(ObjectData.offset, SeekOrigin.Begin);

            CObject temp = (CObject)Activator.CreateInstance(resType);

            return temp;
        }
    }
}
