using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAINpcDefaults : CAIDefaults
{
#region RED Properties

[REDProp("npcGroupType")]
public Handle<CAINPCGroupTypeRedefinition> NpcGroupType { get; set;}

[REDProp("combatTree")]
public Handle<CAINpcCombat> CombatTree { get; set;}

[REDProp("idleTree")]
public Handle<CAIIdleTree> IdleTree { get; set;}

[REDProp("deathTree")]
public Handle<CAIDeathTree> DeathTree { get; set;}

[REDProp("reactionTree")]
public Handle<CAINpcReactionsTree> ReactionTree { get; set;}

[REDProp("softReactionTree")]
public Handle<CAISoftReactionTree> SoftReactionTree { get; set;}

[REDProp("hasDrinkingMinigame")]
public bool HasDrinkingMinigame { get; set;}

[REDProp("morphInCombat")]
public bool MorphInCombat { get; set;}

[REDProp("tempNpcGroupType")]
public ENPCGroupType TempNpcGroupType { get; set;}

#endregion
}
}