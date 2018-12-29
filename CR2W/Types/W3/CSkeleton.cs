using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CSkeleton : CResource
{
#region RED Properties

[REDProp("lodBoneNum_1")]
public int LodBoneNum_1 { get; set;}

[REDProp("walkSpeed")]
public float WalkSpeed { get; set;}

[REDProp("slowRunSpeed")]
public float SlowRunSpeed { get; set;}

[REDProp("fastRunSpeed")]
public float FastRunSpeed { get; set;}

[REDProp("sprintSpeed")]
public float SprintSpeed { get; set;}

[REDProp("walkSpeedRel")]
public float WalkSpeedRel { get; set;}

[REDProp("slowRunSpeedRel")]
public float SlowRunSpeedRel { get; set;}

[REDProp("fastRunSpeedRel")]
public float FastRunSpeedRel { get; set;}

[REDProp("sprintSpeedRel")]
public float SprintSpeedRel { get; set;}

[REDProp("poseCompression")]
public Ptr<IPoseCompression> PoseCompression { get; set;}

[REDProp("bboxGenerator")]
public Ptr<CPoseBBoxGenerator> BboxGenerator { get; set;}

[REDProp("controlRigDefinition")]
public Ptr<TCrDefinition> ControlRigDefinition { get; set;}

[REDProp("controlRigDefaultPropertySet")]
public Ptr<TCrPropertySet> ControlRigDefaultPropertySet { get; set;}

[REDProp("skeletonMappers")]
public Array<Ptr<CSkeleton2SkeletonMapper>> SkeletonMappers { get; set;}

[REDProp("controlRigSettings")]
public Ptr<CControlRigSettings> ControlRigSettings { get; set;}

[REDProp("teleportDetectorData")]
public Ptr<CTeleportDetectorData> TeleportDetectorData { get; set;}

[REDProp("lastNonStreamableBoneName")]
public CName LastNonStreamableBoneName { get; set;}

[REDProp("bones")]
public Array<SSkeletonBone> Bones { get; set;}

[REDProp("tracks")]
public Array<SSkeletonTrack> Tracks { get; set;}

[REDProp("parentIndices")]
public Array<Int16> ParentIndices { get; set;}

#endregion
}
}