using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskGroundTrapAttack : CBTTaskAttack
{
#region RED Properties

[REDProp("allowDamageSelf")]
public bool AllowDamageSelf { get; set;}

[REDProp("guaranteeSelfHitChance")]
public float GuaranteeSelfHitChance { get; set;}

[REDProp("randomizePosition")]
public bool RandomizePosition { get; set;}

[REDProp("guaranteeTargetHitChance")]
public float GuaranteeTargetHitChance { get; set;}

[REDProp("guaranteeToHitEntityWithTag")]
public float GuaranteeToHitEntityWithTag { get; set;}

[REDProp("entityTag")]
public CName EntityTag { get; set;}

[REDProp("preferTargetsInCameraFrame")]
public bool PreferTargetsInCameraFrame { get; set;}

[REDProp("navigationSafeSpotRadius")]
public float NavigationSafeSpotRadius { get; set;}

[REDProp("minDistFromTarget")]
public float MinDistFromTarget { get; set;}

[REDProp("maxDistFromTarget")]
public float MaxDistFromTarget { get; set;}

[REDProp("camShakeStrength")]
public float CamShakeStrength { get; set;}

[REDProp("activateOnAnimEvent")]
public CName ActivateOnAnimEvent { get; set;}

[REDProp("affectEnemiesInRange")]
public float AffectEnemiesInRange { get; set;}

[REDProp("damageTypeName")]
public CName DamageTypeName { get; set;}

[REDProp("delayDamage")]
public float DelayDamage { get; set;}

[REDProp("debuffType")]
public EEffectType DebuffType { get; set;}

[REDProp("raiseEventOnDamageNPC")]
public CName RaiseEventOnDamageNPC { get; set;}

[REDProp("debuffDuration")]
public float DebuffDuration { get; set;}

[REDProp("trapResourceName")]
public CName TrapResourceName { get; set;}

[REDProp("playFxOnTrapSpawn")]
public CName PlayFxOnTrapSpawn { get; set;}

[REDProp("playFxDamage")]
public CName PlayFxDamage { get; set;}

[REDProp("delayDamageFx")]
public float DelayDamageFx { get; set;}

[REDProp("playFxOnDamageVictim")]
public CName PlayFxOnDamageVictim { get; set;}

[REDProp("completeAfterMain")]
public bool CompleteAfterMain { get; set;}

[REDProp("onActivateFromTaskAttack")]
public bool OnActivateFromTaskAttack { get; set;}

[REDProp("m_trapEntity")]
public Handle<CEntityTemplate> M_trapEntity { get; set;}

[REDProp("m_trap")]
public Handle<CGameplayEntity> M_trap { get; set;}

[REDProp("m_activated")]
public bool M_activated { get; set;}

[REDProp("guaranteedHit")]
public bool GuaranteedHit { get; set;}

#endregion
}
}