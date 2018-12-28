using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphBlendAdditiveNode : CBehaviorGraphNode
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

[REDProp("type")]
public EAdditiveType Type { get; set;}

[REDProp("synchronize")]
public bool Synchronize { get; set;}

[REDProp("syncMethod")]
public Ptr<IBehaviorSyncMethod> SyncMethod { get; set;}

[REDProp("biasValue")]
public float BiasValue { get; set;}

[REDProp("scaleValue")]
public float ScaleValue { get; set;}

[REDProp("cachedInputNode")]
public Ptr<CBehaviorGraphNode> CachedInputNode { get; set;}

[REDProp("cachedAddedInputNode")]
public Ptr<CBehaviorGraphNode> CachedAddedInputNode { get; set;}

[REDProp("cachedControlVariableNode")]
public Ptr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

#endregion
}
}