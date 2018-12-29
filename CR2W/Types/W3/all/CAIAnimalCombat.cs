using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIAnimalCombat : CAICombatTree
{
#region RED Properties

[REDProp("chanceOfBeingScared")]
public float ChanceOfBeingScared { get; set;}

[REDProp("chanceOfBeingScaredRerollTime")]
public float ChanceOfBeingScaredRerollTime { get; set;}

[REDProp("scaredIfTargetRuns")]
public bool ScaredIfTargetRuns { get; set;}

[REDProp("maxTolerableTargetDistance")]
public float MaxTolerableTargetDistance { get; set;}

[REDProp("maxFleeRunDistance")]
public float MaxFleeRunDistance { get; set;}

[REDProp("maxFleeWalkDistance")]
public float MaxFleeWalkDistance { get; set;}

[REDProp("stopFleeingDistance")]
public float StopFleeingDistance { get; set;}

[REDProp("fleeInGroup")]
public bool FleeInGroup { get; set;}

[REDProp("neutralIsDanger")]
public bool NeutralIsDanger { get; set;}

#endregion
}
}