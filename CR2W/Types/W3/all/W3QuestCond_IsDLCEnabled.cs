using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_IsDLCEnabled : CQuestScriptedCondition
{
#region RED Properties

[REDProp("dlc")]
public EQuestConditionDLCType Dlc { get; set;}

[REDProp("invert")]
public bool Invert { get; set;}

#endregion
}
}