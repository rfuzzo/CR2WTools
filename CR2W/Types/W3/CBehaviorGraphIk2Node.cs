using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphIk2Node : CBehaviorGraphBaseNode
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

[REDProp("cachedValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedValueNode { get; set;}

[REDProp("cachedTargetPosNode")]
public Ptr<CBehaviorGraphVectorValueNode> CachedTargetPosNode { get; set;}

[REDProp("cachedTargetRotNode")]
public Ptr<CBehaviorGraphVectorValueNode> CachedTargetRotNode { get; set;}

[REDProp("firstBone")]
public string FirstBone { get; set;}

[REDProp("secondBone")]
public string SecondBone { get; set;}

[REDProp("endBone")]
public string EndBone { get; set;}

[REDProp("hingeAxis")]
public EAxis HingeAxis { get; set;}

[REDProp("angleMax")]
public float AngleMax { get; set;}

[REDProp("angleMin")]
public float AngleMin { get; set;}

[REDProp("firstJointGain")]
public float FirstJointGain { get; set;}

[REDProp("secondJointGain")]
public float SecondJointGain { get; set;}

[REDProp("endJointGain")]
public float EndJointGain { get; set;}

[REDProp("enforceEndPosition")]
public bool EnforceEndPosition { get; set;}

[REDProp("enforceEndRotation")]
public bool EnforceEndRotation { get; set;}

[REDProp("positionOffset")]
public Vector PositionOffset { get; set;}

[REDProp("rotationOffset")]
public EulerAngles RotationOffset { get; set;}

#endregion
}
}