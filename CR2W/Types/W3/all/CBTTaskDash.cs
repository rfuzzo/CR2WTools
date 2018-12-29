using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskDash : IBehTreeTask
{
#region RED Properties

[REDProp("slideBehindTarget")]
public bool SlideBehindTarget { get; set;}

[REDProp("destinationOffset")]
public float DestinationOffset { get; set;}

[REDProp("disableCollision")]
public bool DisableCollision { get; set;}

[REDProp("dealDamageOnContact")]
public bool DealDamageOnContact { get; set;}

[REDProp("damageVal")]
public float DamageVal { get; set;}

[REDProp("sideStepDist")]
public float SideStepDist { get; set;}

[REDProp("sideStepHeadingOffset")]
public float SideStepHeadingOffset { get; set;}

[REDProp("disableGameplayVisibility")]
public bool DisableGameplayVisibility { get; set;}

[REDProp("sendRotationEventAboveDashDist")]
public float SendRotationEventAboveDashDist { get; set;}

[REDProp("isSliding")]
public bool IsSliding { get; set;}

[REDProp("hitEntities")]
public Array<Handle<CEntity>> HitEntities { get; set;}

[REDProp("collisionGroupsNames")]
public Array<CName> CollisionGroupsNames { get; set;}

#endregion
}
}