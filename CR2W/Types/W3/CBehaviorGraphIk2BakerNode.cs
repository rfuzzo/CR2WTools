using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphIk2BakerNode : CBehaviorGraphBaseNode
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

[REDProp("endBoneName")]
public string EndBoneName { get; set;}

[REDProp("blendInDuration")]
public float BlendInDuration { get; set;}

[REDProp("blendOutDuration")]
public float BlendOutDuration { get; set;}

[REDProp("animEventName")]
public CName AnimEventName { get; set;}

[REDProp("defaultEventStartTime")]
public float DefaultEventStartTime { get; set;}

[REDProp("defaultEventEndTime")]
public float DefaultEventEndTime { get; set;}

[REDProp("hingeAxis")]
public EAxis HingeAxis { get; set;}

[REDProp("enforceEndPosition")]
public bool EnforceEndPosition { get; set;}

[REDProp("bonePositionInWorldSpace")]
public bool BonePositionInWorldSpace { get; set;}

[REDProp("enforceEndRotation")]
public bool EnforceEndRotation { get; set;}

#endregion
}
}