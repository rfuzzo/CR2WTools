using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_PlayerState : CQuestScriptedCondition
{
#region RED Properties

[REDProp("stateName")]
public CName StateName { get; set;}

[REDProp("playerState")]
public EQuestConditionPlayerState PlayerState { get; set;}

[REDProp("inverted")]
public bool Inverted { get; set;}

#endregion
}
}