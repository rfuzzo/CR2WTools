using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public struct SSectorDataResource
    {
        public float box0 { get; set; }
        public float box1 { get; set; }
        public float box2 { get; set; }
        public float box3 { get; set; }
        public float box4 { get; set; }
        public float box5 { get; set; }
        public ulong patchHash { get; set; }
    }
}
