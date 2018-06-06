using System;
using System.IO;
using CR2W.IO;
using CR2W.Types;
using CR2W.Exceptions;

namespace CR2W.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class CGUIDAttribute : CR2WPropertyAttribute
    {
        public CGUIDAttribute(string name) : base(name, "CGUID") { }

        public override object DeSerialize(BinaryReader br, CR2WParser p)
        {
            return new Guid(br.ReadBytes(16));
        }
    }
}
