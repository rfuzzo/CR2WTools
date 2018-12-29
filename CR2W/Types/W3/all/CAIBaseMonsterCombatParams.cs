using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIBaseMonsterCombatParams : CAICombatParameters
{
#region RED Properties

[REDProp("combatLogicTree")]
public Handle<CAIMonsterCombatLogic> CombatLogicTree { get; set;}

[REDProp("damageReactionTree")]
public Handle<CAIMonsterSimpleDamageReactionTree> DamageReactionTree { get; set;}

[REDProp("reachabilityTolerance")]
public float ReachabilityTolerance { get; set;}

[REDProp("targetOnlyPlayer")]
public bool TargetOnlyPlayer { get; set;}

[REDProp("hostileActorWeight")]
public float HostileActorWeight { get; set;}

[REDProp("currentTargetWeight")]
public float CurrentTargetWeight { get; set;}

[REDProp("rememberedHits")]
public Int32 RememberedHits { get; set;}

[REDProp("hitterWeight")]
public float HitterWeight { get; set;}

[REDProp("maxWeightedDistance")]
public float MaxWeightedDistance { get; set;}

[REDProp("distanceWeight")]
public float DistanceWeight { get; set;}

[REDProp("playerWeightProbability")]
public Int32 PlayerWeightProbability { get; set;}

[REDProp("playerWeight")]
public float PlayerWeight { get; set;}

[REDProp("skipVehicle")]
public ECombatTargetSelectionSkipTarget SkipVehicle { get; set;}

[REDProp("skipVehicleProbability")]
public Int32 SkipVehicleProbability { get; set;}

[REDProp("skipUnreachable")]
public ECombatTargetSelectionSkipTarget SkipUnreachable { get; set;}

[REDProp("skipUnreachableProbability")]
public Int32 SkipUnreachableProbability { get; set;}

[REDProp("skipNotThreatening")]
public ECombatTargetSelectionSkipTarget SkipNotThreatening { get; set;}

[REDProp("skipNotThreateningProbability")]
public Int32 SkipNotThreateningProbability { get; set;}

#endregion
}
}