using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeNodeSelectTargetOrMountByTagDecoratorDefinition : IBehTreeNodeDecoratorDefinition
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