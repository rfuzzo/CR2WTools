using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_UncoveredBoatFTPoint : CQuestScriptedCondition
{
#region RED Properties

[REDProp("isFulfilled")]
public bool IsFulfilled { get; set;}

[REDProp("listener")]
public Handle<W3QuestCond_UncoveredBoatFTPoint_Listener> Listener { get; set;}

#endregion
}
}