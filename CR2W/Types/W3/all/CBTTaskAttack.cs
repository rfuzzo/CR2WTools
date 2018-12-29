using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskAttack : CBTTaskPlayAnimationEventDecorator
{
#region RED Properties

[REDProp("attackType")]
public EAttackType AttackType { get; set;}

[REDProp("stopTaskAfterDealingDmg")]
public bool StopTaskAfterDealingDmg { get; set;}

[REDProp("setAttackEndVarOnStopTask")]
public bool SetAttackEndVarOnStopTask { get; set;}

[REDProp("useDirectionalAttacks")]
public bool UseDirectionalAttacks { get; set;}

[REDProp("fxOnDamageInstigated")]
public CName FxOnDamageInstigated { get; set;}

[REDProp("fxOnDamageVictim")]
public CName FxOnDamageVictim { get; set;}

[REDProp("soundEventOnDamageInstigated")]
public CName SoundEventOnDamageInstigated { get; set;}

[REDProp("soundEventOnDamageVictim")]
public CName SoundEventOnDamageVictim { get; set;}

[REDProp("applyFXCooldown")]
public float ApplyFXCooldown { get; set;}

[REDProp("behVarNameOnDeactivation")]
public CName BehVarNameOnDeactivation { get; set;}

[REDProp("behVarValueOnDeactivation")]
public float BehVarValueOnDeactivation { get; set;}

[REDProp("stopAllEfectsOnDeactivation")]
public bool StopAllEfectsOnDeactivation { get; set;}

[REDProp("slideToTargetOnAnimEvent")]
public bool SlideToTargetOnAnimEvent { get; set;}

[REDProp("slideToTargetMaximumDistance")]
public float SlideToTargetMaximumDistance { get; set;}

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

[REDProp("applyEffectType")]
public EEffectType ApplyEffectType { get; set;}

[REDProp("applyEffectTypeArray")]
public Array<EEffectType> ApplyEffectTypeArray { get; set;}

[REDProp("customEffectDuration")]
public float CustomEffectDuration { get; set;}

[REDProp("customEffectValue")]
public float CustomEffectValue { get; set;}

[REDProp("customEffectPercentValue")]
public float CustomEffectPercentValue { get; set;}

[REDProp("applyEffectInAttackRange")]
public CName ApplyEffectInAttackRange { get; set;}

[REDProp("hitDestructablesInAttackRange")]
public bool HitDestructablesInAttackRange { get; set;}

[REDProp("useActionBlend")]
public bool UseActionBlend { get; set;}

[REDProp("stopTaskOnCustomItemCollision")]
public bool StopTaskOnCustomItemCollision { get; set;}

[REDProp("spawnSparksFxOnCustomItemCollision")]
public CName SpawnSparksFxOnCustomItemCollision { get; set;}

[REDProp("resourceNameOfSparksFxEntity")]
public CName ResourceNameOfSparksFxEntity { get; set;}

[REDProp("unavailableWhenInvisibleTarget")]
public bool UnavailableWhenInvisibleTarget { get; set;}

[REDProp("effectCooldown")]
public float EffectCooldown { get; set;}

[REDProp("stopTask")]
public bool StopTask { get; set;}

[REDProp("fxTimeCooldown")]
public float FxTimeCooldown { get; set;}

[REDProp("damageInstigatedEventReceived")]
public bool DamageInstigatedEventReceived { get; set;}

[REDProp("hitActionReactionEventReceived")]
public bool HitActionReactionEventReceived { get; set;}

[REDProp("hitTimeStamp")]
public float HitTimeStamp { get; set;}

[REDProp("extractedMotionDisabled")]
public bool ExtractedMotionDisabled { get; set;}

#endregion
}
}