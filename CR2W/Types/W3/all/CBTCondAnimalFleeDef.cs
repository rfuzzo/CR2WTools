using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondAnimalFleeDef : IBehTreeHorseConditionalTaskDefinition
{
#region RED Properties

[REDProp("chanceOfBeingScared")]
public CBehTreeValFloat ChanceOfBeingScared { get; set;}

[REDProp("chanceOfBeingScaredRerollTime")]
public CBehTreeValFloat ChanceOfBeingScaredRerollTime { get; set;}

[REDProp("scaredIfTargetRuns")]
public CBehTreeValBool ScaredIfTargetRuns { get; set;}

[REDProp("maxTolerableTargetDistance")]
public CBehTreeValFloat MaxTolerableTargetDistance { get; set;}

#endregion
}
}