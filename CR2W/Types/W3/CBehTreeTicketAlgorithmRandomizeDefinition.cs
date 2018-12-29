using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeTicketAlgorithmRandomizeDefinition : IBehTreeTicketAlgorithmDecoratorDefinition
{
#region RED Properties

[REDProp("baseAlgorithm")]
public Ptr<IBehTreeTicketAlgorithmDefinition> BaseAlgorithm { get; set;}

[REDProp("randMin")]
public CBehTreeValFloat RandMin { get; set;}

[REDProp("randMax")]
public CBehTreeValFloat RandMax { get; set;}

#endregion
}
}