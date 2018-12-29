using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeNodeSelectActionPointDecoratorDefinition : IBehTreeNodeDecoratorDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("delayOnFailure")]
public CBehTreeValFloat DelayOnFailure { get; set;}

[REDProp("delayOnSuccess")]
public CBehTreeValFloat DelayOnSuccess { get; set;}

[REDProp("delayOnInterruption")]
public CBehTreeValFloat DelayOnInterruption { get; set;}

#endregion
}
}