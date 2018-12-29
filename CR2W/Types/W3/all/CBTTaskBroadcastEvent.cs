using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskBroadcastEvent : IBehTreeTask
{
#region RED Properties

[REDProp("owner")]
public Handle<CNewNPC> Owner { get; set;}

[REDProp("eventName")]
public CName EventName { get; set;}

[REDProp("lifetime")]
public float Lifetime { get; set;}

[REDProp("distance")]
public float Distance { get; set;}

[REDProp("broadcastInterval")]
public float BroadcastInterval { get; set;}

[REDProp("recipientCount")]
public Int32 RecipientCount { get; set;}

[REDProp("broadcastScene")]
public bool BroadcastScene { get; set;}

[REDProp("skipInvoker")]
public bool SkipInvoker { get; set;}

#endregion
}
}