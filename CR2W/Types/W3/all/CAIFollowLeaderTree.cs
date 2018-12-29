using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIFollowLeaderTree : IAIIdleFormationTree
{
#region RED Properties

[REDProp("leaderName")]
public CName LeaderName { get; set;}

[REDProp("disableGestures")]
public bool DisableGestures { get; set;}

[REDProp("removePlayedAnimationFromPool")]
public bool RemovePlayedAnimationFromPool { get; set;}

[REDProp("gossipGesturesOnly")]
public bool GossipGesturesOnly { get; set;}

[REDProp("cooldownBetweenGesture")]
public float CooldownBetweenGesture { get; set;}

[REDProp("chanceToPlayGesture")]
public float ChanceToPlayGesture { get; set;}

[REDProp("dontActivateGestureWhenNotTalking")]
public bool DontActivateGestureWhenNotTalking { get; set;}

[REDProp("onlyOneActorGesticulatingAtATime")]
public bool OnlyOneActorGesticulatingAtATime { get; set;}

[REDProp("stopGestureOnDeactivate")]
public bool StopGestureOnDeactivate { get; set;}

[REDProp("dontOverrideRightHand")]
public bool DontOverrideRightHand { get; set;}

[REDProp("dontOverrideLeftHand")]
public bool DontOverrideLeftHand { get; set;}

#endregion
}
}