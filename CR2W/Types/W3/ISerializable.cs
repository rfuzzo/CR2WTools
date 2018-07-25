using CR2W.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
    public delegate void SerializeEventHandler(IFile sender, REDEventArgs e);
    public delegate void DeSerializeEventHandler(IFile sender, REDEventArgs e);

    public interface ISerializable
    {
        event SerializeEventHandler Serialize;
        event DeSerializeEventHandler DeSerialize;
    }
}
