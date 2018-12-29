using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondAnimalFlee : IBehTreeTask
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

[REDProp("rollSaysScared")]
public bool RollSaysScared { get; set;}

[REDProp("rerollChanceTime")]
public float RerollChanceTime { get; set;}

#endregion
}
}