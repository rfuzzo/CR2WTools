using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationSharedData : CObject
{
#region RED Properties

[REDProp("m_ExplorationO")]
public Handle<CExplorationStateManager> M_ExplorationO { get; set;}

[REDProp("m_AutoJumpOnPredictionB")]
public bool M_AutoJumpOnPredictionB { get; set;}

[REDProp("m_AutoJumpToWaterB")]
public bool M_AutoJumpToWaterB { get; set;}

[REDProp("m_TimeSinceIdleF")]
public float M_TimeSinceIdleF { get; set;}

[REDProp("m_SprintJumpTimePreparingF")]
public float M_SprintJumpTimePreparingF { get; set;}

[REDProp("m_BehParamRightFootS")]
public CName M_BehParamRightFootS { get; set;}

[REDProp("m_IsRightFootForwardB")]
public bool M_IsRightFootForwardB { get; set;}

[REDProp("m_JumpTypeE")]
public EJumpType M_JumpTypeE { get; set;}

[REDProp("m_LandingOnWater")]
public bool M_LandingOnWater { get; set;}

[REDProp("m_JumpIsTooSoonToLandB")]
public bool M_JumpIsTooSoonToLandB { get; set;}

[REDProp("m_FallHeightReachedF")]
public float M_FallHeightReachedF { get; set;}

[REDProp("m_UsePantherJumpB")]
public bool M_UsePantherJumpB { get; set;}

[REDProp("m_AirCollisionIsFrontal")]
public bool M_AirCollisionIsFrontal { get; set;}

[REDProp("m_JumpDirectionForcedV")]
public Vector M_JumpDirectionForcedV { get; set;}

[REDProp("m_CanFallSetVelocityB")]
public bool M_CanFallSetVelocityB { get; set;}

[REDProp("m_ShouldFlipFootOnLandB")]
public bool M_ShouldFlipFootOnLandB { get; set;}

[REDProp("m_DontRecalcFootOnLandB")]
public bool M_DontRecalcFootOnLandB { get; set;}

[REDProp("m_FromCriticalB")]
public bool M_FromCriticalB { get; set;}

[REDProp("m_ClimbStateTypeE")]
public EClimbRequirementType M_ClimbStateTypeE { get; set;}

[REDProp("m_AirCollisionSideEnabledB")]
public bool M_AirCollisionSideEnabledB { get; set;}

[REDProp("m_SkipLandAnimDistMaxF")]
public float M_SkipLandAnimDistMaxF { get; set;}

[REDProp("m_SkipLandAnimTimeMaxF")]
public float M_SkipLandAnimTimeMaxF { get; set;}

[REDProp("m_SkateGlobalC")]
public Handle<CExplorationSkatingGlobal> M_SkateGlobalC { get; set;}

[REDProp("m_LastExplorationS")]
public SExplorationQueryToken M_LastExplorationS { get; set;}

[REDProp("m_LastExplorationValidB")]
public bool M_LastExplorationValidB { get; set;}

[REDProp("m_AngleToExploreManualF")]
public float M_AngleToExploreManualF { get; set;}

[REDProp("m_AngleToExploreAutoF")]
public float M_AngleToExploreAutoF { get; set;}

[REDProp("hasToRecoverFromRagdoll")]
public bool HasToRecoverFromRagdoll { get; set;}

[REDProp("m_TeleportTimeCurF")]
public float M_TeleportTimeCurF { get; set;}

[REDProp("m_TeleportTimeMaxF")]
public float M_TeleportTimeMaxF { get; set;}

[REDProp("terrainSlidePresetName")]
public CName TerrainSlidePresetName { get; set;}

[REDProp("terrainBlendSpeedCur")]
public float TerrainBlendSpeedCur { get; set;}

[REDProp("terrainBlendSpeedTarget")]
public float TerrainBlendSpeedTarget { get; set;}

[REDProp("terrainBlendTimeCur")]
public float TerrainBlendTimeCur { get; set;}

[REDProp("terrainBlendTimeMax")]
public float TerrainBlendTimeMax { get; set;}

[REDProp("m_JumpSwimRotationF")]
public float M_JumpSwimRotationF { get; set;}

[REDProp("m_JumpToWaterAreaB")]
public bool M_JumpToWaterAreaB { get; set;}

[REDProp("m_JumpToWaterForcedDirV")]
public Vector M_JumpToWaterForcedDirV { get; set;}

[REDProp("m_JumpToWaterRequireDirB")]
public bool M_JumpToWaterRequireDirB { get; set;}

[REDProp("m_JumpToWaterRequireSprintB")]
public bool M_JumpToWaterRequireSprintB { get; set;}

[REDProp("m_HeightFallenF")]
public float M_HeightFallenF { get; set;}

[REDProp("lastPosition")]
public Vector LastPosition { get; set;}

[REDProp("landAddAdding")]
public bool LandAddAdding { get; set;}

[REDProp("landAddCurrent")]
public float LandAddCurrent { get; set;}

[REDProp("landAddCurve")]
public Handle<CCurve> LandAddCurve { get; set;}

[REDProp("landAddCoef")]
public float LandAddCoef { get; set;}

[REDProp("landAddCoefWalk")]
public float LandAddCoefWalk { get; set;}

[REDProp("landAddTimeCoefWalk")]
public float LandAddTimeCoefWalk { get; set;}

[REDProp("landAddTimeCur")]
public float LandAddTimeCur { get; set;}

[REDProp("landAddSpeedCancel")]
public float LandAddSpeedCancel { get; set;}

[REDProp("landAddTimeCoef")]
public float LandAddTimeCoef { get; set;}

[REDProp("landAddTimeCoefFast")]
public float LandAddTimeCoefFast { get; set;}

[REDProp("landAddBehVarName")]
public CName LandAddBehVarName { get; set;}

[REDProp("m_CameraModifyOffsetB")]
public bool M_CameraModifyOffsetB { get; set;}

[REDProp("m_UsePrototypeAnimationsB")]
public bool M_UsePrototypeAnimationsB { get; set;}

[REDProp("m_ForceOnlyJumpB")]
public bool M_ForceOnlyJumpB { get; set;}

[REDProp("m_UseClimbB")]
public bool M_UseClimbB { get; set;}

[REDProp("m_UsepushB")]
public bool M_UsepushB { get; set;}

[REDProp("hackKnockBackAlways")]
public bool HackKnockBackAlways { get; set;}

#endregion
}
}