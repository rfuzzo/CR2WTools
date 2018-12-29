using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_CheckBrazierPuzzleState : CQuestScriptedCondition
{
#region RED Properties

[REDProp("lightList")]
public Array<CName> LightList { get; set;}

[REDProp("lightsToTurnOn")]
public Array<Int32> LightsToTurnOn { get; set;}

[REDProp("componentList")]
public Array<Handle<CComponent>> ComponentList { get; set;}

[REDProp("expectedState")]
public Array<bool> ExpectedState { get; set;}

[REDProp("componentsFound")]
public bool ComponentsFound { get; set;}

[REDProp("statesDefined")]
public bool StatesDefined { get; set;}

#endregion
}
}