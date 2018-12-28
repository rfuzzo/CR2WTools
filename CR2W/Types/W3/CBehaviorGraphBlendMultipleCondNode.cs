using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphBlendMultipleCondNode : CBehaviorGraphNode
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

[REDProp("inputValues")]
public Array<float> InputValues { get; set;}

[REDProp("synchronizeAnimations")]
public bool SynchronizeAnimations { get; set;}

[REDProp("syncMethodAnimation")]
public Ptr<IBehaviorSyncMethod> SyncMethodAnimation { get; set;}

[REDProp("useTransitions")]
public bool UseTransitions { get; set;}

[REDProp("transitions")]
public Array<Ptr<CBehaviorGraphBlendMultipleCondNode_Transition>> Transitions { get; set;}

[REDProp("useWeightDamp")]
public bool UseWeightDamp { get; set;}

[REDProp("weightDampMethod")]
public Ptr<IBehaviorGraphBlendMultipleCondNode_DampMethod> WeightDampMethod { get; set;}

[REDProp("useControlValueDamp")]
public bool UseControlValueDamp { get; set;}

[REDProp("controlValueDampMethod")]
public Ptr<IBehaviorGraphBlendMultipleCondNode_DampMethod> ControlValueDampMethod { get; set;}

[REDProp("radialBlending")]
public bool RadialBlending { get; set;}

[REDProp("cachedInputNodes")]
public Array<Ptr<CBehaviorGraphNode>> CachedInputNodes { get; set;}

[REDProp("cachedControlValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

#endregion
}
}