using System;
using System.IO;
using CR2W.IO;
using CR2W.Types;
using CR2W.Exceptions;

namespace CR2W.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class Uint16Attribute : CR2WPropertyAttribute
    {
        public Uint16Attribute(string name) : base(name, "Uint16") { }

        public override object DeSerialize(BinaryReader br, CR2WParser p)
        {
            return br.ReadUInt16();
        }

        public override void Serialize(object value, BinaryWriter bw, CR2WExporter e)
        {
            if(value is UInt16 i)
            {
                bw.Write(e.AddNewReference(Name));
                bw.Write(e.AddNewReference(TypeStr));
                bw.Write((uint)6);
                bw.Write(i);
                return;
            }
            throw new UnknownObjectTypeException("[Uint16] Value was not a Uint16");
        }
    }
}
