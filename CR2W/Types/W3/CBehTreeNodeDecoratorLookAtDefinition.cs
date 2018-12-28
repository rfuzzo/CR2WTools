using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeDecoratorLookAtDefinition : IBehTreeNodeDecoratorDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("durationPostDeactivation")]
public float DurationPostDeactivation { get; set;}

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