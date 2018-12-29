using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphAnimationMixerSlotNode : CBehaviorGraphBaseNode
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

[REDProp("bodyOrMimicMode")]
public bool BodyOrMimicMode { get; set;}

[REDProp("canUseIdles")]
public bool CanUseIdles { get; set;}

[REDProp("postIdleAdditiveType")]
public EAdditiveType PostIdleAdditiveType { get; set;}

[REDProp("postAllAdditiveType")]
public EAdditiveType PostAllAdditiveType { get; set;}

[REDProp("fullEyesWeightMimicsTracks")]
public Array<CName> FullEyesWeightMimicsTracks { get; set;}

[REDProp("cachedPostIdleNodeA")]
public Ptr<CBehaviorGraphNode> CachedPostIdleNodeA { get; set;}

[REDProp("cachedPostIdleNodeB")]
public Ptr<CBehaviorGraphNode> CachedPostIdleNodeB { get; set;}

[REDProp("cachedPostAllNodeA")]
public Ptr<CBehaviorGraphNode> CachedPostAllNodeA { get; set;}

[REDProp("cachedPostAllNodeB")]
public Ptr<CBehaviorGraphNode> CachedPostAllNodeB { get; set;}

#endregion
}
}