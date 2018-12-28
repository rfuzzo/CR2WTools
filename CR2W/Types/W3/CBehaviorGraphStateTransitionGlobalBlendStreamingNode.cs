using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphStateTransitionGlobalBlendStreamingNode : CBehaviorGraphStateTransitionGlobalBlendNode
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

[REDProp("includeGroup")]
public TagList IncludeGroup { get; set;}

[REDProp("excludeGroup")]
public TagList ExcludeGroup { get; set;}

[REDProp("generateEventForDestState")]
public CName GenerateEventForDestState { get; set;}

[REDProp("generateForcedEventForDestState")]
public CName GenerateForcedEventForDestState { get; set;}

[REDProp("cachePoseFromPrevSampling")]
public bool CachePoseFromPrevSampling { get; set;}

[REDProp("useProgressiveSampilngForBlending")]
public bool UseProgressiveSampilngForBlending { get; set;}

[REDProp("defaultStateName")]
public string DefaultStateName { get; set;}

[REDProp("defaultState")]
public Ptr<CBehaviorGraphStateNode> DefaultState { get; set;}

#endregion
}
}