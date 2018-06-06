using System;
using System.IO;
using CR2W.IO;
using CR2W.Types;
using CR2W.Exceptions;

namespace CR2W.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class Int8Attribute : CR2WPropertyAttribute
    {
        public Int8Attribute(string name) : base(name, "Int8") { }

        public override object DeSerialize(BinaryReader br, CR2WParser p)
        {
            return br.ReadSByte();
        }

        public override void Serialize(object value, BinaryWriter bw, CR2WExporter e)
        {
            if(value is sbyte b)
            {
                bw.Write(e.AddNewReference(Name));
                bw.Write(e.AddNewReference(TypeStr));
                bw.Write((uint)5);
                bw.Write(b);
                return;
            }
            throw new UnknownObjectTypeException( "[Int8] Value was not a sbyte" );
        }
    }
}
