using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeAtomicDamageReactionDefinition : CBehTreeNodeAtomicPlayAnimationEventDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("shouldForceEvent")]
public bool ShouldForceEvent { get; set;}

[REDProp("eventStateName")]
public CBehTreeValCName EventStateName { get; set;}

[REDProp("eventResetTriggerName")]
public CName EventResetTriggerName { get; set;}

[REDProp("delay")]
public float Delay { get; set;}

#endregion
}
}