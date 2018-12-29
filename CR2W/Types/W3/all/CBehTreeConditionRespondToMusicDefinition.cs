using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeConditionRespondToMusicDefinition : CBehTreeNodeConditionDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("forwardAvailability")]
public bool ForwardAvailability { get; set;}

[REDProp("forwardTestIfNotAvailable")]
public bool ForwardTestIfNotAvailable { get; set;}

[REDProp("invertAvailability")]
public bool InvertAvailability { get; set;}

[REDProp("skipIfActive")]
public bool SkipIfActive { get; set;}

[REDProp("musicWaitTimeLimit")]
public CBehTreeValFloat MusicWaitTimeLimit { get; set;}

[REDProp("syncTimeOffset")]
public CBehTreeValFloat SyncTimeOffset { get; set;}

[REDProp("syncTypes")]
public CBehTreeValString SyncTypes { get; set;}

[REDProp("musicEventToTrigger")]
public CBehTreeValString MusicEventToTrigger { get; set;}

[REDProp("musicEventPreTriggerTime")]
public CBehTreeValFloat MusicEventPreTriggerTime { get; set;}

[REDProp("alwaysTriggerEvent")]
public CBehTreeValBool AlwaysTriggerEvent { get; set;}

#endregion
}
}