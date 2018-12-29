using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAINpcCombatParams : CAICombatParameters
{
#region RED Properties

[REDProp("scaredCombat")]
public bool ScaredCombat { get; set;}

[REDProp("scaredBranch")]
public Handle<CAIScaredSubTree> ScaredBranch { get; set;}

[REDProp("combatStyles")]
public Array<Handle<CAINpcCombatStyle>> CombatStyles { get; set;}

[REDProp("criticalState")]
public Handle<CAINpcCriticalState> CriticalState { get; set;}

[REDProp("preferedCombatStyle")]
public EBehaviorGraph PreferedCombatStyle { get; set;}

[REDProp("increaseHitCounterOnlyOnMelee")]
public bool IncreaseHitCounterOnlyOnMelee { get; set;}

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

[REDProp("monsterWeight")]
public float MonsterWeight { get; set;}

#endregion
}
}