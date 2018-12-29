using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CAnimationEndCondition : IBehaviorStateTransitionCondition
{
#region RED Properties

[REDProp("useTransitionTimeOffset")]
public bool UseTransitionTimeOffset { get; set;}

[REDProp("backTimeOffset")]
public float BackTimeOffset { get; set;}

#endregion
}
}