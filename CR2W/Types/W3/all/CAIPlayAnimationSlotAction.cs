using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIPlayAnimationSlotAction : IAIActionTree
{
#region RED Properties

[REDProp("animName")]
public CName AnimName { get; set;}

[REDProp("slotName")]
public CName SlotName { get; set;}

[REDProp("blendInTime")]
public float BlendInTime { get; set;}

[REDProp("blendOutTime")]
public float BlendOutTime { get; set;}

#endregion
}
}