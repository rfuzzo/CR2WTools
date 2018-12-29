using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAINpcCombatStyleParams : CAISubTreeParameters
{
#region RED Properties

[REDProp("LeftItemType")]
public CName LeftItemType { get; set;}

[REDProp("RightItemType")]
public CName RightItemType { get; set;}

[REDProp("chooseSilverIfPossible")]
public bool ChooseSilverIfPossible { get; set;}

[REDProp("behGraph")]
public EBehaviorGraph BehGraph { get; set;}

[REDProp("minCombatStyleDistance")]
public float MinCombatStyleDistance { get; set;}

[REDProp("defenseActions")]
public Array<Handle<CAINpcDefenseAction>> DefenseActions { get; set;}

[REDProp("combatTacticTree")]
public Handle<CAINpcTacticTree> CombatTacticTree { get; set;}

[REDProp("attackBehavior")]
public Handle<CAIAttackBehaviorTree> AttackBehavior { get; set;}

[REDProp("potentialFollower")]
public bool PotentialFollower { get; set;}

[REDProp("tryToUseFormation")]
public bool TryToUseFormation { get; set;}

[REDProp("formationTacticTree")]
public Handle<CAINpcFormationTacticTree> FormationTacticTree { get; set;}

#endregion
}
}