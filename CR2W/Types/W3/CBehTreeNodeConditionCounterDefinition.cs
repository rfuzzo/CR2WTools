using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeConditionCounterDefinition : CBehTreeNodeConditionDefinition
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

[REDProp("counterName")]
public CBehTreeValCName CounterName { get; set;}

[REDProp("counterLowerBound")]
public CBehTreeValInt CounterLowerBound { get; set;}

[REDProp("counterUpperBound")]
public CBehTreeValInt CounterUpperBound { get; set;}

#endregion
}
}