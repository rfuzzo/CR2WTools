using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeSelectTargetByTagDecoratorDefinition : IBehTreeNodeDecoratorDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("tag")]
public CBehTreeValCName Tag { get; set;}

[REDProp("allowActivationWhenNoTarget")]
public bool AllowActivationWhenNoTarget { get; set;}

#endregion
}
}