using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskPlaySyncAnimAttack : CBTTaskAttack
{
#region RED Properties

[REDProp("useSetupSimpleSyncAnim2")]
public bool UseSetupSimpleSyncAnim2 { get; set;}

[REDProp("overrideAttackTypes")]
public bool OverrideAttackTypes { get; set;}

[REDProp("disableCollision")]
public bool DisableCollision { get; set;}

[REDProp("syncAttackAnims")]
public SSyncAttackTypes SyncAttackAnims { get; set;}

[REDProp("checkConditionsOnIsAvailable")]
public bool CheckConditionsOnIsAvailable { get; set;}

[REDProp("syncAnimNameLeftStance")]
public CName SyncAnimNameLeftStance { get; set;}

[REDProp("syncAnimNameRightStance")]
public CName SyncAnimNameRightStance { get; set;}

[REDProp("raiseForceIdle")]
public bool RaiseForceIdle { get; set;}

[REDProp("denyWhenTargetIsDodging")]
public bool DenyWhenTargetIsDodging { get; set;}

[REDProp("denyWhenTargetIsGuarded")]
public bool DenyWhenTargetIsGuarded { get; set;}

[REDProp("denyWhenTargetIsUsingQuen")]
public bool DenyWhenTargetIsUsingQuen { get; set;}

[REDProp("permitOnlyWhenTargetIsGuarded")]
public bool PermitOnlyWhenTargetIsGuarded { get; set;}

[REDProp("denyWhenCollidingWithVictirm")]
public bool DenyWhenCollidingWithVictirm { get; set;}

[REDProp("activateOnDistanceBelow")]
public float ActivateOnDistanceBelow { get; set;}

[REDProp("activateOnDistanceAbove")]
public float ActivateOnDistanceAbove { get; set;}

[REDProp("activateOnAngleBelow")]
public float ActivateOnAngleBelow { get; set;}

[REDProp("checkMoveType")]
public bool CheckMoveType { get; set;}

[REDProp("activateOnGreaterEqualMoveType")]
public EMoveType ActivateOnGreaterEqualMoveType { get; set;}

[REDProp("zTolerance")]
public float ZTolerance { get; set;}

[REDProp("denyIfTargetNotPlayer")]
public bool DenyIfTargetNotPlayer { get; set;}

[REDProp("onAnimEvent")]
public CName OnAnimEvent { get; set;}

[REDProp("onGameplayEvent")]
public CName OnGameplayEvent { get; set;}

[REDProp("completeOnMainEnd")]
public bool CompleteOnMainEnd { get; set;}

[REDProp("activated")]
public bool Activated { get; set;}

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

[REDProp("target")]
public Handle<CActor> Target { get; set;}

[REDProp("component")]
public Handle<CAnimatedComponent> Component { get; set;}

#endregion
}
}