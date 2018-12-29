using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_IsTargetOf : CQCActorScriptedCondition
{
#region RED Properties

[REDProp("attackerTag")]
public CName AttackerTag { get; set;}

[REDProp("attacker")]
public Handle<CActor> Attacker { get; set;}

[REDProp("listener")]
public Handle<W3QuestCond_IsTargetOf_Listener> Listener { get; set;}

#endregion
}
}