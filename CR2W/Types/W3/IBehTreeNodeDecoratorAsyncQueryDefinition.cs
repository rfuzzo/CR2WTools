using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class IBehTreeNodeDecoratorAsyncQueryDefinition : IBehTreeNodeDecoratorDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("queryName")]
public CName QueryName { get; set;}

[REDProp("queryValidFor")]
public float QueryValidFor { get; set;}

#endregion
}
}