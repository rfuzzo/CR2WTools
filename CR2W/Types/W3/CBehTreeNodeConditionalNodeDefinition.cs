using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeNodeConditionalNodeDefinition : IBehTreeNodeConditionalBaseNodeDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("childNodeToDisableCount")]
public uint ChildNodeToDisableCount { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("invertCondition")]
public bool InvertCondition { get; set;}

[REDProp("val")]
public CBehTreeValBool Val { get; set;}

#endregion
}
}