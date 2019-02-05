using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Diagnostics;
using RED.CR2W;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RED.Core
{
    [Flags] public enum ECObjectFlags : ushort
    {
        //Note - 0 most likey means the object is uncooked.
        Flag1  = 0x1,
        Flag2  = 0x2,
        Flag3  = 0x4,
        Flag4  = 0x8, //Note - This one is also commonly use in combination with 0x2000
        Flag5  = 0x10,
        Flag6  = 0x20,
        Flag7  = 0x40,
        Flag8  = 0x80,
        Flag9  = 0x100,
        Flag10 = 0x200,
        Flag11 = 0x400,
        Flag12 = 0x800,
        Flag13 = 0x1000,
        Flag14 = 0x2000, //Note - This one most likey indicates the object is cooked.
        Flag15 = 0x4000,
        Flag16 = 0x8000,
    }

    public abstract class CObject : IScriptable
    {
        private CObject m_parent;

        public ECObjectFlags Flags    { get; set; }
        public Int32         Template { get; set; }
        public CObject       Parent   { get; set; }

        public CObject()
        {
            
        }

        /// <summary>
        /// Get the CObject parent for this instance 
        /// </summary>
        /// <returns>Parent Object</returns>
        public CObject GetParent()
        {
            throw new NotImplementedException();
        }

        internal void SetParent(CObject parent)
        {

        }

        /// <summary>
        /// Clone the current instance to a new parent
        /// </summary>
        /// <param name="newParent">Parent to clone to</param>
        /// <returns>Cloned Instance</returns>
        public CObject Clone( CObject newParent )
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Check if this instance is refered to in another CObject
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Boolean if the CObject is in it</returns>
        public bool IsIn( CObject value )
        {
            throw new NotImplementedException();
        }
    }
}