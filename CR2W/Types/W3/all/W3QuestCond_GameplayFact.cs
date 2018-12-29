using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_GameplayFact : CQuestScriptedCondition
{
#region RED Properties

[REDProp("gameplayFactId")]
public string GameplayFactId { get; set;}

[REDProp("value")]
public Int32 Value { get; set;}

[REDProp("comparator")]
public ECompareOp Comparator { get; set;}

[REDProp("isFulfilled")]
public bool IsFulfilled { get; set;}

[REDProp("listener")]
public Handle<W3QuestCond_GameplayFact_Listener> Listener { get; set;}

#endregion
}
}