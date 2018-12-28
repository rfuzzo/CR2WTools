using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CTicketsDefaultConfiguration : CObject
{
#region RED Properties

[REDProp("tickets")]
public Array<CTicketSourceConfiguration> Tickets { get; set;}

#endregion
}
}