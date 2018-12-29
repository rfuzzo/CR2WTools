using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorGraphSyncOverrideStateMachineNode : CBehaviorGraphSelfActivatingStateMachineNode
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

[REDProp("mimicInputs")]
public Array<CName> MimicInputs { get; set;}

[REDProp("vectorValueInputs")]
public Array<CName> VectorValueInputs { get; set;}

[REDProp("globalTransitions")]
public Array<Ptr<CBehaviorGraphStateTransitionGlobalBlendNode>> GlobalTransitions { get; set;}

[REDProp("resetStateOnExit")]
public bool ResetStateOnExit { get; set;}

[REDProp("applySyncTags")]
public bool ApplySyncTags { get; set;}

[REDProp("cachedInputNode")]
public Ptr<CBehaviorGraphNode> CachedInputNode { get; set;}

[REDProp("rootBoneName")]
public string RootBoneName { get; set;}

[REDProp("blendRootParent")]
public bool BlendRootParent { get; set;}

[REDProp("defaultWeight")]
public float DefaultWeight { get; set;}

[REDProp("mergeEvents")]
public bool MergeEvents { get; set;}

#endregion
}
}