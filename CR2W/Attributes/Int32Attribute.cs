using System;
using System.IO;
using CR2W.IO;
using CR2W.Types;
using CR2W.Exceptions;

namespace CR2W.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class Int32Attribute : CR2WPropertyAttribute
    {
        public Int32Attribute(string name) : base(name, "Int32") { }

        public override object DeSerialize(BinaryReader br, CR2WParser p)
        {
            return br.ReadInt32();
        }

        public override void Serialize(object value, BinaryWriter bw, CR2WExporter e)
        {
            if(value is Int32 i)
            {
                bw.Write(e.AddNewReference(Name));
                bw.Write(e.AddNewReference(TypeStr));
                bw.Write((uint)8);
                bw.Write(i);
                return;
            }
            throw new UnknownObjectTypeException("[Int32] Value was not a Int32.");
        }
    }
}