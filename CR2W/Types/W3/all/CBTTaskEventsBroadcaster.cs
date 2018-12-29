using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskEventsBroadcaster : IBehTreeTask
{
#region RED Properties

[REDProp("broadcastedEvents")]
public Array<SReactionEventData> BroadcastedEvents { get; set;}

[REDProp("rescanInterval")]
public float RescanInterval { get; set;}

[REDProp("minIntervalBetweenScenes")]
public float MinIntervalBetweenScenes { get; set;}

[REDProp("owner")]
public Handle<CNewNPC> Owner { get; set;}

[REDProp("i")]
public Int32 I { get; set;}

[REDProp("eventsCount")]
public Int32 EventsCount { get; set;}

[REDProp("currentTime")]
public float CurrentTime { get; set;}

[REDProp("timeOfLastScene")]
public float TimeOfLastScene { get; set;}

#endregion
}
}