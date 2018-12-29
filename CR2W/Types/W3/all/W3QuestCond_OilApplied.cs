using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_OilApplied : CQuestScriptedCondition
{
#region RED Properties

[REDProp("swordType")]
public EQuestSword SwordType { get; set;}

[REDProp("oilName")]
public CName OilName { get; set;}

[REDProp("isFulfilled")]
public bool IsFulfilled { get; set;}

[REDProp("listener")]
public Handle<W3QuestCond_OilApplied_Listener> Listener { get; set;}

#endregion
}
}