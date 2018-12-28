using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeRiderRotateToHorseDefinition : CBehTreeNodeBaseRotateToTargetDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("completeOnTargetReached")]
public bool CompleteOnTargetReached { get; set;}

#endregion
}
}