using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeNodeDurationDecoratorDefinition : IBehTreeNodeDecoratorDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("duration")]
public CBehTreeValFloat Duration { get; set;}

[REDProp("chance")]
public CBehTreeValFloat Chance { get; set;}

[REDProp("endWithFailure")]
public bool EndWithFailure { get; set;}

#endregion
}
}