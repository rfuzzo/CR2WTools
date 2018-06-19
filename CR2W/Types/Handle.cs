using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.Types.W3;

namespace CR2W.Types
{
    /// <summary>
    /// Enum to define the type of a CR2W handle.
    /// </summary>
    public enum EHandleType
    {
        /// <summary>
        /// The handle is a reference type and points to a CResoure object within the same file.
        /// </summary>
        ReferenceHandle,
        /// <summary>
        /// The handle is a resource type and points to an external CResource file.
        /// </summary>
        ResourceHandle
    }

    public class Handle<T> where T : CResource
    {
        public string DepotPath { get; set; }
        public ushort Flags { get; set; }
    }

   
}
