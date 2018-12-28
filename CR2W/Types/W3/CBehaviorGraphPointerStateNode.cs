using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphPointerStateNode : CBehaviorGraphStateNode
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

[REDProp("groups")]
public TagList Groups { get; set;}

[REDProp("behaviorGraphSyncInfo")]
public SBehaviorGraphStateBehaviorGraphSyncInfo BehaviorGraphSyncInfo { get; set;}

[REDProp("cachedStateTransitions")]
public Array<Ptr<CBehaviorGraphStateTransitionNode>> CachedStateTransitions { get; set;}

[REDProp("pointedStateName")]
public string PointedStateName { get; set;}

#endregion
}
}