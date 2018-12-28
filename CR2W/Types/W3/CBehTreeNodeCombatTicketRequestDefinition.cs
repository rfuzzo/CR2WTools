using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeCombatTicketRequestDefinition : IBehTreeNodeCombatTicketDecoratorBaseDefinition
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

[REDProp("ticketRequestValidTime")]
public float TicketRequestValidTime { get; set;}

[REDProp("requestOnCompletion")]
public bool RequestOnCompletion { get; set;}

[REDProp("requestOnInterruption")]
public bool RequestOnInterruption { get; set;}

[REDProp("requestWhileActive")]
public bool RequestWhileActive { get; set;}

#endregion
}
}