using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIMonsterCombatParams : CAIBaseMonsterCombatParams
{
#region RED Properties

[REDProp("createHitReactionEvent")]
public CName CreateHitReactionEvent { get; set;}

[REDProp("IncreaseHitCounterOnlyOnMelee")]
public bool IncreaseHitCounterOnlyOnMelee { get; set;}

[REDProp("criticalState")]
public Handle<CAINpcCriticalState> CriticalState { get; set;}

[REDProp("reactionTree")]
public Handle<CAIMonsterCombatReactionsTree> ReactionTree { get; set;}

#endregion
}
}