using CR2W.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CJournalPath : ISerializable
{
#region RED Properties

[REDProp("guid")]
public CGUID Guid { get; set;}

/*[REDProp("resource")]
public Soft<CResource> Resource { get; set;}*/

[REDProp("child")]
public Handle<CJournalPath> Child { get; set;}

        #endregion

        //FIXME abstract classes
        public override UInt16 Flags { get; set; }
        public override UInt32 Template { get; set; }

        public override event SerializeEventHandler Serialize;
        public override event DeSerializeEventHandler DeSerialize;

        public override void OnSerialize(IFile source, REDEventArgs e) { }
        public override void OnDeSerialize(IFile source, REDEventArgs e) { }
    }
}