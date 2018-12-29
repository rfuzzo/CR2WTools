﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        /// The handle is a reference type and points to a CResource object within the same file.
        /// </summary>
        ReferenceHandle,
        /// <summary>
        /// The handle is a resource type and points to an external CResource file.
        /// </summary>
        ResourceHandle
    }

    [REDPrimitive]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public struct Handle<T>
    {
        public EHandleType HandleType { get; set; }

        public int Index { get; set; }

        public string DepotPath { get; set; }
        public ushort Flags { get; set; }

        [TypeConverter(typeof(string))]
        public Type HandleOf
        {
            get
            {
                return typeof(T);
            }
        }
    }
}
