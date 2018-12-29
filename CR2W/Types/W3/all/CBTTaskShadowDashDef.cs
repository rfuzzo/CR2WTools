using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskShadowDashDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("slideSpeed")]
public float SlideSpeed { get; set;}

[REDProp("slideBehindTarget")]
public bool SlideBehindTarget { get; set;}

[REDProp("distanceOffset")]
public float DistanceOffset { get; set;}

[REDProp("disableCollision")]
public bool DisableCollision { get; set;}

[REDProp("dealDamageOnContact")]
public bool DealDamageOnContact { get; set;}

[REDProp("damageVal")]
public float DamageVal { get; set;}

[REDProp("maxDist")]
public float MaxDist { get; set;}

[REDProp("sideStepDist")]
public float SideStepDist { get; set;}

[REDProp("sideStepHeadingOffset")]
public float SideStepHeadingOffset { get; set;}

[REDProp("minDuration")]
public float MinDuration { get; set;}

[REDProp("maxDuration")]
public float MaxDuration { get; set;}

[REDProp("slideBlendInTime")]
public float SlideBlendInTime { get; set;}

[REDProp("disableGameplayVisibility")]
public bool DisableGameplayVisibility { get; set;}

#endregion
}
}