using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSignalReactionEventDef : IBehTreeReactionTaskDefinition
{
#region RED Properties

[REDProp("reactionEventName")]
public CBehTreeValCName ReactionEventName { get; set;}

[REDProp("lifeTime")]
public float LifeTime { get; set;}

[REDProp("distanceRange")]
public CBehTreeValFloat DistanceRange { get; set;}

[REDProp("broadcastInterval")]
public float BroadcastInterval { get; set;}

[REDProp("recipientCount")]
public CBehTreeValInt RecipientCount { get; set;}

[REDProp("setActionTargetOnBroadcast")]
public bool SetActionTargetOnBroadcast { get; set;}

[REDProp("skipInvoker")]
public bool SkipInvoker { get; set;}

[REDProp("disableOnDeactivate")]
public bool DisableOnDeactivate { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("onSuccess")]
public bool OnSuccess { get; set;}

[REDProp("onFailure")]
public bool OnFailure { get; set;}

[REDProp("onAnimEvent")]
public bool OnAnimEvent { get; set;}

[REDProp("eventName")]
public CName EventName { get; set;}

#endregion
}
}