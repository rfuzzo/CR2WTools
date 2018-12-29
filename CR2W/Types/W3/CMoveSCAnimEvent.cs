using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CMoveSCAnimEvent : IMoveSteeringCondition
{
#region RED Properties

[REDProp("eventName")]
public CName EventName { get; set;}

[REDProp("eventType")]
public EAnimationEventType EventType { get; set;}

#endregion
}
}