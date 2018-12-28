using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeDecoratorSelectFleeDestinationDefinition : IBehTreeNodeDecoratorDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("fleeRadius")]
public CBehTreeValFloat FleeRadius { get; set;}

[REDProp("minDistanceFromDanger")]
public CBehTreeValFloat MinDistanceFromDanger { get; set;}

#endregion
}
}