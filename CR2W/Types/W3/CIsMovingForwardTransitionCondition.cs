using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CIsMovingForwardTransitionCondition : IBehaviorStateTransitionCondition
{
#region RED Properties

[REDProp("maxOffAngle")]
public float MaxOffAngle { get; set;}

[REDProp("notMovingForward")]
public bool NotMovingForward { get; set;}

#endregion
}
}