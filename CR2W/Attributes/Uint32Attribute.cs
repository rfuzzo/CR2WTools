using System;
using System.IO;
using CR2W.IO;
using CR2W.Types;
using CR2W.Exceptions;

namespace CR2W.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class Uint32Attribute : CR2WPropertyAttribute
    {
        public Uint32Attribute(string name) : base(name, "Uint32") { }

        public override object DeSerialize(BinaryReader br, CR2WParser p)
        {
            return br.ReadUInt32();
        }

        public override void Serialize(object value, BinaryWriter bw, CR2WExporter e)
        {
            if(value is UInt32 i)
            {
                bw.Write(e.AddNewReference(Name));
                bw.Write(e.AddNewReference(TypeStr));
                bw.Write((uint)8);
                bw.Write(i);
                return;
            }
            throw new UnknownObjectTypeException("[Uint32] Value was not a Uint32");
        }
    }
}
