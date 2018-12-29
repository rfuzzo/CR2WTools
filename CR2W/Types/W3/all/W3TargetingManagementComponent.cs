using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TargetingManagementComponent : CSelfUpdatingComponent
{
#region RED Properties

[REDProp("aimVector")]
public Vector AimVector { get; set;}

[REDProp("iconOffset")]
public Vector IconOffset { get; set;}

[REDProp("aimVectorSlot")]
public CName AimVectorSlot { get; set;}

[REDProp("iconOffsetSlot")]
public CName IconOffsetSlot { get; set;}

[REDProp("updatePosition")]
public bool UpdatePosition { get; set;}

[REDProp("updateDelay")]
public float UpdateDelay { get; set;}

[REDProp("m_LastUpdate")]
public float M_LastUpdate { get; set;}

#endregion
}
}