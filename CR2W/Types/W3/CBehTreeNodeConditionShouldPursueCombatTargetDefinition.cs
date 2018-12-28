using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeConditionShouldPursueCombatTargetDefinition : CBehTreeNodeConditionDefinition
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

[REDProp("allowPursueInDistance")]
public CBehTreeValFloat AllowPursueInDistance { get; set;}

[REDProp("allowPursueInCombat")]
public bool AllowPursueInCombat { get; set;}

[REDProp("testReachability")]
public bool TestReachability { get; set;}

#endregion
}
}