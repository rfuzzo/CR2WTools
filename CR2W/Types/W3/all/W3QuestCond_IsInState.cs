using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_IsInState : CQCActorScriptedCondition
{
#region RED Properties

[REDProp("actorState")]
public EQuestNPCStates ActorState { get; set;}

#endregion
}
}