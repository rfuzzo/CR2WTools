using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeCombatTicketManagerDefinition : IBehTreeNodeCombatTicketDecoratorBaseDefinition
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

[REDProp("ticketsCount")]
public CBehTreeValInt TicketsCount { get; set;}

[REDProp("importanceUpdateDelay")]
public float ImportanceUpdateDelay { get; set;}

[REDProp("ticketAlgorithm")]
public Ptr<IBehTreeTicketAlgorithmDefinition> TicketAlgorithm { get; set;}

#endregion
}
}