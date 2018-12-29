using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_PlayerLevel : CQuestScriptedCondition
{
#region RED Properties

[REDProp("level")]
public Int32 Level { get; set;}

[REDProp("comparator")]
public ECompareOp Comparator { get; set;}

[REDProp("useComparator")]
public bool UseComparator { get; set;}

[REDProp("returnValue")]
public bool ReturnValue { get; set;}

#endregion
}
}