using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeNodeCombatTicketHasDefinition : IBehTreeNodeCombatTicketDecoratorBaseDefinition
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

[REDProp("lockTicket")]
public bool LockTicket { get; set;}

[REDProp("ifNotHave")]
public bool IfNotHave { get; set;}

[REDProp("failsWhenTicketIsLost")]
public bool FailsWhenTicketIsLost { get; set;}

#endregion
}
}