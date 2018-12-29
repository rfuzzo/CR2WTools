using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeConstantTicketAlgorithmDefinition : IBehTreeTicketAlgorithmDefinition
{
#region RED Properties

[REDProp("importance")]
public CBehTreeValFloat Importance { get; set;}

#endregion
}
}