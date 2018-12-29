using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeNodeBroadcastReactionSceneDefinition : IBehTreeNodeCombatTicketDecoratorBaseDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("ticketName")]
public CName TicketName { get; set;}

[REDProp("ticketsProvider")]
public EBehTreeTicketSourceProviderType TicketsProvider { get; set;}

[REDProp("updateInterval")]
public float UpdateInterval { get; set;}

[REDProp("reactionScenesToBroadcast")]
public Array<SReactionSceneEvent> ReactionScenesToBroadcast { get; set;}

#endregion
}
}