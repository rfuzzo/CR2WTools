using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.Types;

namespace CR2W.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class W3TypeAttribute : Attribute
    {
        public string Name { get; set; }
        public Type Handler { get; set; }
        public string Description { get; set; }

        public W3TypeAttribute( string name, Type handler )
        {
            if(String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("[W3TypeAttribute] Name property cannot be NULL or empty.");
            }
            if(!CName.IsCName(name))
            {
                throw new InvalidOperationException("[W3TypeAttribute] Name property is not a CName");
            }
            Name = name;
            Handler = handler;
        }

        public W3TypeAttribute(string name, Type handler, string description) : this(name, handler)
        {
            if (String.IsNullOrEmpty(description))
            {
                throw new ArgumentNullException("[W3TypeAttribute] Description property cannot be NULL or empty.");
            }
            Description = description;
        }
    }
}
