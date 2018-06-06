using System;
using CR2W.IO;
using CR2W.Types;
using CR2W.Exceptions;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CR2W.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class CR2WPropertyAttribute : Attribute
    {
        private const string TYPE_AUTO = "auto";

        public string Name              { get; private set; }
        public string TypeStr           { get; set; }
        public bool   ShouldSerialize   { get; set; }

        public CR2WPropertyAttribute(string name) : this(name, TYPE_AUTO) { }

        public CR2WPropertyAttribute(string name, string type)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name string was NULL or empty.");
            }
            Name = name;
            TypeStr = type;
        }

        public virtual object DeSerialize(BinaryReader br, CR2WParser p)
        {
            throw new NotImplementedException();
        }

        public virtual void Serialize(object value, BinaryWriter bw, CR2WExporter e)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"[{GetType().Name}] Name: {Name}, TypeName: {TypeStr}, Serialize: {ShouldSerialize}";
        }
    }
}
