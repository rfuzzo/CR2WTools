using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraph : CResource
{
#region RED Properties

[REDProp("defaultStateMachine")]
public Ptr<CBehaviorGraphStateMachineNode> DefaultStateMachine { get; set;}

[REDProp("stateMachines")]
public Array<Ptr<CBehaviorGraphStateMachineNode>> StateMachines { get; set;}

[REDProp("sourceDataRemoved")]
public bool SourceDataRemoved { get; set;}

[REDProp("customTrackNames")]
public Array<CName> CustomTrackNames { get; set;}

[REDProp("generateEditorFragments")]
public bool GenerateEditorFragments { get; set;}

[REDProp("poseSlots")]
public Array<Ptr<CBehaviorGraphPoseSlotNode>> PoseSlots { get; set;}

[REDProp("animSlots")]
public Array<Ptr<CBehaviorGraphAnimationBaseSlotNode>> AnimSlots { get; set;}

#endregion
}
}