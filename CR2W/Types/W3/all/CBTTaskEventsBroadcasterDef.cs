using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskEventsBroadcasterDef : IBehTreeReactionTaskDefinition
{
#region RED Properties

[REDProp("broadcastedEvents")]
public Array<SReactionEventData> BroadcastedEvents { get; set;}

[REDProp("rescanInterval")]
public float RescanInterval { get; set;}

[REDProp("minIntervalBetweenScenes")]
public float MinIntervalBetweenScenes { get; set;}

#endregion
}
}