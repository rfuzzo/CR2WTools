using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorGraphBlendMultipleCondNode_AnimEvent : IBehaviorGraphBlendMultipleCondNode_Condition
{
#region RED Properties

[REDProp("animEventName")]
public CName AnimEventName { get; set;}

#endregion
}
}