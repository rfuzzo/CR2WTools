using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskDodgeDef : CBTTaskPlayAnimationEventDecoratorDef
{
#region RED Properties

[REDProp("navmeshCheckDist")]
public float NavmeshCheckDist { get; set;}

[REDProp("minDelayBetweenDodges")]
public float MinDelayBetweenDodges { get; set;}

[REDProp("maxDistanceFromTarget")]
public float MaxDistanceFromTarget { get; set;}

[REDProp("movementAdjustorSlideDistance")]
public float MovementAdjustorSlideDistance { get; set;}

[REDProp("disableIsDodgingFlagAfter")]
public float DisableIsDodgingFlagAfter { get; set;}

[REDProp("allowDodgeWhileAttacking")]
public bool AllowDodgeWhileAttacking { get; set;}

[REDProp("signalGameplayEventWhileInHitAnim")]
public bool SignalGameplayEventWhileInHitAnim { get; set;}

[REDProp("alwaysAvailableOnDodgeType")]
public EDodgeType AlwaysAvailableOnDodgeType { get; set;}

[REDProp("allowDodgeOverlap")]
public bool AllowDodgeOverlap { get; set;}

[REDProp("earlyDodgeActivation")]
public bool EarlyDodgeActivation { get; set;}

[REDProp("interruptTaskToExecuteCounter")]
public bool InterruptTaskToExecuteCounter { get; set;}

[REDProp("ignoreDodgeChanceStats")]
public bool IgnoreDodgeChanceStats { get; set;}

[REDProp("delayDodgeHeavyAttack")]
public float DelayDodgeHeavyAttack { get; set;}

#endregion
}
}