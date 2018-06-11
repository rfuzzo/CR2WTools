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
        string ClassName { get; set; }
        string Extension { get; set; }

        public ResourceTypeAttribute(string name, string ext)
        {
            ClassName = name;
            Extension = ext;
        }
    }
}
