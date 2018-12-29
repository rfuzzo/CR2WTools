using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ReplacerCiriStateCombatSword : CR4PlayerStateCombat
{
#region RED Properties

[REDProp("specialAttackHeading")]
public float SpecialAttackHeading { get; set;}

[REDProp("completeSpecialAttackDist")]
public float CompleteSpecialAttackDist { get; set;}

[REDProp("specialAttackStartTimeStamp")]
public float SpecialAttackStartTimeStamp { get; set;}

[REDProp("isCompletingSpecialAttack")]
public bool IsCompletingSpecialAttack { get; set;}

[REDProp("specialAttackSphere")]
public Handle<CMeshComponent> SpecialAttackSphere { get; set;}

[REDProp("specialAttackSphereEnt")]
public Handle<CEntity> SpecialAttackSphereEnt { get; set;}

[REDProp("specialAttackEffectTemplate")]
public Handle<CEntityTemplate> SpecialAttackEffectTemplate { get; set;}

[REDProp("ciriPhantomTemplate")]
public Handle<CEntityTemplate> CiriPhantomTemplate { get; set;}

[REDProp("ciriGhostFxTemplate")]
public Handle<CEntityTemplate> CiriGhostFxTemplate { get; set;}

[REDProp("buttonWasHeld")]
public bool ButtonWasHeld { get; set;}

[REDProp("specialAttackRadius")]
public float SpecialAttackRadius { get; set;}

[REDProp("specialAttackInterrupted")]
public bool SpecialAttackInterrupted { get; set;}

[REDProp("HOLD_SPECIAL_ATTACK_BUTTON_TIME")]
public float HOLD_SPECIAL_ATTACK_BUTTON_TIME { get; set;}

[REDProp("ATTACK_RADIUS_INITIAL_VAL")]
public float ATTACK_RADIUS_INITIAL_VAL { get; set;}

[REDProp("ATTACK_RADIUS_MAXIMUM_VAL")]
public float ATTACK_RADIUS_MAXIMUM_VAL { get; set;}

[REDProp("ATTACK_RADIUS_INCREASE_SPEED")]
public float ATTACK_RADIUS_INCREASE_SPEED { get; set;}

[REDProp("SPECIAL_ATTACK_MAX_TARGETS")]
public Int32 SPECIAL_ATTACK_MAX_TARGETS { get; set;}

[REDProp("DODGE_DISTANCE")]
public float DODGE_DISTANCE { get; set;}

[REDProp("DASH_DISTANCE")]
public float DASH_DISTANCE { get; set;}

[REDProp("SPECIAL_ATTACK_HEAVY_MAX_DIST")]
public float SPECIAL_ATTACK_HEAVY_MAX_DIST { get; set;}

[REDProp("teleportToLastPos")]
public bool TeleportToLastPos { get; set;}

[REDProp("lastTarget")]
public Handle<CActor> LastTarget { get; set;}

[REDProp("_distances")]
public Array<float> _distances { get; set;}

[REDProp("_vectors")]
public Array<Vector> _vectors { get; set;}

[REDProp("attackAnimsListLP")]
public Array<CName> AttackAnimsListLP { get; set;}

[REDProp("attackAnimsListRP")]
public Array<CName> AttackAnimsListRP { get; set;}

#endregion
}
}