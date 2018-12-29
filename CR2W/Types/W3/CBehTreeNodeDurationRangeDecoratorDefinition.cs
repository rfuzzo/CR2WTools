using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeNodeDurationRangeDecoratorDefinition : IBehTreeNodeDecoratorDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("durationMin")]
public CBehTreeValFloat DurationMin { get; set;}

[REDProp("durationMax")]
public CBehTreeValFloat DurationMax { get; set;}

[REDProp("endWithFailure")]
public bool EndWithFailure { get; set;}

#endregion
}
}