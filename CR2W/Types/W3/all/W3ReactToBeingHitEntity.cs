using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ReactToBeingHitEntity : CGameplayEntity
{
#region RED Properties

[REDProp("reactsToSwords")]
public bool ReactsToSwords { get; set;}

[REDProp("reactsToBolts")]
public bool ReactsToBolts { get; set;}

[REDProp("deactivateOnHit")]
public bool DeactivateOnHit { get; set;}

[REDProp("dealDamage")]
public bool DealDamage { get; set;}

[REDProp("debuffType")]
public EEffectType DebuffType { get; set;}

[REDProp("debuffDuration")]
public float DebuffDuration { get; set;}

[REDProp("damageTypeName")]
public CName DamageTypeName { get; set;}

[REDProp("killOnHpBelowPerc")]
public float KillOnHpBelowPerc { get; set;}

[REDProp("setBehVarOnKill")]
public CName SetBehVarOnKill { get; set;}

[REDProp("behVarValue")]
public float BehVarValue { get; set;}

[REDProp("gameplayEventOnAttacker")]
public CName GameplayEventOnAttacker { get; set;}

[REDProp("effectOnActivation")]
public CName EffectOnActivation { get; set;}

[REDProp("durationEffect")]
public CName DurationEffect { get; set;}

[REDProp("effectOnHit")]
public CName EffectOnHit { get; set;}

[REDProp("effectOnHitVictim")]
public CName EffectOnHitVictim { get; set;}

[REDProp("activeDuration")]
public float ActiveDuration { get; set;}

[REDProp("active")]
public bool Active { get; set;}

[REDProp("attributeName")]
public CName AttributeName { get; set;}

#endregion
}
}