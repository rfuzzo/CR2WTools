using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    class ResourceTypeAttribute : Attribute
    {
        string Extension { get; set; }
        string Description { get; set; }

        public ResourceTypeAttribute(string ext, string desc)
        {
            Extension = ext;
            Description = desc;
        }
    }
}
