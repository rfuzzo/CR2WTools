using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskTornadoAttackDef : CBTTaskAttackDef
{
#region RED Properties

[REDProp("minCameraShakeStrength")]
public float MinCameraShakeStrength { get; set;}

[REDProp("maxCameraShakeStrength")]
public float MaxCameraShakeStrength { get; set;}

[REDProp("cameraShakeRange")]
public float CameraShakeRange { get; set;}

[REDProp("cameraShakeInterval")]
public float CameraShakeInterval { get; set;}

[REDProp("victimTestInterval")]
public float VictimTestInterval { get; set;}

[REDProp("debuffInterval")]
public float DebuffInterval { get; set;}

[REDProp("damageInterval")]
public float DamageInterval { get; set;}

[REDProp("damageMultiplier")]
public float DamageMultiplier { get; set;}

[REDProp("affectEnemiesInRangeMin")]
public float AffectEnemiesInRangeMin { get; set;}

[REDProp("affectEnemiesInRangeMax")]
public float AffectEnemiesInRangeMax { get; set;}

[REDProp("castingLoopTime")]
public float CastingLoopTime { get; set;}

[REDProp("setBehVarOnDeactivation")]
public CName SetBehVarOnDeactivation { get; set;}

[REDProp("setBehVarValueOnDeactivation")]
public float SetBehVarValueOnDeactivation { get; set;}

[REDProp("debuffTypeInRangeMin")]
public EEffectType DebuffTypeInRangeMin { get; set;}

[REDProp("rotateToNodeByTagOnDebuffMin")]
public CName RotateToNodeByTagOnDebuffMin { get; set;}

[REDProp("debuffTypeInRangeMax")]
public EEffectType DebuffTypeInRangeMax { get; set;}

[REDProp("debuffDurationInRangeMin")]
public float DebuffDurationInRangeMin { get; set;}

[REDProp("debuffDurationInRangeMax")]
public float DebuffDurationInRangeMax { get; set;}

[REDProp("activateOnAnimEvent")]
public CName ActivateOnAnimEvent { get; set;}

[REDProp("additionalFxOnDamageVictim")]
public CName AdditionalFxOnDamageVictim { get; set;}

#endregion
}
}