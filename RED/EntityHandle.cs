using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RED.CR2W;

namespace RED
{
    public enum EntityHandleType : byte
    {
        None = 0,
        IdTag = 1,
        Entity = 2,
    }

    public struct EntityHandle
    {
        public EntityHandleType HandleType { get; set; }

        public bool Dynamic { get; set; }
        public CGUID Value { get; set; }
        public byte[] Unknown { get; set; }

        public override string ToString()
        {
            if (HandleType == EntityHandleType.IdTag)
                return String.Format("[IdTag - {0}: {1}]", Dynamic ? "Dynamic" : "Static", Value.ToString() );

            if (HandleType == EntityHandleType.Entity)
                return String.Format("[Entity - {0}]", Value.ToString());

            return "None";
        }
    }
} 