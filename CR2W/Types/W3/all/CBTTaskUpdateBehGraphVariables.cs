using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskUpdateBehGraphVariables : IBehTreeTask
{
#region RED Properties

[REDProp("updateOnlyOnActivate")]
public bool UpdateOnlyOnActivate { get; set;}

[REDProp("DistanceToTarget")]
public bool DistanceToTarget { get; set;}

[REDProp("AngleToTarget")]
public bool AngleToTarget { get; set;}

[REDProp("TargetIsOnGround")]
public bool TargetIsOnGround { get; set;}

[REDProp("predictionDelay")]
public float PredictionDelay { get; set;}

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

#endregion
}
}