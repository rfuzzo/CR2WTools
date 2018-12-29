using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphMimicsBlendNode : CBehaviorGraphNode
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

[REDProp("cachedFirstInputNode")]
public Ptr<CBehaviorGraphNode> CachedFirstInputNode { get; set;}

[REDProp("cachedSecondInputNode")]
public Ptr<CBehaviorGraphNode> CachedSecondInputNode { get; set;}

[REDProp("cachedControlVariableNode")]
public Ptr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

[REDProp("type")]
public EBehaviorMimicBlendType Type { get; set;}

#endregion
}
}