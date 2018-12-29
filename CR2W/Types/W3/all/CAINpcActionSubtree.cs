using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAINpcActionSubtree : CAISubTree
{
#region RED Properties

[REDProp("reactionLogicTree")]
public Handle<CAINpcReaction> ReactionLogicTree { get; set;}

[REDProp("reactionPriority")]
public Int32 ReactionPriority { get; set;}

[REDProp("actionEventName")]
public CName ActionEventName { get; set;}

[REDProp("actionCooldownDistance")]
public float ActionCooldownDistance { get; set;}

[REDProp("actionCooldownTimeout")]
public float ActionCooldownTimeout { get; set;}

[REDProp("actionFailedCooldown")]
public float ActionFailedCooldown { get; set;}

[REDProp("dontSetActionTarget")]
public bool DontSetActionTarget { get; set;}

[REDProp("changePriorityWhileActive")]
public bool ChangePriorityWhileActive { get; set;}

[REDProp("reactionPriorityWhileActive")]
public Int32 ReactionPriorityWhileActive { get; set;}

[REDProp("disallowOutsideOfGuardArea")]
public bool DisallowOutsideOfGuardArea { get; set;}

[REDProp("forwardAvailabilityToReactionTree")]
public bool ForwardAvailabilityToReactionTree { get; set;}

[REDProp("disableTalkInteraction")]
public bool DisableTalkInteraction { get; set;}

[REDProp("disallowWhileOnHorse")]
public bool DisallowWhileOnHorse { get; set;}

#endregion
}
}