using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SStaticMapPin 
{
#region RED Properties

[REDProp("tag")]
public CName Tag { get; set;}

[REDProp("iconType")]
public CName IconType { get; set;}

[REDProp("posX")]
public int PosX { get; set;}

[REDProp("posY")]
public int PosY { get; set;}

[REDProp("journalEntry")]
public Soft<CJournalResource> JournalEntry { get; set;}

#endregion
}
}