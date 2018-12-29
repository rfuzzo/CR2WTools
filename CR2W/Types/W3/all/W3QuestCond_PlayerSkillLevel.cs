using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_PlayerSkillLevel : CQuestScriptedCondition
{
#region RED Properties

[REDProp("mode")]
public EQuestPlayerSkillLevel Mode { get; set;}

[REDProp("skills")]
public Array<SQuestPlayerSkill> Skills { get; set;}

[REDProp("dialogAxiiLevel")]
public Int32 DialogAxiiLevel { get; set;}

#endregion
}
}