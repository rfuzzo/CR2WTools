using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskCollisionMonitor : CBTTaskPlayAnimationEventDecorator
{
#region RED Properties

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onAnimEvent")]
public bool OnAnimEvent { get; set;}

[REDProp("dealDamage")]
public bool DealDamage { get; set;}

[REDProp("soundEventOnCollidedActor")]
public CName SoundEventOnCollidedActor { get; set;}

[REDProp("destroyObstacleOnCollision")]
public bool DestroyObstacleOnCollision { get; set;}

[REDProp("raiseEventOnObstacleCollision")]
public CName RaiseEventOnObstacleCollision { get; set;}

[REDProp("chargeType")]
public EChargeAttackType ChargeType { get; set;}

[REDProp("forceCriticalEffect")]
public bool ForceCriticalEffect { get; set;}

[REDProp("forceCriticalEffectNpcOnly")]
public bool ForceCriticalEffectNpcOnly { get; set;}

[REDProp("completeOnCollisionWithObstacle")]
public bool CompleteOnCollisionWithObstacle { get; set;}

[REDProp("unavailableForOneFrameOnInterval")]
public float UnavailableForOneFrameOnInterval { get; set;}

[REDProp("bCollisionWithActor")]
public bool BCollisionWithActor { get; set;}

[REDProp("bCollisionWithObstacle")]
public bool BCollisionWithObstacle { get; set;}

[REDProp("bCollisionWithObstacleProbe")]
public bool BCollisionWithObstacleProbe { get; set;}

[REDProp("activated")]
public bool Activated { get; set;}

[REDProp("xmlDamageName")]
public CName XmlDamageName { get; set;}

[REDProp("collidedActor")]
public Handle<CActor> CollidedActor { get; set;}

[REDProp("collidedEntity")]
public Handle<CGameplayEntity> CollidedEntity { get; set;}

[REDProp("collidedProbedEntity")]
public Handle<CGameplayEntity> CollidedProbedEntity { get; set;}

[REDProp("activationTimeStamp")]
public float ActivationTimeStamp { get; set;}

[REDProp("actorCollisionTimeStamp")]
public float ActorCollisionTimeStamp { get; set;}

[REDProp("objectCollisionTimeStamp")]
public float ObjectCollisionTimeStamp { get; set;}

[REDProp("objectProbeCollisionTimeStamp")]
public float ObjectProbeCollisionTimeStamp { get; set;}

[REDProp("intervalCheckTimeStamp")]
public float IntervalCheckTimeStamp { get; set;}

[REDProp("hadForceCriticalStates")]
public bool HadForceCriticalStates { get; set;}

#endregion
}
}