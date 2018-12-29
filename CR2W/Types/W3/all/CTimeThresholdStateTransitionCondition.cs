using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CTimeThresholdStateTransitionCondition : IBehaviorStateTransitionCondition
{
#region RED Properties

[REDProp("minActivationTime")]
public float MinActivationTime { get; set;}

[REDProp("maxActivationTime")]
public float MaxActivationTime { get; set;}

[REDProp("resetTime")]
public bool ResetTime { get; set;}

#endregion
}
}