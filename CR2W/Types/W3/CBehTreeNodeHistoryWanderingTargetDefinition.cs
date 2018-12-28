using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeHistoryWanderingTargetDefinition : CBehTreeNodeWanderingTaggedTargetDecoratorDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("pointsGroupTag")]
public CBehTreeValCName PointsGroupTag { get; set;}

#endregion
}
}