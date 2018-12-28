using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeAtomicLookAtDefinition : CBehTreeNodeCompleteImmediatelyDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("reportSuccess")]
public bool ReportSuccess { get; set;}

[REDProp("duration")]
public float Duration { get; set;}

[REDProp("player")]
public bool Player { get; set;}

[REDProp("actionTarget")]
public bool ActionTarget { get; set;}

[REDProp("combatTarget")]
public bool CombatTarget { get; set;}

[REDProp("reactionTarget")]
public bool ReactionTarget { get; set;}

[REDProp("namedTarget")]
public CName NamedTarget { get; set;}

#endregion
}
}