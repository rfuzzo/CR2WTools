using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphPoseConstraintPoseLookAtNode : CBehaviorGraphPoseConstraintWithTargetNode
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

[REDProp("cachedTargetPosValueNode")]
public Ptr<CBehaviorGraphVectorValueNode> CachedTargetPosValueNode { get; set;}

[REDProp("cachedTargetRotValueNode")]
public Ptr<CBehaviorGraphVectorValueNode> CachedTargetRotValueNode { get; set;}

[REDProp("dataSegments")]
public Array<SPoseLookAtSegmentData> DataSegments { get; set;}

[REDProp("modifiers")]
public Array<Ptr<IBehaviorPoseConstraintPoseLookAtModifier>> Modifiers { get; set;}

#endregion
}
}