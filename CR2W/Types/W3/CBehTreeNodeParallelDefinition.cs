using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeParallelDefinition : IBehTreeNodeSpecialDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child1")]
public Ptr<IBehTreeNodeDefinition> Child1 { get; set;}

[REDProp("child2")]
public Ptr<IBehTreeNodeDefinition> Child2 { get; set;}

#endregion
}
}