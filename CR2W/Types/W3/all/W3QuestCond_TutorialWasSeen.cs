using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_TutorialWasSeen : CQuestScriptedCondition
{
#region RED Properties

[REDProp("tutorialScriptTag")]
public CName TutorialScriptTag { get; set;}

#endregion
}
}