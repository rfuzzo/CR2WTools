using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationMover : CObject
{
#region RED Properties

[REDProp("m_ExplorationO")]
public Handle<CExplorationStateManager> M_ExplorationO { get; set;}

[REDProp("m_InputO")]
public Handle<CExplorationInput> M_InputO { get; set;}

[REDProp("m_WorldPositionV")]
public Vector M_WorldPositionV { get; set;}

[REDProp("m_DisplacementLastFrameV")]
public Vector M_DisplacementLastFrameV { get; set;}

[REDProp("m_PlaneMovementParamsS")]
public SPlaneMovementParameters M_PlaneMovementParamsS { get; set;}

[REDProp("m_VerticalMovementParamsS")]
public SVerticalMovementParams M_VerticalMovementParamsS { get; set;}

[REDProp("m_SlidingParamsS")]
public SSlidingMovementParams M_SlidingParamsS { get; set;}

[REDProp("m_SkatingParamsS")]
public SSkatingMovementParams M_SkatingParamsS { get; set;}

[REDProp("m_SkatingLevelParamsS")]
public SSkatingLevelParams M_SkatingLevelParamsS { get; set;}

[REDProp("m_SkatingTurnPerSpeedF")]
public float M_SkatingTurnPerSpeedF { get; set;}

[REDProp("m_SkatingSpeedTotalMaxF")]
public float M_SkatingSpeedTotalMaxF { get; set;}

[REDProp("m_SkatingTurnPerSpeedCurF")]
public float M_SkatingTurnPerSpeedCurF { get; set;}

[REDProp("m_SkatingTurnPerSpeedBlendF")]
public float M_SkatingTurnPerSpeedBlendF { get; set;}

[REDProp("m_SlidingFrictionBlendedF")]
public float M_SlidingFrictionBlendedF { get; set;}

[REDProp("m_SkateTurnDecelCoefF")]
public float M_SkateTurnDecelCoefF { get; set;}

[REDProp("m_SkateTurnBrakeCoefF")]
public float M_SkateTurnBrakeCoefF { get; set;}

[REDProp("m_VelocityV")]
public Vector M_VelocityV { get; set;}

[REDProp("m_VelocityNormalizedV")]
public Vector M_VelocityNormalizedV { get; set;}

[REDProp("m_SpeedF")]
public float M_SpeedF { get; set;}

[REDProp("m_SpeedHeadingF")]
public float M_SpeedHeadingF { get; set;}

[REDProp("m_SpeedVerticalF")]
public float M_SpeedVerticalF { get; set;}

[REDProp("m_DisplacementV")]
public Vector M_DisplacementV { get; set;}

[REDProp("m_RotationDeltaEA")]
public EulerAngles M_RotationDeltaEA { get; set;}

[REDProp("m_SpeedLastF")]
public float M_SpeedLastF { get; set;}

[REDProp("m_AccelerationLastF")]
public float M_AccelerationLastF { get; set;}

[REDProp("m_SlideMaxSpeedSafeF")]
public float M_SlideMaxSpeedSafeF { get; set;}

[REDProp("m_SlideMaxSpeedToFallF")]
public float M_SlideMaxSpeedToFallF { get; set;}

[REDProp("m_SlideMaxSpeedF")]
public float M_SlideMaxSpeedF { get; set;}

[REDProp("m_UseMaterialsB")]
public bool M_UseMaterialsB { get; set;}

[REDProp("m_SlidingLimitMinF")]
public float M_SlidingLimitMinF { get; set;}

[REDProp("m_SlidingLimitMaxF")]
public float M_SlidingLimitMaxF { get; set;}

[REDProp("m_MaterialFrictionMultF")]
public float M_MaterialFrictionMultF { get; set;}

[REDProp("m_CoefMinMaterialF")]
public float M_CoefMinMaterialF { get; set;}

[REDProp("m_SlideNormalRealV")]
public Vector M_SlideNormalRealV { get; set;}

[REDProp("m_SlideNormalV")]
public Vector M_SlideNormalV { get; set;}

[REDProp("m_SlideDirV")]
public Vector M_SlideDirV { get; set;}

[REDProp("m_SlideRealangleF")]
public float M_SlideRealangleF { get; set;}

[REDProp("m_SlideComputedThisFrameB")]
public bool M_SlideComputedThisFrameB { get; set;}

[REDProp("m_SlideWideComputedThisFrameB")]
public bool M_SlideWideComputedThisFrameB { get; set;}

[REDProp("m_SlideWideCoefGlobalF")]
public float M_SlideWideCoefGlobalF { get; set;}

[REDProp("m_WideNormalAverageV")]
public Vector M_WideNormalAverageV { get; set;}

[REDProp("m_WideNormalGlobalV")]
public Vector M_WideNormalGlobalV { get; set;}

[REDProp("m_SlideWideCoefAverageF")]
public float M_SlideWideCoefAverageF { get; set;}

[REDProp("m_SlideWideCoefRealGlobalF")]
public float M_SlideWideCoefRealGlobalF { get; set;}

[REDProp("m_SlideWideCoefRealAverageF")]
public float M_SlideWideCoefRealAverageF { get; set;}

[REDProp("m_SlideTerrainWideDistFwdF")]
public float M_SlideTerrainWideDistFwdF { get; set;}

[REDProp("m_SlideTerrainWideDistBwdF")]
public float M_SlideTerrainWideDistBwdF { get; set;}

[REDProp("m_SlideTerrainWideDistHorizF")]
public float M_SlideTerrainWideDistHorizF { get; set;}

[REDProp("gravityCurve")]
public Handle<CCurve> GravityCurve { get; set;}

[REDProp("superSlide")]
public bool SuperSlide { get; set;}

[REDProp("m_TurnThisFrameF")]
public float M_TurnThisFrameF { get; set;}

[REDProp("m_BankingNeedsUpdatingB")]
public bool M_BankingNeedsUpdatingB { get; set;}

[REDProp("m_BankingTargetF")]
public float M_BankingTargetF { get; set;}

[REDProp("m_BankingSpeedF")]
public float M_BankingSpeedF { get; set;}

[REDProp("m_BankingSpeedDefaultF")]
public float M_BankingSpeedDefaultF { get; set;}

[REDProp("m_OrientToInputMaxHeadingF")]
public float M_OrientToInputMaxHeadingF { get; set;}

[REDProp("m_MACVelocityDampedV")]
public Vector M_MACVelocityDampedV { get; set;}

[REDProp("m_MACVelocityDamSpeedF")]
public float M_MACVelocityDamSpeedF { get; set;}

[REDProp("m_CustomIsAnimatedB")]
public bool M_CustomIsAnimatedB { get; set;}

[REDProp("m_BoneRightFootN")]
public CName M_BoneRightFootN { get; set;}

[REDProp("m_BoneLeftFootN")]
public CName M_BoneLeftFootN { get; set;}

[REDProp("m_BoneIndexRightFootI")]
public Int32 M_BoneIndexRightFootI { get; set;}

[REDProp("m_BoneIndexLeftFootI")]
public Int32 M_BoneIndexLeftFootI { get; set;}

[REDProp("m_UpV")]
public Vector M_UpV { get; set;}

[REDProp("m_ZeroV")]
public Vector M_ZeroV { get; set;}

#endregion
}
}