using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_UsedFocus : CQuestScriptedCondition
{
#region RED Properties

[REDProp("inverted")]
public bool Inverted { get; set;}

[REDProp("duration")]
public float Duration { get; set;}

[REDProp("timeStart")]
public float TimeStart { get; set;}

#endregion
}
}