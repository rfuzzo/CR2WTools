using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CDelayStateTransitionCondition : IBehaviorStateTransitionCondition
{
#region RED Properties

[REDProp("delayTime")]
public float DelayTime { get; set;}

[REDProp("resetTime")]
public bool ResetTime { get; set;}

#endregion
}
}