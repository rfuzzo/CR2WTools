using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskDodge : CBTTaskPlayAnimationEventDecorator
{
#region RED Properties

[REDProp("dodgeChanceAttackLight")]
public Int32 DodgeChanceAttackLight { get; set;}

[REDProp("dodgeChanceAttackHeavy")]
public Int32 DodgeChanceAttackHeavy { get; set;}

[REDProp("dodgeChanceAard")]
public Int32 DodgeChanceAard { get; set;}

[REDProp("dodgeChanceIgni")]
public Int32 DodgeChanceIgni { get; set;}

[REDProp("dodgeChanceBomb")]
public Int32 DodgeChanceBomb { get; set;}

[REDProp("dodgeChanceProjectile")]
public Int32 DodgeChanceProjectile { get; set;}

[REDProp("dodgeChanceFear")]
public Int32 DodgeChanceFear { get; set;}

[REDProp("counterChance")]
public float CounterChance { get; set;}

[REDProp("counterMultiplier")]
public float CounterMultiplier { get; set;}

[REDProp("hitsToCounter")]
public Int32 HitsToCounter { get; set;}

[REDProp("Time2Dodge")]
public bool Time2Dodge { get; set;}

[REDProp("dodgeType")]
public EDodgeType DodgeType { get; set;}

[REDProp("dodgeDirection")]
public EDodgeDirection DodgeDirection { get; set;}

[REDProp("dodgeTime")]
public float DodgeTime { get; set;}

[REDProp("dodgeEventTime")]
public float DodgeEventTime { get; set;}

[REDProp("nextDodgeTime")]
public float NextDodgeTime { get; set;}

[REDProp("performDodgeDelay")]
public float PerformDodgeDelay { get; set;}

[REDProp("ownerPosition")]
public Vector OwnerPosition { get; set;}

[REDProp("swingType")]
public Int32 SwingType { get; set;}

[REDProp("swingDir")]
public Int32 SwingDir { get; set;}

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