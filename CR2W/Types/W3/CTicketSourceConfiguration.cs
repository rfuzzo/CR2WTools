using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CTicketSourceConfiguration 
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("ticketsPoolSize")]
public UInt16 TicketsPoolSize { get; set;}

[REDProp("minimalImportance")]
public float MinimalImportance { get; set;}

#endregion
}
}