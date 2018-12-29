using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_SwitchState : CQuestScriptedCondition
{
#region RED Properties

[REDProp("switchTag")]
public CName SwitchTag { get; set;}

[REDProp("stateToCheck")]
public ESwitchStateCondition StateToCheck { get; set;}

[REDProp("switchEntity")]
public Handle<W3Switch> SwitchEntity { get; set;}

[REDProp("listener")]
public Handle<W3QuestCond_SwitchState_Listener> Listener { get; set;}

#endregion
}
}