using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskCollisionMonitorDef : CBTTaskPlayAnimationEventDecoratorDef
{
#region RED Properties

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onAnimEvent")]
public bool OnAnimEvent { get; set;}

[REDProp("dealDamage")]
public bool DealDamage { get; set;}

[REDProp("destroyObstacleOnCollision")]
public bool DestroyObstacleOnCollision { get; set;}

[REDProp("chargeType")]
public EChargeAttackType ChargeType { get; set;}

[REDProp("forceCriticalEffect")]
public bool ForceCriticalEffect { get; set;}

[REDProp("forceCriticalEffectNpcOnly")]
public bool ForceCriticalEffectNpcOnly { get; set;}

[REDProp("raiseEventOnObstacleCollision")]
public CName RaiseEventOnObstacleCollision { get; set;}

[REDProp("soundEventOnCollidedActor")]
public CName SoundEventOnCollidedActor { get; set;}

[REDProp("completeOnCollisionWithObstacle")]
public bool CompleteOnCollisionWithObstacle { get; set;}

[REDProp("unavailableForOneFrameOnInterval")]
public float UnavailableForOneFrameOnInterval { get; set;}

#endregion
}
}