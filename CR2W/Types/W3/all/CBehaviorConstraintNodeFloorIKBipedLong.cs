using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorConstraintNodeFloorIKBipedLong : CBehaviorConstraintNodeFloorIKBase
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

[REDProp("upDirAdditionalWS")]
public Vector UpDirAdditionalWS { get; set;}

[REDProp("pelvis")]
public SBehaviorConstraintNodeFloorIKVerticalBoneData Pelvis { get; set;}

[REDProp("legs")]
public SBehaviorConstraintNodeFloorIKLegsData Legs { get; set;}

[REDProp("leftLegIK")]
public STwoBonesIKSolverData LeftLegIK { get; set;}

[REDProp("rightLegIK")]
public STwoBonesIKSolverData RightLegIK { get; set;}

[REDProp("leftShoulder")]
public SBehaviorConstraintNodeFloorIKVerticalBoneData LeftShoulder { get; set;}

[REDProp("rightShoulder")]
public SBehaviorConstraintNodeFloorIKVerticalBoneData RightShoulder { get; set;}

[REDProp("neck1MaintainLook")]
public SBehaviorConstraintNodeFloorIKMaintainLookBoneData Neck1MaintainLook { get; set;}

[REDProp("neck2MaintainLook")]
public SBehaviorConstraintNodeFloorIKMaintainLookBoneData Neck2MaintainLook { get; set;}

[REDProp("headMaintainLook")]
public SBehaviorConstraintNodeFloorIKMaintainLookBoneData HeadMaintainLook { get; set;}

#endregion
}
}