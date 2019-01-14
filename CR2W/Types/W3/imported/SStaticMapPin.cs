using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SStaticMapPin 
{
#region RED Properties

[REDProp("tag")]
public CName Tag { get; set;}

[REDProp("iconType")]
public CName IconType { get; set;}

[REDProp("posX")]
public Int32 PosX { get; set;}

[REDProp("posY")]
public Int32 PosY { get; set;}

[REDProp("journalEntry")]
public Soft<CJournalResource> JournalEntry { get; set;}

#endregion
}
}