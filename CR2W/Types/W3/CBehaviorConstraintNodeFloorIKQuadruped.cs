using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorConstraintNodeFloorIKQuadruped : CBehaviorConstraintNodeFloorIKBase
{
#region RED Properties

[REDProp("sockets")]
public Array<Ptr<CGraphSocket>> Sockets { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("activateNotification")]
public CName ActivateNotification { get; set;}

[REDProp("deactivateNotification")]
public CName DeactivateNotification { get; set;}

[REDProp("generateEditorFragments")]
public bool GenerateEditorFragments { get; set;}

[REDProp("id")]
public uint Id { get; set;}

[REDProp("cachedInputNode")]
public Ptr<CBehaviorGraphNode> CachedInputNode { get; set;}

[REDProp("cachedControlValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

[REDProp("requiredAnimEvent")]
public CName RequiredAnimEvent { get; set;}

[REDProp("blockAnimEvent")]
public CName BlockAnimEvent { get; set;}

[REDProp("canBeDisabledDueToFrameRate")]
public bool CanBeDisabledDueToFrameRate { get; set;}

[REDProp("useFixedVersion")]
public bool UseFixedVersion { get; set;}

[REDProp("slopeAngleDamp")]
public float SlopeAngleDamp { get; set;}

[REDProp("common")]
public SBehaviorConstraintNodeFloorIKCommonData Common { get; set;}

[REDProp("speedForFullyPerpendicularLegs")]
public float SpeedForFullyPerpendicularLegs { get; set;}

[REDProp("upDirFromFrontAndBackLegsDiffCoef")]
public float UpDirFromFrontAndBackLegsDiffCoef { get; set;}

[REDProp("upDirUseFrontAndBackLegsDiff")]
public float UpDirUseFrontAndBackLegsDiff { get; set;}

[REDProp("upDirAdditionalWS")]
public Vector UpDirAdditionalWS { get; set;}

[REDProp("pelvis")]
public SBehaviorConstraintNodeFloorIKVerticalBoneData Pelvis { get; set;}

[REDProp("legs")]
public SBehaviorConstraintNodeFloorIKLegsData Legs { get; set;}

[REDProp("leftBackLegIK")]
public STwoBonesIKSolverData LeftBackLegIK { get; set;}

[REDProp("rightBackLegIK")]
public STwoBonesIKSolverData RightBackLegIK { get; set;}

[REDProp("leftFrontLegIK")]
public STwoBonesIKSolverData LeftFrontLegIK { get; set;}

[REDProp("rightFrontLegIK")]
public STwoBonesIKSolverData RightFrontLegIK { get; set;}

[REDProp("leftFrontLegRotIK")]
public SApplyRotationIKSolverData LeftFrontLegRotIK { get; set;}

[REDProp("rightFrontLegRotIK")]
public SApplyRotationIKSolverData RightFrontLegRotIK { get; set;}

[REDProp("leftBackShoulder")]
public SBehaviorConstraintNodeFloorIKVerticalBoneData LeftBackShoulder { get; set;}

[REDProp("rightBackShoulder")]
public SBehaviorConstraintNodeFloorIKVerticalBoneData RightBackShoulder { get; set;}

[REDProp("leftFrontShoulder")]
public SBehaviorConstraintNodeFloorIKVerticalBoneData LeftFrontShoulder { get; set;}

[REDProp("rightFrontShoulder")]
public SBehaviorConstraintNodeFloorIKVerticalBoneData RightFrontShoulder { get; set;}

[REDProp("neck1MaintainLook")]
public SBehaviorConstraintNodeFloorIKMaintainLookBoneData Neck1MaintainLook { get; set;}

[REDProp("neck2MaintainLook")]
public SBehaviorConstraintNodeFloorIKMaintainLookBoneData Neck2MaintainLook { get; set;}

[REDProp("headMaintainLook")]
public SBehaviorConstraintNodeFloorIKMaintainLookBoneData HeadMaintainLook { get; set;}

#endregion
}
}