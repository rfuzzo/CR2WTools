using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphBlendMultipleCondNode_Multi : IBehaviorGraphBlendMultipleCondNode_Condition
{
#region RED Properties

[REDProp("conditions")]
public Array<Ptr<IBehaviorGraphBlendMultipleCondNode_Condition>> Conditions { get; set;}

[REDProp("logicAndOr")]
public bool LogicAndOr { get; set;}

#endregion
}
}