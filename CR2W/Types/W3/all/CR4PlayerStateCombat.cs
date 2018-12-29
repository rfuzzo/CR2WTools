using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4PlayerStateCombat : CR4PlayerStateExtendedMovable
{
#region RED Properties

[REDProp("comboDefinition")]
public Handle<CComboDefinition> ComboDefinition { get; set;}

[REDProp("comboPlayer")]
public Handle<CComboPlayer> ComboPlayer { get; set;}

[REDProp("updatePosition")]
public bool UpdatePosition { get; set;}

[REDProp("bIsSwitchingDirection")]
public bool BIsSwitchingDirection { get; set;}

[REDProp("currentWeapon")]
public EPlayerWeapon CurrentWeapon { get; set;}

[REDProp("comboAttackA_Id")]
public Int32 ComboAttackA_Id { get; set;}

[REDProp("comboAttackA_Target")]
public Handle<CGameplayEntity> ComboAttackA_Target { get; set;}

[REDProp("comboAttackA_Sliding")]
public bool ComboAttackA_Sliding { get; set;}

[REDProp("comboAttackB_Id")]
public Int32 ComboAttackB_Id { get; set;}

[REDProp("comboAttackB_Target")]
public Handle<CGameplayEntity> ComboAttackB_Target { get; set;}

[REDProp("comboAttackB_Sliding")]
public bool ComboAttackB_Sliding { get; set;}

[REDProp("comboAspectName")]
public CName ComboAspectName { get; set;}

[REDProp("enemiesInRange")]
public Array<Handle<CActor>> EnemiesInRange { get; set;}

[REDProp("positionWeightsDest")]
public Array<float> PositionWeightsDest { get; set;}

[REDProp("positionWeights")]
public Array<float> PositionWeights { get; set;}

[REDProp("positionVelocity")]
public Array<float> PositionVelocity { get; set;}

[REDProp("positionWeightDamper")]
public Handle<SpringDamper> PositionWeightDamper { get; set;}

[REDProp("dodgeDirection")]
public EPlayerEvadeDirection DodgeDirection { get; set;}

[REDProp("zoomOutForApproachingAttacker")]
public bool ZoomOutForApproachingAttacker { get; set;}

[REDProp("slideDistanceOffset")]
public float SlideDistanceOffset { get; set;}

[REDProp("startupAction")]
public EInitialAction StartupAction { get; set;}

[REDProp("startupBuff")]
public Handle<CBaseGameplayEffect> StartupBuff { get; set;}

[REDProp("isInCriticalState")]
public bool IsInCriticalState { get; set;}

[REDProp("realCombat")]
public bool RealCombat { get; set;}

[REDProp("lastVitality")]
public float LastVitality { get; set;}

[REDProp("timeToCheckCombatEndCur")]
public float TimeToCheckCombatEndCur { get; set;}

[REDProp("timeToCheckCombatEndMax")]
public float TimeToCheckCombatEndMax { get; set;}

[REDProp("timeToExitCombatFromSprinting")]
public float TimeToExitCombatFromSprinting { get; set;}

[REDProp("cFMCameraZoomIsEnabled")]
public bool CFMCameraZoomIsEnabled { get; set;}

[REDProp("cachedStance")]
public EPlayerCombatStance CachedStance { get; set;}

[REDProp("disableCombatStanceTimer")]
public bool DisableCombatStanceTimer { get; set;}

[REDProp("evadeTarget")]
public Handle<CActor> EvadeTarget { get; set;}

[REDProp("wasLockedToTarget")]
public bool WasLockedToTarget { get; set;}

[REDProp("angle")]
public float Angle { get; set;}

[REDProp("cachedDodgeDirection")]
public EPlayerEvadeDirection CachedDodgeDirection { get; set;}

[REDProp("prevRawLeftJoyRot")]
public float PrevRawLeftJoyRot { get; set;}

[REDProp("evadeTargetPos")]
public Vector EvadeTargetPos { get; set;}

[REDProp("cachedRawDodgeHeading")]
public float CachedRawDodgeHeading { get; set;}

[REDProp("turnInPlaceBeforeDodge")]
public bool TurnInPlaceBeforeDodge { get; set;}

[REDProp("dodgePlaylistFwd")]
public Array<float> DodgePlaylistFwd { get; set;}

[REDProp("dodgePlaylistFlipFwd")]
public Array<float> DodgePlaylistFlipFwd { get; set;}

[REDProp("dodgePlaylistBck")]
public Array<float> DodgePlaylistBck { get; set;}

[REDProp("cachedPlayerAttackType")]
public CName CachedPlayerAttackType { get; set;}

[REDProp("farAttackMinDist")]
public float FarAttackMinDist { get; set;}

[REDProp("previousSlideTarget")]
public Handle<CGameplayEntity> PreviousSlideTarget { get; set;}

[REDProp("finisherDist")]
public float FinisherDist { get; set;}

[REDProp("isOnHighSlope")]
public bool IsOnHighSlope { get; set;}

[REDProp("prevPlayerToTargetDist")]
public float PrevPlayerToTargetDist { get; set;}

[REDProp("wasDecreasing")]
public bool WasDecreasing { get; set;}

[REDProp("enableSoftLock")]
public bool EnableSoftLock { get; set;}

[REDProp("wasInCloseCombat")]
public bool WasInCloseCombat { get; set;}

[REDProp("ticketRequests")]
public Array<Int32> TicketRequests { get; set;}

[REDProp("ticketNames")]
public Array<CName> TicketNames { get; set;}

#endregion
}
}