using System;
using System.IO;
using CR2W.IO;
using CR2W.Exceptions;
using CR2W.Types;

namespace CR2W.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class BoolAttribute : CR2WPropertyAttribute
    {
        public BoolAttribute(string name) : base(name, "Bool") { }

        public override object DeSerialize(BinaryReader br, CR2WParser p)
        {
            return br.ReadBoolean();
        }
    }
}
