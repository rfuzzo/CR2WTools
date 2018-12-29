using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_ReusableClueUsed : CQuestScriptedCondition
{
#region RED Properties

[REDProp("clueTag")]
public CName ClueTag { get; set;}

[REDProp("resetClue")]
public bool ResetClue { get; set;}

[REDProp("leaveFacts")]
public bool LeaveFacts { get; set;}

[REDProp("keepFocusHighlight")]
public bool KeepFocusHighlight { get; set;}

[REDProp("isFulfilled")]
public bool IsFulfilled { get; set;}

[REDProp("listener")]
public Handle<W3QuestCond_ReusableClueUsed_Listener> Listener { get; set;}

#endregion
}
}