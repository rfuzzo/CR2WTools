using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskChargeDef : CBTTaskAttackDef
{
#region RED Properties

[REDProp("raiseEventOnActivation")]
public CName RaiseEventOnActivation { get; set;}

[REDProp("raiseEventOnObstacleCollision")]
public CName RaiseEventOnObstacleCollision { get; set;}

[REDProp("handleCollisionWithObstacle")]
public bool HandleCollisionWithObstacle { get; set;}

[REDProp("checkLineOfSight")]
public bool CheckLineOfSight { get; set;}

[REDProp("dealDamage")]
public bool DealDamage { get; set;}

[REDProp("endTaskWhenOwnerGoesPastTarget")]
public bool EndTaskWhenOwnerGoesPastTarget { get; set;}

[REDProp("chargeType")]
public EChargeAttackType ChargeType { get; set;}

[REDProp("forceCriticalEffect")]
public bool ForceCriticalEffect { get; set;}

[REDProp("forceCriticalEffectNpcOnly")]
public bool ForceCriticalEffectNpcOnly { get; set;}

#endregion
}
}