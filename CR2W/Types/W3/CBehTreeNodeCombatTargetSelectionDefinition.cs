using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeNodeCombatTargetSelectionDefinition : IBehTreeNodeCombatTargetSelectionBaseDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("targetOnlyPlayer")]
public CBehTreeValBool TargetOnlyPlayer { get; set;}

[REDProp("hostileActorWeight")]
public CBehTreeValFloat HostileActorWeight { get; set;}

[REDProp("currentTargetWeight")]
public CBehTreeValFloat CurrentTargetWeight { get; set;}

[REDProp("rememberedHits")]
public CBehTreeValInt RememberedHits { get; set;}

[REDProp("hitterWeight")]
public CBehTreeValFloat HitterWeight { get; set;}

[REDProp("maxWeightedDistance")]
public CBehTreeValFloat MaxWeightedDistance { get; set;}

[REDProp("distanceWeight")]
public CBehTreeValFloat DistanceWeight { get; set;}

[REDProp("playerWeightProbability")]
public CBehTreeValInt PlayerWeightProbability { get; set;}

[REDProp("playerWeight")]
public CBehTreeValFloat PlayerWeight { get; set;}

[REDProp("monsterWeight")]
public CBehTreeValFloat MonsterWeight { get; set;}

[REDProp("skipVehicle")]
public CBehTreeValECombatTargetSelectionSkipTarget SkipVehicle { get; set;}

[REDProp("skipVehicleProbability")]
public CBehTreeValInt SkipVehicleProbability { get; set;}

[REDProp("skipUnreachable")]
public CBehTreeValECombatTargetSelectionSkipTarget SkipUnreachable { get; set;}

[REDProp("skipUnreachableProbability")]
public CBehTreeValInt SkipUnreachableProbability { get; set;}

[REDProp("skipNotThreatening")]
public CBehTreeValECombatTargetSelectionSkipTarget SkipNotThreatening { get; set;}

[REDProp("skipNotThreateningProbability")]
public CBehTreeValInt SkipNotThreateningProbability { get; set;}

#endregion
}
}