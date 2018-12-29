using CR2W.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
    public delegate void SerializeEventHandler(IFile sender, REDEventArgs e);
    public delegate void DeSerializeEventHandler(IFile sender, REDEventArgs e);

    public abstract class ISerializable : IReferencable
    {
        public abstract UInt16 Flags { get; set; }
        public abstract UInt32 Template { get; set; }

        public abstract event SerializeEventHandler Serialize;
        public abstract event DeSerializeEventHandler DeSerialize;

        public abstract void OnSerialize(IFile source, REDEventArgs e);
        public abstract void OnDeSerialize(IFile source, REDEventArgs e);
    }
}
