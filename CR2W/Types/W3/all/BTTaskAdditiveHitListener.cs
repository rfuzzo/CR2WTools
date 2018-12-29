using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskAdditiveHitListener : IBehTreeTask
{
#region RED Properties

[REDProp("playHitSound")]
public bool PlayHitSound { get; set;}

[REDProp("sounEventName")]
public string SounEventName { get; set;}

[REDProp("boneName")]
public CName BoneName { get; set;}

[REDProp("manageIgnoreSignsEvents")]
public bool ManageIgnoreSignsEvents { get; set;}

[REDProp("angleToIgnoreSigns")]
public float AngleToIgnoreSigns { get; set;}

[REDProp("chanceToUseAdditive")]
public float ChanceToUseAdditive { get; set;}

[REDProp("increaseHitCounterOnlyOnMeleeDmg")]
public bool IncreaseHitCounterOnlyOnMeleeDmg { get; set;}

[REDProp("processCounter")]
public bool ProcessCounter { get; set;}

[REDProp("damageIsMelee")]
public bool DamageIsMelee { get; set;}

[REDProp("timeStamp")]
public float TimeStamp { get; set;}

[REDProp("hitsToRaiseGuard")]
public float HitsToRaiseGuard { get; set;}

[REDProp("raiseGuardChance")]
public float RaiseGuardChance { get; set;}

[REDProp("hitsToCounter")]
public float HitsToCounter { get; set;}

[REDProp("counterChance")]
public float CounterChance { get; set;}

[REDProp("counterStaminaCost")]
public float CounterStaminaCost { get; set;}

#endregion
}
}