using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateJump : CExplorationStateAbstract
{
#region RED Properties

[REDProp("jumpEnabled")]
public bool JumpEnabled { get; set;}

[REDProp("m_SubstateE")]
public EJumpSubState M_SubstateE { get; set;}

[REDProp("m_OrientationInitialF")]
public float M_OrientationInitialF { get; set;}

[REDProp("m_MaxHeightReachedF")]
public float M_MaxHeightReachedF { get; set;}

[REDProp("m_SlopeAngleMaxToJump")]
public float M_SlopeAngleMaxToJump { get; set;}

[REDProp("m_UseGenericJumpB")]
public bool M_UseGenericJumpB { get; set;}

[REDProp("m_AllowSprintJumpB")]
public bool M_AllowSprintJumpB { get; set;}

[REDProp("m_JumpParmsS")]
public SJumpParams M_JumpParmsS { get; set;}

[REDProp("m_JumpParmsGenericS")]
public SJumpParams M_JumpParmsGenericS { get; set;}

[REDProp("m_JumpParmsIdleS")]
public SJumpParams M_JumpParmsIdleS { get; set;}

[REDProp("m_JumpParmsIdleToWalkS")]
public SJumpParams M_JumpParmsIdleToWalkS { get; set;}

[REDProp("m_JumpParmsWalkS")]
public SJumpParams M_JumpParmsWalkS { get; set;}

[REDProp("m_JumpParmsWalkHighS")]
public SJumpParams M_JumpParmsWalkHighS { get; set;}

[REDProp("m_JumpParmsRunS")]
public SJumpParams M_JumpParmsRunS { get; set;}

[REDProp("m_JumpParmsSprintS")]
public SJumpParams M_JumpParmsSprintS { get; set;}

[REDProp("m_JumpParmsFallS")]
public SJumpParams M_JumpParmsFallS { get; set;}

[REDProp("m_JumpParmsHitS")]
public SJumpParams M_JumpParmsHitS { get; set;}

[REDProp("m_JumpParmsSlideS")]
public SJumpParams M_JumpParmsSlideS { get; set;}

[REDProp("m_JumpParmsVaultS")]
public SJumpParams M_JumpParmsVaultS { get; set;}

[REDProp("m_JumpParmsToWaterS")]
public SJumpParams M_JumpParmsToWaterS { get; set;}

[REDProp("m_JumpParmsKnockBackS")]
public SJumpParams M_JumpParmsKnockBackS { get; set;}

[REDProp("m_JumpParmsKnockBackFallS")]
public SJumpParams M_JumpParmsKnockBackFallS { get; set;}

[REDProp("m_JumpParmsSkateIdleS")]
public SJumpParams M_JumpParmsSkateIdleS { get; set;}

[REDProp("m_SprintJumpNeedsStaminaB")]
public bool M_SprintJumpNeedsStaminaB { get; set;}

[REDProp("m_SprintJumpTimeExtraF")]
public float M_SprintJumpTimeExtraF { get; set;}

[REDProp("m_SprintJumpTimeGapF")]
public float M_SprintJumpTimeGapF { get; set;}

[REDProp("m_ConserveHorizontalCoefF")]
public float M_ConserveHorizontalCoefF { get; set;}

[REDProp("m_ConserveVertUpCoefF")]
public float M_ConserveVertUpCoefF { get; set;}

[REDProp("m_ConserveVertDownCoefF")]
public float M_ConserveVertDownCoefF { get; set;}

[REDProp("m_ConserveHorizontalMaxF")]
public float M_ConserveHorizontalMaxF { get; set;}

[REDProp("m_ConserveVertUpMaxF")]
public float M_ConserveVertUpMaxF { get; set;}

[REDProp("m_ConserveVertDownMaxF")]
public float M_ConserveVertDownMaxF { get; set;}

[REDProp("m_SpeedSqrMinToConserveF")]
public float M_SpeedSqrMinToConserveF { get; set;}

[REDProp("m_ReactToHitCeilingB")]
public bool M_ReactToHitCeilingB { get; set;}

[REDProp("m_HitCeilingB")]
public bool M_HitCeilingB { get; set;}

[REDProp("m_BehEventPredictLandN")]
public CName M_BehEventPredictLandN { get; set;}

[REDProp("m_BehListenInertialJumpN")]
public CName M_BehListenInertialJumpN { get; set;}

[REDProp("m_BehListenFinishTakeOffN")]
public CName M_BehListenFinishTakeOffN { get; set;}

[REDProp("m_BehParamJumpTypeN")]
public CName M_BehParamJumpTypeN { get; set;}

[REDProp("m_BehEventPredictingS")]
public CName M_BehEventPredictingS { get; set;}

[REDProp("m_BehEventPredictTypeS")]
public CName M_BehEventPredictTypeS { get; set;}

[REDProp("m_BehParamIsHandledByAnimS")]
public CName M_BehParamIsHandledByAnimS { get; set;}

[REDProp("m_BehParamWalkOrSprintS")]
public CName M_BehParamWalkOrSprintS { get; set;}

[REDProp("m_BehParamNormalLandS")]
public CName M_BehParamNormalLandS { get; set;}

[REDProp("m_BehEventCeilingHit")]
public CName M_BehEventCeilingHit { get; set;}

[REDProp("m_InteractAlwaysB")]
public bool M_InteractAlwaysB { get; set;}

[REDProp("m_InteractTimeMinFallF")]
public float M_InteractTimeMinFallF { get; set;}

[REDProp("m_InteractTimeMinF")]
public float M_InteractTimeMinF { get; set;}

[REDProp("m_InteractTimeMinVaultF")]
public float M_InteractTimeMinVaultF { get; set;}

[REDProp("m_InteractHeightFallMaxF")]
public float M_InteractHeightFallMaxF { get; set;}

[REDProp("m_InteractTimeAdjustingF")]
public float M_InteractTimeAdjustingF { get; set;}

[REDProp("m_InteractDistanceExtraF")]
public float M_InteractDistanceExtraF { get; set;}

[REDProp("m_InteractSpeedDiffAllowedF")]
public float M_InteractSpeedDiffAllowedF { get; set;}

[REDProp("m_InteractOwnerOffsetV")]
public Vector M_InteractOwnerOffsetV { get; set;}

[REDProp("m_LockingJumpOnInteractionAreaB")]
public bool M_LockingJumpOnInteractionAreaB { get; set;}

[REDProp("m_LockingJumpOnHorseAreaB")]
public bool M_LockingJumpOnHorseAreaB { get; set;}

[REDProp("m_AllowJumpInSlopesB")]
public bool M_AllowJumpInSlopesB { get; set;}

[REDProp("m_FallDistToUseHelpF")]
public float M_FallDistToUseHelpF { get; set;}

[REDProp("m_FallRecoverMaxHeightUpF")]
public float M_FallRecoverMaxHeightUpF { get; set;}

[REDProp("m_FallRecoverMaxHeightDownF")]
public float M_FallRecoverMaxHeightDownF { get; set;}

[REDProp("m_FallRecoverMaxDistF")]
public float M_FallRecoverMaxDistF { get; set;}

[REDProp("m_CanSetVelocityB")]
public bool M_CanSetVelocityB { get; set;}

[REDProp("m_ForceIdleJumpOnColliisonB")]
public bool M_ForceIdleJumpOnColliisonB { get; set;}

[REDProp("m_ForceIdleJumpHeightFreeF")]
public float M_ForceIdleJumpHeightFreeF { get; set;}

[REDProp("m_ForceIdleJumpDistFreeF")]
public float M_ForceIdleJumpDistFreeF { get; set;}

[REDProp("m_InteractionLastLockingF")]
public float M_InteractionLastLockingF { get; set;}

[REDProp("m_LandPredictedB")]
public bool M_LandPredictedB { get; set;}

[REDProp("m_LandGroundPredictB")]
public bool M_LandGroundPredictB { get; set;}

[REDProp("m_LandWaterPredictB")]
public bool M_LandWaterPredictB { get; set;}

[REDProp("m_LandPredictTimeMin")]
public float M_LandPredictTimeMin { get; set;}

[REDProp("m_LandPredictionTimeF")]
public float M_LandPredictionTimeF { get; set;}

[REDProp("m_CollisionGroupsNamesNArr")]
public Array<CName> M_CollisionGroupsNamesNArr { get; set;}

[REDProp("m_LandPredicedTypeE")]
public ELandPredictionType M_LandPredicedTypeE { get; set;}

[REDProp("m_LandPredicedCoefF")]
public float M_LandPredicedCoefF { get; set;}

[REDProp("m_LandPredicedBlendF")]
public float M_LandPredicedBlendF { get; set;}

[REDProp("m_SlopedLandZF")]
public float M_SlopedLandZF { get; set;}

[REDProp("m_JumpOriginalPositionV")]
public Vector M_JumpOriginalPositionV { get; set;}

[REDProp("m_CameraDebugB")]
public bool M_CameraDebugB { get; set;}

[REDProp("m_CameraStartB")]
public bool M_CameraStartB { get; set;}

[REDProp("m_CameraPositionV")]
public Vector M_CameraPositionV { get; set;}

[REDProp("m_CameraRotationEA")]
public EulerAngles M_CameraRotationEA { get; set;}

[REDProp("m_CameraTimeToEndF")]
public float M_CameraTimeToEndF { get; set;}

[REDProp("cameraRoationName")]
public CName CameraRoationName { get; set;}

[REDProp("cameraToFallHeightNeed")]
public float CameraToFallHeightNeed { get; set;}

[REDProp("cameraFallIsSet")]
public bool CameraFallIsSet { get; set;}

[REDProp("m_CollideBehGraphSideNameS")]
public CName M_CollideBehGraphSideNameS { get; set;}

[REDProp("m_CollidingSideE")]
public ESideSelected M_CollidingSideE { get; set;}

[REDProp("m_CooldownTotalF")]
public float M_CooldownTotalF { get; set;}

[REDProp("m_CooldownCurF")]
public float M_CooldownCurF { get; set;}

[REDProp("useWalkJump")]
public bool UseWalkJump { get; set;}

[REDProp("useIdleWalkJump")]
public bool UseIdleWalkJump { get; set;}

[REDProp("useHighJump")]
public bool UseHighJump { get; set;}

[REDProp("jumpingOnIdleIsForward")]
public bool JumpingOnIdleIsForward { get; set;}

[REDProp("jumpIdleWhenObstructed")]
public bool JumpIdleWhenObstructed { get; set;}

#endregion
}
}