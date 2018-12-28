using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeConditionClearLineToTargetDefinition : CBehTreeNodeConditionDefinition
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

[REDProp("combatTarget")]
public bool CombatTarget { get; set;}

[REDProp("navTest")]
public bool NavTest { get; set;}

[REDProp("creatureTest")]
public bool CreatureTest { get; set;}

[REDProp("useAgentRadius")]
public bool UseAgentRadius { get; set;}

[REDProp("customRadius")]
public CBehTreeValFloat CustomRadius { get; set;}

#endregion
}
}