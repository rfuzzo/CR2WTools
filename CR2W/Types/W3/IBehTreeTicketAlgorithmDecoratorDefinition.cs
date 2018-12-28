using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class IBehTreeTicketAlgorithmDecoratorDefinition : IBehTreeTicketAlgorithmDefinition
{
#region RED Properties

[REDProp("baseAlgorithm")]
public Ptr<IBehTreeTicketAlgorithmDefinition> BaseAlgorithm { get; set;}

#endregion
}
}