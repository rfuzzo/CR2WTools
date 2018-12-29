using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3WitchBoilingWaterObstacle : W3DurationObstacle
{
#region RED Properties

[REDProp("applyDebuffType")]
public EEffectType ApplyDebuffType { get; set;}

[REDProp("debuffDuration")]
public float DebuffDuration { get; set;}

[REDProp("simpleDamageAction")]
public bool SimpleDamageAction { get; set;}

[REDProp("damageValue")]
public float DamageValue { get; set;}

[REDProp("allowDmgValueOverrideFromXML")]
public bool AllowDmgValueOverrideFromXML { get; set;}

[REDProp("attackDelay")]
public float AttackDelay { get; set;}

[REDProp("attackRadius")]
public float AttackRadius { get; set;}

[REDProp("increaseRadiusDelta")]
public float IncreaseRadiusDelta { get; set;}

[REDProp("ignoreVictimWithTag")]
public CName IgnoreVictimWithTag { get; set;}

[REDProp("preAttackEffectName")]
public CName PreAttackEffectName { get; set;}

[REDProp("attackEffectName")]
public CName AttackEffectName { get; set;}

[REDProp("hitReactionType")]
public EHitReactionType HitReactionType { get; set;}

[REDProp("loopedAttack")]
public bool LoopedAttack { get; set;}

[REDProp("playAttackEffectOnlyWhenHit")]
public bool PlayAttackEffectOnlyWhenHit { get; set;}

[REDProp("useSeperateAttackEffectEntity")]
public Handle<CEntityTemplate> UseSeperateAttackEffectEntity { get; set;}

[REDProp("onAttackEffectCameraShakeStrength")]
public float OnAttackEffectCameraShakeStrength { get; set;}

[REDProp("onHitCameraShakeStrength")]
public float OnHitCameraShakeStrength { get; set;}

[REDProp("fxEntity")]
public Handle<CEntity> FxEntity { get; set;}

[REDProp("summoner")]
public Handle<CActor> Summoner { get; set;}

[REDProp("params")]
public SCustomEffectParams Params { get; set;}

[REDProp("effectComponent")]
public Handle<CComponent> EffectComponent { get; set;}

#endregion
}
}