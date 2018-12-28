using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SSavegameInfo 
{
#region RED Properties

[REDProp("filename")]
public string Filename { get; set;}

[REDProp("slotType")]
public ESaveGameType SlotType { get; set;}

[REDProp("slotIndex")]
public int SlotIndex { get; set;}

#endregion
}
}