using System;
using System.IO;
using CR2W.IO;
using CR2W.Types;
using CR2W.Exceptions;

namespace CR2W.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class FloatAttribute : CR2WPropertyAttribute
    {
        public FloatAttribute( string name ) : base(name, "Float") { }

        public override object DeSerialize(BinaryReader br, CR2WParser p)
        {
            return br.ReadSingle();
        }

        public override void Serialize(object value, BinaryWriter bw, CR2WExporter e)
        {
            if (value is float f)
            {
                bw.Write(e.AddNewReference(Name));
                bw.Write(e.AddNewReference(TypeStr));
                bw.Write((uint)8);
                bw.Write(f);
                return;
            }
            throw new UnknownObjectTypeException("[Float] Value was not a floating point number");
        }
    }
}
