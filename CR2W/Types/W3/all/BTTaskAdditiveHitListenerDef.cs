using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskAdditiveHitListenerDef : IBehTreeTaskDefinition
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

#endregion
}
}