using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3DamageAction : CDamageData
{
#region RED Properties

[REDProp("dmgInfos")]
public Array<SRawDamage> DmgInfos { get; set;}

[REDProp("effectInfos")]
public Array<SEffectInfo> EffectInfos { get; set;}

[REDProp("cannotReturnDamage")]
public bool CannotReturnDamage { get; set;}

[REDProp("isPointResistIgnored")]
public bool IsPointResistIgnored { get; set;}

[REDProp("canPlayHitParticle")]
public bool CanPlayHitParticle { get; set;}

[REDProp("hitAnimationPlayType")]
public EActionHitAnim HitAnimationPlayType { get; set;}

[REDProp("hitReactionType")]
public EHitReactionType HitReactionType { get; set;}

[REDProp("buffSourceName")]
public string BuffSourceName { get; set;}

[REDProp("canBeParried")]
public bool CanBeParried { get; set;}

[REDProp("canBeDodged")]
public bool CanBeDodged { get; set;}

[REDProp("hitFX")]
public CName HitFX { get; set;}

[REDProp("hitBackFX")]
public CName HitBackFX { get; set;}

[REDProp("hitParriedFX")]
public CName HitParriedFX { get; set;}

[REDProp("hitBackParriedFX")]
public CName HitBackParriedFX { get; set;}

[REDProp("powerStatType")]
public ECharacterPowerStats PowerStatType { get; set;}

[REDProp("swingType")]
public EAttackSwingType SwingType { get; set;}

[REDProp("swingDirection")]
public EAttackSwingDirection SwingDirection { get; set;}

[REDProp("signSkill")]
public ESkill SignSkill { get; set;}

[REDProp("isDodged")]
public bool IsDodged { get; set;}

[REDProp("shouldProcessBuffsIfNoDamage")]
public bool ShouldProcessBuffsIfNoDamage { get; set;}

[REDProp("ignoreImmortalityMode")]
public bool IgnoreImmortalityMode { get; set;}

[REDProp("dealtFireDamage")]
public bool DealtFireDamage { get; set;}

[REDProp("isHeadShot")]
public bool IsHeadShot { get; set;}

[REDProp("killedBySingleHit")]
public bool KilledBySingleHit { get; set;}

[REDProp("ignoreArmor")]
public bool IgnoreArmor { get; set;}

[REDProp("supressHitSounds")]
public bool SupressHitSounds { get; set;}

[REDProp("dealtDamage")]
public bool DealtDamage { get; set;}

[REDProp("endsQuen")]
public bool EndsQuen { get; set;}

[REDProp("armorReducedDamageToZero")]
public bool ArmorReducedDamageToZero { get; set;}

[REDProp("underwaterDisplayDamageHack")]
public bool UnderwaterDisplayDamageHack { get; set;}

[REDProp("parryStagger")]
public bool ParryStagger { get; set;}

[REDProp("bouncedArrow")]
public bool BouncedArrow { get; set;}

[REDProp("forceExplosionDismemberment")]
public bool ForceExplosionDismemberment { get; set;}

[REDProp("isCriticalHit")]
public bool IsCriticalHit { get; set;}

[REDProp("instantKill")]
public bool InstantKill { get; set;}

[REDProp("instantKillFloater")]
public bool InstantKillFloater { get; set;}

[REDProp("instantKillCooldownIgnore")]
public bool InstantKillCooldownIgnore { get; set;}

[REDProp("wasFrozen")]
public bool WasFrozen { get; set;}

[REDProp("mutation4Triggered")]
public bool Mutation4Triggered { get; set;}

[REDProp("didReturnDamageToAttacker")]
public bool DidReturnDamageToAttacker { get; set;}

[REDProp("DOTdt")]
public float DOTdt { get; set;}

[REDProp("isActionRanged")]
public bool IsActionRanged { get; set;}

[REDProp("isActionWitcherSign")]
public bool IsActionWitcherSign { get; set;}

[REDProp("isActionEnvironment")]
public bool IsActionEnvironment { get; set;}

#endregion
}
}