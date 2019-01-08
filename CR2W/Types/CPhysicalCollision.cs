using CR2W.Types.W3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types
{
    //[REDPrimitive]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public struct CPhysicalCollision
    {
        //parent pointer
        public uint Parent { get; set; }

        //array of collision types (CName)
        public Array<CName> CollisionTypes { get; set; }


        public byte[] UnknownBytes { get; set; }

    }
}
