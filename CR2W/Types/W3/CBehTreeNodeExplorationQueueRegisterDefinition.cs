using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeExplorationQueueRegisterDefinition : IBehTreeNodeExplorationQueueDecoratorDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("timePriority")]
public float TimePriority { get; set;}

[REDProp("distancePriority")]
public float DistancePriority { get; set;}

[REDProp("maxTime")]
public float MaxTime { get; set;}

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

#endregion
}
}