using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class IBehTreeTicketAlgorithmListDefinition : IBehTreeTicketAlgorithmDefinition
{
#region RED Properties

[REDProp("list")]
public Array<Ptr<IBehTreeTicketAlgorithmDefinition>> List { get; set;}

#endregion
}
}