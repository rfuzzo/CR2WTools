using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeNodeDecoratorPriorityOnSemaphoreDefinition : IBehTreeNodeDecoratorDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("counterName")]
public CBehTreeValCName CounterName { get; set;}

[REDProp("counterValue")]
public CBehTreeValInt CounterValue { get; set;}

[REDProp("comparison")]
public ECompareFunc Comparison { get; set;}

#endregion
}
}