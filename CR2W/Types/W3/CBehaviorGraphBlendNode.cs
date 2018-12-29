using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphBlendNode : CBehaviorGraphNode
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

[REDProp("takeEventsFromMostImportantInput")]
public bool TakeEventsFromMostImportantInput { get; set;}

[REDProp("firstInputValue")]
public float FirstInputValue { get; set;}

[REDProp("secondInputValue")]
public float SecondInputValue { get; set;}

[REDProp("cachedFirstInputNode")]
public Ptr<CBehaviorGraphNode> CachedFirstInputNode { get; set;}

[REDProp("cachedSecondInputNode")]
public Ptr<CBehaviorGraphNode> CachedSecondInputNode { get; set;}

[REDProp("cachedControlVariableNode")]
public Ptr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

#endregion
}
}