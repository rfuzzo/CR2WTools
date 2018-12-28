using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeCombatTicketReleaseDefinition : IBehTreeNodeCombatTicketDecoratorBaseDefinition
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

[REDProp("releaseOnActivation")]
public bool ReleaseOnActivation { get; set;}

[REDProp("releaseOnDeactivation")]
public bool ReleaseOnDeactivation { get; set;}

[REDProp("releaseOnCompletion")]
public bool ReleaseOnCompletion { get; set;}

#endregion
}
}