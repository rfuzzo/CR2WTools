using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorGraphBlend3Node : CBehaviorGraphNode
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

[REDProp("synchronize")]
public bool Synchronize { get; set;}

[REDProp("syncMethod")]
public Ptr<IBehaviorSyncMethod> SyncMethod { get; set;}

[REDProp("useCustomSpace")]
public bool UseCustomSpace { get; set;}

[REDProp("takeEventsFromMostImportantInput")]
public bool TakeEventsFromMostImportantInput { get; set;}

[REDProp("A")]
public Vector A { get; set;}

[REDProp("B")]
public Vector B { get; set;}

[REDProp("C")]
public Vector C { get; set;}

[REDProp("D")]
public Vector D { get; set;}

[REDProp("cachedInputNode_A")]
public Ptr<CBehaviorGraphNode> CachedInputNode_A { get; set;}

[REDProp("cachedInputNode_B")]
public Ptr<CBehaviorGraphNode> CachedInputNode_B { get; set;}

[REDProp("cachedInputNode_C")]
public Ptr<CBehaviorGraphNode> CachedInputNode_C { get; set;}

[REDProp("cachedInputNode_D")]
public Ptr<CBehaviorGraphNode> CachedInputNode_D { get; set;}

[REDProp("cachedControlVariableNode_A")]
public Ptr<CBehaviorGraphValueNode> CachedControlVariableNode_A { get; set;}

[REDProp("cachedControlVariableNode_B")]
public Ptr<CBehaviorGraphValueNode> CachedControlVariableNode_B { get; set;}

#endregion
}
}