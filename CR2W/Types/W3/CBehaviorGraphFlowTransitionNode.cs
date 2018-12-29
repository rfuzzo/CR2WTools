using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphFlowTransitionNode : CBehaviorGraphStateTransitionBlendNode
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

[REDProp("transitionPriority")]
public float TransitionPriority { get; set;}

[REDProp("isEnabled")]
public bool IsEnabled { get; set;}

[REDProp("transitionCondition")]
public Ptr<IBehaviorStateTransitionCondition> TransitionCondition { get; set;}

[REDProp("setInternalVariables")]
public Array<SBehaviorGraphTransitionSetInternalVariable> SetInternalVariables { get; set;}

[REDProp("cachedStartStateNode")]
public Ptr<CBehaviorGraphStateNode> CachedStartStateNode { get; set;}

[REDProp("cachedEndStateNode")]
public Ptr<CBehaviorGraphStateNode> CachedEndStateNode { get; set;}

[REDProp("transitionTime")]
public float TransitionTime { get; set;}

[REDProp("synchronize")]
public bool Synchronize { get; set;}

[REDProp("syncMethod")]
public Ptr<IBehaviorSyncMethod> SyncMethod { get; set;}

[REDProp("motionBlendType")]
public EBehaviorTransitionBlendMotion MotionBlendType { get; set;}

#endregion
}
}