using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateSlide : CExplorationStateAbstract
{
#region RED Properties

[REDProp("subState")]
public ESlidingSubState SubState { get; set;}

[REDProp("enableWallSlide")]
public bool EnableWallSlide { get; set;}

[REDProp("useSmothedCoefOnIdle")]
public bool UseSmothedCoefOnIdle { get; set;}

[REDProp("angleMinDefault")]
public float AngleMinDefault { get; set;}

[REDProp("anglefMax")]
public float AnglefMax { get; set;}

[REDProp("coefExtraToStop")]
public float CoefExtraToStop { get; set;}

[REDProp("slideCoefRelatedToInput")]
public bool SlideCoefRelatedToInput { get; set;}

[REDProp("dotToStartForward")]
public float DotToStartForward { get; set;}

[REDProp("coefToStartBackward")]
public float CoefToStartBackward { get; set;}

[REDProp("coefToStartCenter")]
public float CoefToStartCenter { get; set;}

[REDProp("coefToStartForward")]
public float CoefToStartForward { get; set;}

[REDProp("useWideTerrainCheckToEnter")]
public bool UseWideTerrainCheckToEnter { get; set;}

[REDProp("updateMaterials")]
public bool UpdateMaterials { get; set;}

[REDProp("materialParams")]
public Array<SSlidingMaterialPresetParams> MaterialParams { get; set;}

[REDProp("materialNamesToPresets")]
public Array<SSlidingMaterialNamesToPresets> MaterialNamesToPresets { get; set;}

[REDProp("materialParamsDefaultN")]
public CName MaterialParamsDefaultN { get; set;}

[REDProp("materialDefault")]
public Int32 MaterialDefault { get; set;}

[REDProp("materialCurId")]
public Int32 MaterialCurId { get; set;}

[REDProp("materialNameCur")]
public CName MaterialNameCur { get; set;}

[REDProp("minTimeToIdle")]
public float MinTimeToIdle { get; set;}

[REDProp("orientingInitial")]
public float OrientingInitial { get; set;}

[REDProp("initialImpulse")]
public float InitialImpulse { get; set;}

[REDProp("startedFromJump")]
public bool StartedFromJump { get; set;}

[REDProp("startedFromRoll")]
public bool StartedFromRoll { get; set;}

[REDProp("orientingSpeedMin")]
public float OrientingSpeedMin { get; set;}

[REDProp("orientingSpeedMax")]
public float OrientingSpeedMax { get; set;}

[REDProp("orientingMaxSlope")]
public float OrientingMaxSlope { get; set;}

[REDProp("timeToHardSlide")]
public float TimeToHardSlide { get; set;}

[REDProp("behGraphEventSlideHard")]
public CName BehGraphEventSlideHard { get; set;}

[REDProp("requireSpeedToExit")]
public bool RequireSpeedToExit { get; set;}

[REDProp("speedToExitForward")]
public float SpeedToExitForward { get; set;}

[REDProp("speedToExitCenter")]
public float SpeedToExitCenter { get; set;}

[REDProp("speedToExitBackward")]
public float SpeedToExitBackward { get; set;}

[REDProp("exitingTimeMinSoft")]
public float ExitingTimeMinSoft { get; set;}

[REDProp("exitingTimeCur")]
public float ExitingTimeCur { get; set;}

[REDProp("exitingTimeTotal")]
public float ExitingTimeTotal { get; set;}

[REDProp("exitingTimeTotalInput")]
public float ExitingTimeTotalInput { get; set;}

[REDProp("stoppingFriction")]
public bool StoppingFriction { get; set;}

[REDProp("cooldownMax")]
public float CooldownMax { get; set;}

[REDProp("cooldownCur")]
public float CooldownCur { get; set;}

[REDProp("landCoolingDown")]
public bool LandCoolingDown { get; set;}

[REDProp("landCoolDownTime")]
public float LandCoolDownTime { get; set;}

[REDProp("fromJumpBehGraphEvent")]
public CName FromJumpBehGraphEvent { get; set;}

[REDProp("fromRollBehGraphEvent")]
public CName FromRollBehGraphEvent { get; set;}

[REDProp("jumpAllowed")]
public bool JumpAllowed { get; set;}

[REDProp("jumpCoolDownTime")]
public float JumpCoolDownTime { get; set;}

[REDProp("fallSpeedMaxConsidered")]
public float FallSpeedMaxConsidered { get; set;}

[REDProp("fallSpeedCoef")]
public float FallSpeedCoef { get; set;}

[REDProp("fallHorizImpulse")]
public float FallHorizImpulse { get; set;}

[REDProp("fallHorizImpulseCancel")]
public float FallHorizImpulseCancel { get; set;}

[REDProp("fallExtraVertImpulse")]
public float FallExtraVertImpulse { get; set;}

[REDProp("slidingPhysicsSpeed")]
public float SlidingPhysicsSpeed { get; set;}

[REDProp("movementParams")]
public SSlidingMovementParams MovementParams { get; set;}

[REDProp("movementStoppingParams")]
public SSlidingMovementParams MovementStoppingParams { get; set;}

[REDProp("usePhysics")]
public bool UsePhysics { get; set;}

[REDProp("slideDirectionDamped")]
public Vector SlideDirectionDamped { get; set;}

[REDProp("smoothedDirBlendCoef")]
public float SmoothedDirBlendCoef { get; set;}

[REDProp("slideKills")]
public bool SlideKills { get; set;}

[REDProp("m_DeadB")]
public bool M_DeadB { get; set;}

[REDProp("toFallEnabled")]
public bool ToFallEnabled { get; set;}

[REDProp("toFallTimeCur")]
public float ToFallTimeCur { get; set;}

[REDProp("toConsiderFallTimeTotal")]
public float ToConsiderFallTimeTotal { get; set;}

[REDProp("toFallTimeTotal")]
public float ToFallTimeTotal { get; set;}

[REDProp("toFallSlopeCoefMin")]
public float ToFallSlopeCoefMin { get; set;}

[REDProp("toFallSlopeSpeedMin")]
public float ToFallSlopeSpeedMin { get; set;}

[REDProp("toFallSlopeCoef")]
public float ToFallSlopeCoef { get; set;}

[REDProp("toFallSpeedCoef")]
public float ToFallSpeedCoef { get; set;}

[REDProp("toFallRecoverCoef")]
public float ToFallRecoverCoef { get; set;}

[REDProp("toFallCameraLevel")]
public Int32 ToFallCameraLevel { get; set;}

[REDProp("cameraShakeState")]
public ESlideCameraShakeState CameraShakeState { get; set;}

[REDProp("cameraAnimName")]
public CName CameraAnimName { get; set;}

[REDProp("behTripToDeath")]
public CName BehTripToDeath { get; set;}

[REDProp("behHeightVar")]
public CName BehHeightVar { get; set;}

[REDProp("behInclinationVar")]
public CName BehInclinationVar { get; set;}

[REDProp("behTurnVar")]
public CName BehTurnVar { get; set;}

[REDProp("behAccelVar")]
public CName BehAccelVar { get; set;}

[REDProp("behRightFootForwardVar")]
public CName BehRightFootForwardVar { get; set;}

[REDProp("inclinationBlendSpeed")]
public float InclinationBlendSpeed { get; set;}

[REDProp("inclinationStart")]
public float InclinationStart { get; set;}

[REDProp("turnInclinationMax")]
public float TurnInclinationMax { get; set;}

[REDProp("turnInclinationBlend")]
public float TurnInclinationBlend { get; set;}

[REDProp("turnInclinationCur")]
public float TurnInclinationCur { get; set;}

[REDProp("inclinationEnterTimeMax")]
public float InclinationEnterTimeMax { get; set;}

[REDProp("inclinationEnterTimeCur")]
public float InclinationEnterTimeCur { get; set;}

[REDProp("inclination")]
public float Inclination { get; set;}

[REDProp("behForwardVar")]
public CName BehForwardVar { get; set;}

[REDProp("behSlideRestart")]
public CName BehSlideRestart { get; set;}

[REDProp("behSlideEnd")]
public CName BehSlideEnd { get; set;}

[REDProp("behSlideEndRun")]
public CName BehSlideEndRun { get; set;}

[REDProp("behSlideEndIdle")]
public CName BehSlideEndIdle { get; set;}

[REDProp("boneToStickName")]
public CName BoneToStickName { get; set;}

[REDProp("boneToStickId")]
public Int32 BoneToStickId { get; set;}

[REDProp("animEventHardSliding")]
public CName AnimEventHardSliding { get; set;}

[REDProp("lockedOnHardSliding")]
public bool LockedOnHardSliding { get; set;}

[REDProp("particlesEnabled")]
public bool ParticlesEnabled { get; set;}

[REDProp("particlesName")]
public CName ParticlesName { get; set;}

[REDProp("boneLeftFoot")]
public CName BoneLeftFoot { get; set;}

[REDProp("boneRightFoot")]
public CName BoneRightFoot { get; set;}

[REDProp("timeToRespawnParticlesCur")]
public float TimeToRespawnParticlesCur { get; set;}

[REDProp("timeToRespawnParticlesMax")]
public float TimeToRespawnParticlesMax { get; set;}

#endregion
}
}