using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_CanSeePlayer : CQuestScriptedCondition
{
#region RED Properties

[REDProp("actorTag")]
public CName ActorTag { get; set;}

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

[REDProp("listener")]
public Handle<W3QuestCond_CanSeePlayer_Listener> Listener { get; set;}

#endregion
}
}