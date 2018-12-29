using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphRotationControllerNode : CBehaviorGraphBaseNode
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

[REDProp("eventAllowRot")]
public CName EventAllowRot { get; set;}

[REDProp("continueUpdate")]
public bool ContinueUpdate { get; set;}

[REDProp("cachedAngleVariableNode")]
public Ptr<CBehaviorGraphValueNode> CachedAngleVariableNode { get; set;}

[REDProp("cachedWeightVariableNode")]
public Ptr<CBehaviorGraphValueNode> CachedWeightVariableNode { get; set;}

#endregion
}
}