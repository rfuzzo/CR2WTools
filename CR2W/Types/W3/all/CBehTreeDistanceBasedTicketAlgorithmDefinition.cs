using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeDistanceBasedTicketAlgorithmDefinition : IBehTreeTicketAlgorithmDefinition
{
#region RED Properties

[REDProp("distanceToImportance")]
public Array<CBehTreeDistanceBasedTicketAlgorithmField> DistanceToImportance { get; set;}

[REDProp("importanceMultiplier")]
public CBehTreeValFloat ImportanceMultiplier { get; set;}

#endregion
}
}