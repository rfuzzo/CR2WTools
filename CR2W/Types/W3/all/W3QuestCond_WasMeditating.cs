using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_WasMeditating : CQuestScriptedCondition
{
#region RED Properties

[REDProp("hours")]
public Int32 Hours { get; set;}

[REDProp("comparator")]
public ECompareOp Comparator { get; set;}

[REDProp("dayPart")]
public EDayPart DayPart { get; set;}

[REDProp("meditateToHour")]
public bool MeditateToHour { get; set;}

[REDProp("immediateTest")]
public bool ImmediateTest { get; set;}

[REDProp("isFulfilled")]
public bool IsFulfilled { get; set;}

[REDProp("listener")]
public Handle<W3QuestCond_WasMeditating_Listener> Listener { get; set;}

[REDProp("factsNames")]
public Array<string> FactsNames { get; set;}

#endregion
}
}