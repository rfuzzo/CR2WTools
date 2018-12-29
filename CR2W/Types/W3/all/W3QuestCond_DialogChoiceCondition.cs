using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_DialogChoiceCondition : CQuestScriptedCondition
{
#region RED Properties

[REDProp("dialogChoice")]
public EDialogActionIcon DialogChoice { get; set;}

[REDProp("onOptionSelected")]
public bool OnOptionSelected { get; set;}

#endregion
}
}