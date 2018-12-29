using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskGesturesManagerDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("disableGestures")]
public CBehTreeValBool DisableGestures { get; set;}

[REDProp("removePlayedAnimationFromPool")]
public CBehTreeValBool RemovePlayedAnimationFromPool { get; set;}

[REDProp("gossipGesturesOnly")]
public CBehTreeValBool GossipGesturesOnly { get; set;}

[REDProp("cooldownBetweenGesture")]
public CBehTreeValFloat CooldownBetweenGesture { get; set;}

[REDProp("chanceToPlayGesture")]
public CBehTreeValFloat ChanceToPlayGesture { get; set;}

[REDProp("dontActivateGestureWhenNotTalking")]
public CBehTreeValBool DontActivateGestureWhenNotTalking { get; set;}

[REDProp("onlyOneActorGesticulatingAtATime")]
public CBehTreeValBool OnlyOneActorGesticulatingAtATime { get; set;}

[REDProp("stopGestureOnDeactivate")]
public CBehTreeValBool StopGestureOnDeactivate { get; set;}

[REDProp("dontOverrideRightHand")]
public CBehTreeValBool DontOverrideRightHand { get; set;}

[REDProp("dontOverrideLeftHand")]
public CBehTreeValBool DontOverrideLeftHand { get; set;}

#endregion
}
}