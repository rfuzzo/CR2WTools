using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateClimb : CExplorationStateAbstract
{
#region RED Properties

[REDProp("m_ClimbOracleO")]
public Handle<CExplorationClimbOracle> M_ClimbOracleO { get; set;}

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("climbTypes")]
public Array<CClimbType> ClimbTypes { get; set;}

[REDProp("climbCur")]
public CClimbType ClimbCur { get; set;}

[REDProp("heightMaxToRun")]
public float HeightMaxToRun { get; set;}

[REDProp("platformHeightMinAir")]
public float PlatformHeightMinAir { get; set;}

[REDProp("platformHeightMin")]
public float PlatformHeightMin { get; set;}

[REDProp("climbPoint")]
public Vector ClimbPoint { get; set;}

[REDProp("wallNormal")]
public Vector WallNormal { get; set;}

[REDProp("heightTarget")]
public float HeightTarget { get; set;}

[REDProp("vaultingFound")]
public EClimbRequirementVault VaultingFound { get; set;}

[REDProp("platformFound")]
public EClimbRequirementPlatform PlatformFound { get; set;}

[REDProp("curPlayerStateType")]
public EClimbRequirementType CurPlayerStateType { get; set;}

[REDProp("vaultEndsFalling")]
public bool VaultEndsFalling { get; set;}

[REDProp("ended")]
public bool Ended { get; set;}

[REDProp("canWalk")]
public bool CanWalk { get; set;}

[REDProp("canRun")]
public bool CanRun { get; set;}

[REDProp("canFall")]
public bool CanFall { get; set;}

[REDProp("animDurationLimit")]
public float AnimDurationLimit { get; set;}

[REDProp("slideDistMaxOnRun")]
public float SlideDistMaxOnRun { get; set;}

[REDProp("autoClimb")]
public bool AutoClimb { get; set;}

[REDProp("autoClimbOnAir")]
public bool AutoClimbOnAir { get; set;}

[REDProp("inputAngleToEnter")]
public float InputAngleToEnter { get; set;}

[REDProp("inputAngleToRun")]
public float InputAngleToRun { get; set;}

[REDProp("inputAttemptsTop")]
public bool InputAttemptsTop { get; set;}

[REDProp("inputDirection")]
public Vector InputDirection { get; set;}

[REDProp("inputAirHold")]
public bool InputAirHold { get; set;}

[REDProp("inputAirTimeGap")]
public bool InputAirTimeGap { get; set;}

[REDProp("inputTimeGapCheck")]
public float InputTimeGapCheck { get; set;}

[REDProp("characterRadius")]
public float CharacterRadius { get; set;}

[REDProp("adjustInitiallRotat")]
public float AdjustInitiallRotat { get; set;}

[REDProp("adjustRotation")]
public float AdjustRotation { get; set;}

[REDProp("adjustTranslation")]
public Vector AdjustTranslation { get; set;}

[REDProp("adjustInitialRotDone")]
public bool AdjustInitialRotDone { get; set;}

[REDProp("adjustRotDone")]
public bool AdjustRotDone { get; set;}

[REDProp("adjustTransDone")]
public bool AdjustTransDone { get; set;}

[REDProp("adjustSpeedMax")]
public float AdjustSpeedMax { get; set;}

[REDProp("adjustSpeedRequire")]
public bool AdjustSpeedRequire { get; set;}

[REDProp("adjustSpeedEndTime")]
public float AdjustSpeedEndTime { get; set;}

[REDProp("adjust2Dduration")]
public float Adjust2Dduration { get; set;}

[REDProp("adjust2Speed")]
public float Adjust2Speed { get; set;}

[REDProp("adjust2Translation")]
public Vector Adjust2Translation { get; set;}

[REDProp("heightToAdd")]
public float HeightToAdd { get; set;}

[REDProp("pelvisTransMax")]
public float PelvisTransMax { get; set;}

[REDProp("pelvisTransAllow")]
public bool PelvisTransAllow { get; set;}

[REDProp("pelvisTransState")]
public EOutsideCapsuleState PelvisTransState { get; set;}

[REDProp("pelvisTranslationN")]
public CName PelvisTranslationN { get; set;}

[REDProp("pelvisTransCur")]
public float PelvisTransCur { get; set;}

[REDProp("pelvisTransTarget")]
public float PelvisTransTarget { get; set;}

[REDProp("pelvisTransSpeed")]
public float PelvisTransSpeed { get; set;}

[REDProp("pelvisTransSpeedOut")]
public float PelvisTransSpeedOut { get; set;}

[REDProp("behAnimAdjustInitRot")]
public CName BehAnimAdjustInitRot { get; set;}

[REDProp("behAnimAdjustRot")]
public CName BehAnimAdjustRot { get; set;}

[REDProp("behAnimAdjustTrans")]
public CName BehAnimAdjustTrans { get; set;}

[REDProp("behAnimEnded")]
public CName BehAnimEnded { get; set;}

[REDProp("behAnimCanWalk")]
public CName BehAnimCanWalk { get; set;}

[REDProp("behAnimCanRun")]
public CName BehAnimCanRun { get; set;}

[REDProp("behAnimCanFall")]
public CName BehAnimCanFall { get; set;}

[REDProp("behEnableIK")]
public CName BehEnableIK { get; set;}

[REDProp("behDisablePelvisTrans")]
public CName BehDisablePelvisTrans { get; set;}

[REDProp("behEnableHandsIK")]
public CName BehEnableHandsIK { get; set;}

[REDProp("behEnableHandLIK")]
public CName BehEnableHandLIK { get; set;}

[REDProp("behEnableHandRIK")]
public CName BehEnableHandRIK { get; set;}

[REDProp("behDisableHandsIK")]
public CName BehDisableHandsIK { get; set;}

[REDProp("behDisableHandLIK")]
public CName BehDisableHandLIK { get; set;}

[REDProp("behDisableHandRIK")]
public CName BehDisableHandRIK { get; set;}

[REDProp("behHeightTypeEnum")]
public CName BehHeightTypeEnum { get; set;}

[REDProp("behVaultTypeEnum")]
public CName BehVaultTypeEnum { get; set;}

[REDProp("behPlatformTypeEnum")]
public CName BehPlatformTypeEnum { get; set;}

[REDProp("behStateTypeEnum")]
public CName BehStateTypeEnum { get; set;}

[REDProp("behGoToRun")]
public CName BehGoToRun { get; set;}

[REDProp("behGoToWalk")]
public CName BehGoToWalk { get; set;}

[REDProp("behToRun")]
public CName BehToRun { get; set;}

[REDProp("behVarEnd")]
public CName BehVarEnd { get; set;}

[REDProp("behAnimSpeed")]
public CName BehAnimSpeed { get; set;}

[REDProp("continousHandIK")]
public bool ContinousHandIK { get; set;}

[REDProp("handIKMinDistToEnable")]
public float HandIKMinDistToEnable { get; set;}

[REDProp("handIKMaxDist")]
public float HandIKMaxDist { get; set;}

[REDProp("handIKForwardOffset")]
public float HandIKForwardOffset { get; set;}

[REDProp("handIKHalfMaxHeight")]
public float HandIKHalfMaxHeight { get; set;}

[REDProp("handIKBlendSpeedIn")]
public float HandIKBlendSpeedIn { get; set;}

[REDProp("handIKBlendSpeedOut")]
public float HandIKBlendSpeedOut { get; set;}

[REDProp("handThickness")]
public float HandThickness { get; set;}

[REDProp("boneRightHand")]
public CName BoneRightHand { get; set;}

[REDProp("boneLeftHand")]
public CName BoneLeftHand { get; set;}

[REDProp("boneIndexRightHand")]
public Int32 BoneIndexRightHand { get; set;}

[REDProp("boneIndexLeftHand")]
public Int32 BoneIndexLeftHand { get; set;}

[REDProp("rightHandOffset")]
public float RightHandOffset { get; set;}

[REDProp("leftHandOffset")]
public float LeftHandOffset { get; set;}

[REDProp("rightHandOffsetCur")]
public float RightHandOffsetCur { get; set;}

[REDProp("leftHandOffsetCur")]
public float LeftHandOffsetCur { get; set;}

[REDProp("handIKEnabled")]
public bool HandIKEnabled { get; set;}

[REDProp("handIKEnabledLeft")]
public bool HandIKEnabledLeft { get; set;}

[REDProp("handIKEnabledRight")]
public bool HandIKEnabledRight { get; set;}

[REDProp("handIKqueuedL")]
public bool HandIKqueuedL { get; set;}

[REDProp("handIKqueuedR")]
public bool HandIKqueuedR { get; set;}

[REDProp("handIKLRayOrigin")]
public Vector HandIKLRayOrigin { get; set;}

[REDProp("handIKLRayEnd")]
public Vector HandIKLRayEnd { get; set;}

[REDProp("handIKLRayCollision")]
public Vector HandIKLRayCollision { get; set;}

[REDProp("handIKRRayOrigin")]
public Vector HandIKRRayOrigin { get; set;}

[REDProp("handIKRRayEnd")]
public Vector HandIKRRayEnd { get; set;}

[REDProp("handIKRRayCollision")]
public Vector HandIKRRayCollision { get; set;}

[REDProp("collisionObstaclesNames")]
public Array<CName> CollisionObstaclesNames { get; set;}

[REDProp("cameraSetVault")]
public Handle<CCameraParametersSet> CameraSetVault { get; set;}

[REDProp("cameraSetJump")]
public Handle<CCameraParametersSet> CameraSetJump { get; set;}

[REDProp("updateCameraManual")]
public bool UpdateCameraManual { get; set;}

[REDProp("updateCameraAnim")]
public bool UpdateCameraAnim { get; set;}

[REDProp("camOriginalPosition")]
public Vector CamOriginalPosition { get; set;}

[REDProp("camOriginalRotation")]
public EulerAngles CamOriginalRotation { get; set;}

[REDProp("camCurRotation")]
public EulerAngles CamCurRotation { get; set;}

[REDProp("camOriginalOffset")]
public Vector CamOriginalOffset { get; set;}

[REDProp("camStart")]
public bool CamStart { get; set;}

[REDProp("camFollowBoneID")]
public Int32 CamFollowBoneID { get; set;}

[REDProp("camFollowBoneName")]
public CName CamFollowBoneName { get; set;}

[REDProp("vectorUp")]
public Vector VectorUp { get; set;}

[REDProp("forceAirCollision")]
public bool ForceAirCollision { get; set;}

[REDProp("forceJumpGrab")]
public bool ForceJumpGrab { get; set;}

[REDProp("noAdjustor")]
public bool NoAdjustor { get; set;}

[REDProp("noPelvisCorection")]
public bool NoPelvisCorection { get; set;}

[REDProp("restoreUsableItemLAtEnd")]
public bool RestoreUsableItemLAtEnd { get; set;}

#endregion
}
}