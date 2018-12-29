using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_CheckLightState : CQuestScriptedCondition
{
#region RED Properties

[REDProp("lightSourceTag")]
public CName LightSourceTag { get; set;}

[REDProp("targetState")]
public bool TargetState { get; set;}

[REDProp("lightEntity")]
public Handle<CEntity> LightEntity { get; set;}

[REDProp("component")]
public Handle<CGameplayLightComponent> Component { get; set;}

[REDProp("listener")]
public Handle<W3QuestCond_CheckLightState_Listener> Listener { get; set;}

#endregion
}
}