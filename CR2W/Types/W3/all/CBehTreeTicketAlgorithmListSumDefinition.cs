using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeTicketAlgorithmListSumDefinition : IBehTreeTicketAlgorithmListDefinition
{
#region RED Properties

[REDProp("list")]
public Array<Ptr<IBehTreeTicketAlgorithmDefinition>> List { get; set;}

#endregion
}
}