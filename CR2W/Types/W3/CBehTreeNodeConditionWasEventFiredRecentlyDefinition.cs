using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeConditionWasEventFiredRecentlyDefinition : IBehTreeNodeConditionWasEventFiredRecentlyBaseDefinition
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

[REDProp("activationTimeout")]
public float ActivationTimeout { get; set;}

[REDProp("executionTimeout")]
public float ExecutionTimeout { get; set;}

[REDProp("eventName")]
public CBehTreeValCName EventName { get; set;}

#endregion
}
}