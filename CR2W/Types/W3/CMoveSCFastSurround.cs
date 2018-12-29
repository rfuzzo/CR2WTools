using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CMoveSCFastSurround : IMoveSteeringCondition
{
#region RED Properties

[REDProp("usageDelay")]
public float UsageDelay { get; set;}

[REDProp("angleDistanceToActivate")]
public float AngleDistanceToActivate { get; set;}

[REDProp("speedMinToActivate")]
public float SpeedMinToActivate { get; set;}

[REDProp("angleDistanceToBreak")]
public float AngleDistanceToBreak { get; set;}

[REDProp("speedMinLimitToBreak")]
public float SpeedMinLimitToBreak { get; set;}

#endregion
}
}