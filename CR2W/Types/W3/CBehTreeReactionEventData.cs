using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeReactionEventData : CObject
{
#region RED Properties

[REDProp("eventName")]
public CName EventName { get; set;}

[REDProp("lifetime")]
public float Lifetime { get; set;}

[REDProp("broadcastInterval")]
public float BroadcastInterval { get; set;}

[REDProp("distanceRange")]
public float DistanceRange { get; set;}

[REDProp("recipientCount")]
public int RecipientCount { get; set;}

#endregion
}
}