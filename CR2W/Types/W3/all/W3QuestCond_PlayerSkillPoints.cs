using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_PlayerSkillPoints : CQuestScriptedCondition
{
#region RED Properties

[REDProp("freeSkillPoints")]
public Int32 FreeSkillPoints { get; set;}

[REDProp("comparator")]
public ECompareOp Comparator { get; set;}

#endregion
}
}