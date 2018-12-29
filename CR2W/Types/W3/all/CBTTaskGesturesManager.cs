using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskGesturesManager : IBehTreeTask
{
#region RED Properties

[REDProp("disableGestures")]
public bool DisableGestures { get; set;}

[REDProp("removePlayedAnimationFromPool")]
public bool RemovePlayedAnimationFromPool { get; set;}

[REDProp("gossipGesturesOnly")]
public bool GossipGesturesOnly { get; set;}

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

[REDProp("cooldownBetweenGesture")]
public float CooldownBetweenGesture { get; set;}

[REDProp("chanceToPlayGesture")]
public float ChanceToPlayGesture { get; set;}

[REDProp("m_animListLeftHand")]
public Array<CName> M_animListLeftHand { get; set;}

[REDProp("m_animListRightHand")]
public Array<CName> M_animListRightHand { get; set;}

[REDProp("m_animListBothHands")]
public Array<CName> M_animListBothHands { get; set;}

[REDProp("m_animList")]
public Array<CName> M_animList { get; set;}

[REDProp("animListLeftHand")]
public Array<CName> AnimListLeftHand { get; set;}

[REDProp("animListRightHand")]
public Array<CName> AnimListRightHand { get; set;}

[REDProp("animListBothHands")]
public Array<CName> AnimListBothHands { get; set;}

[REDProp("animList")]
public Array<CName> AnimList { get; set;}

[REDProp("timeStamp")]
public float TimeStamp { get; set;}

[REDProp("reactionEventTimeStamp")]
public float ReactionEventTimeStamp { get; set;}

[REDProp("itemInLeftHand")]
public bool ItemInLeftHand { get; set;}

[REDProp("itemInRightHand")]
public bool ItemInRightHand { get; set;}

#endregion
}
}