using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeCombatTicketManagedGetDefinition : CBehTreeNodeCombatTicketManagerDefinition
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

[REDProp("locksTicket")]
public bool LocksTicket { get; set;}

[REDProp("freesTicket")]
public bool FreesTicket { get; set;}

[REDProp("failsWhenTicketIsLost")]
public bool FailsWhenTicketIsLost { get; set;}

[REDProp("ticketRequestValidTime")]
public float TicketRequestValidTime { get; set;}

#endregion
}
}