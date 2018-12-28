using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SR4PlayerTargetingIn 
{
#region RED Properties

[REDProp("canFindTarget")]
public bool CanFindTarget { get; set;}

[REDProp("playerHasBlockingBuffs")]
public bool PlayerHasBlockingBuffs { get; set;}

[REDProp("isHardLockedToTarget")]
public bool IsHardLockedToTarget { get; set;}

[REDProp("isActorLockedToTarget")]
public bool IsActorLockedToTarget { get; set;}

[REDProp("isCameraLockedToTarget")]
public bool IsCameraLockedToTarget { get; set;}

[REDProp("actionCheck")]
public bool ActionCheck { get; set;}

[REDProp("actionInput")]
public bool ActionInput { get; set;}

[REDProp("isInCombatAction")]
public bool IsInCombatAction { get; set;}

[REDProp("isLAxisReleased")]
public bool IsLAxisReleased { get; set;}

[REDProp("isLAxisReleasedAfterCounter")]
public bool IsLAxisReleasedAfterCounter { get; set;}

[REDProp("isLAxisReleasedAfterCounterNoCA")]
public bool IsLAxisReleasedAfterCounterNoCA { get; set;}

[REDProp("lastAxisInputIsMovement")]
public bool LastAxisInputIsMovement { get; set;}

[REDProp("isAiming")]
public bool IsAiming { get; set;}

[REDProp("isSwimming")]
public bool IsSwimming { get; set;}

[REDProp("isDiving")]
public bool IsDiving { get; set;}

[REDProp("isThreatened")]
public bool IsThreatened { get; set;}

[REDProp("isCombatMusicEnabled")]
public bool IsCombatMusicEnabled { get; set;}

[REDProp("isPcModeEnabled")]
public bool IsPcModeEnabled { get; set;}

[REDProp("shouldUsePcModeTargeting")]
public bool ShouldUsePcModeTargeting { get; set;}

[REDProp("isInParryOrCounter")]
public bool IsInParryOrCounter { get; set;}

[REDProp("bufferActionType")]
public EBufferActionType BufferActionType { get; set;}

[REDProp("orientationTarget")]
public EOrientationTarget OrientationTarget { get; set;}

[REDProp("coneDist")]
public float ConeDist { get; set;}

[REDProp("findMoveTargetDist")]
public float FindMoveTargetDist { get; set;}

[REDProp("cachedRawPlayerHeading")]
public float CachedRawPlayerHeading { get; set;}

[REDProp("combatActionHeading")]
public float CombatActionHeading { get; set;}

[REDProp("rawPlayerHeadingVector")]
public Vector RawPlayerHeadingVector { get; set;}

[REDProp("lookAtDirection")]
public Vector LookAtDirection { get; set;}

[REDProp("moveTarget")]
public Handle<CActor> MoveTarget { get; set;}

[REDProp("aimingTarget")]
public Handle<CActor> AimingTarget { get; set;}

[REDProp("displayTarget")]
public Handle<CActor> DisplayTarget { get; set;}

[REDProp("finishableEnemies")]
public Array<Handle<CActor>> FinishableEnemies { get; set;}

[REDProp("hostileEnemies")]
public Array<Handle<CActor>> HostileEnemies { get; set;}

[REDProp("defaultSelectionWeights")]
public STargetSelectionWeights DefaultSelectionWeights { get; set;}

#endregion
}
}