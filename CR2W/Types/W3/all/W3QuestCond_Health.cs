using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_Health : CQCActorScriptedCondition
{
#region RED Properties

[REDProp("condition")]
public ECompareOp Condition { get; set;}

[REDProp("percents")]
public Int32 Percents { get; set;}

#endregion
}
}