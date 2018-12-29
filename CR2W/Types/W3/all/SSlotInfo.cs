using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SSlotInfo 
{
#region RED Properties

[REDProp("slotName")]
public CName SlotName { get; set;}

[REDProp("parentSlotName")]
public CName ParentSlotName { get; set;}

[REDProp("parentSlotIndex")]
public int ParentSlotIndex { get; set;}

[REDProp("relativePosition")]
public Vector RelativePosition { get; set;}

[REDProp("relativeRotation")]
public EulerAngles RelativeRotation { get; set;}

#endregion
}
}