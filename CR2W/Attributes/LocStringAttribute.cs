using System;
using System.IO;
using CR2W.IO;
using CR2W.Types;
using CR2W.Exceptions;

namespace CR2W.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class LocStringAttribute : CR2WPropertyAttribute
    {
        public LocStringAttribute(string name) : base(name, "LocalizedString") { }

        public override object DeSerialize(BinaryReader br, CR2WParser p)
        {
            return br.ReadUInt32();
        }
    }
}
