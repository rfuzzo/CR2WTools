using System;
using CR2W.Types;

namespace CR2W.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class REDPropAttribute : Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Flags { get; set; }

        public REDPropAttribute( string name, params byte[] flags)
        {
            if(String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("[REDAttribute] Name property cannot be NULL or empty.");
            }
            Name = name;
            Flags = flags;
        }

        public REDPropAttribute(string name, string description, params byte[] flags) : this(name, flags)
        {
            if (String.IsNullOrEmpty(description))
            {
                throw new ArgumentNullException("[REDAttribute] Description property cannot be NULL or empty.");
            }
            Description = description;
        }
    }
}
