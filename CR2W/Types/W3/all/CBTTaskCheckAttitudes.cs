using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskCheckAttitudes : IBehTreeTask
{
#region RED Properties

[REDProp("onlyHelpActorsFromTheSameAttidueGroup")]
public bool OnlyHelpActorsFromTheSameAttidueGroup { get; set;}

[REDProp("useReactionTarget")]
public bool UseReactionTarget { get; set;}

[REDProp("owner")]
public Handle<CActor> Owner { get; set;}

[REDProp("sender")]
public Handle<CActor> Sender { get; set;}

[REDProp("sendersTarget")]
public Handle<CActor> SendersTarget { get; set;}

[REDProp("attitudeToSender")]
public EAIAttitude AttitudeToSender { get; set;}

[REDProp("attitudeToSendersTarget")]
public EAIAttitude AttitudeToSendersTarget { get; set;}

[REDProp("senderAttitudeGroup")]
public CName SenderAttitudeGroup { get; set;}

[REDProp("sendersTargetAttitudeGroup")]
public CName SendersTargetAttitudeGroup { get; set;}

[REDProp("ownerAttitudeGroup")]
public CName OwnerAttitudeGroup { get; set;}

[REDProp("actorToChangeAttitude")]
public Handle<CActor> ActorToChangeAttitude { get; set;}

[REDProp("reactionDataStorage")]
public Handle<CAIStorageReactionData> ReactionDataStorage { get; set;}

#endregion
}
}