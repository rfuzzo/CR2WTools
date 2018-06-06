using System;
using System.IO;
using System.Linq;
using CR2W.IO;
using CR2W.Types;
using CR2W.Exceptions;

namespace CR2W.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class CNameAttribute : CR2WPropertyAttribute
    {
        public CNameAttribute(string name) : base(name, "CName") { }   

        public override object DeSerialize(BinaryReader br, CR2WParser p)
        {
            var id = br.ReadUInt16();
            return p.references[id];
        }
    }
}