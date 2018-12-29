using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskPerformParry : CBTTaskPlayAnimationEventDecorator
{
#region RED Properties

[REDProp("activationTimeLimitBonusHeavy")]
public float ActivationTimeLimitBonusHeavy { get; set;}

[REDProp("activationTimeLimitBonusLight")]
public float ActivationTimeLimitBonusLight { get; set;}

[REDProp("checkParryChance")]
public bool CheckParryChance { get; set;}

[REDProp("interruptTaskToExecuteCounter")]
public bool InterruptTaskToExecuteCounter { get; set;}

[REDProp("allowParryOverlap")]
public bool AllowParryOverlap { get; set;}

[REDProp("activationTimeLimit")]
public float ActivationTimeLimit { get; set;}

[REDProp("action")]
public CName Action { get; set;}

[REDProp("runMain")]
public bool RunMain { get; set;}

[REDProp("parryChance")]
public float ParryChance { get; set;}

[REDProp("counterChance")]
public float CounterChance { get; set;}

[REDProp("counterMultiplier")]
public float CounterMultiplier { get; set;}

[REDProp("hitsToCounter")]
public Int32 HitsToCounter { get; set;}

[REDProp("swingType")]
public Int32 SwingType { get; set;}

[REDProp("swingDir")]
public Int32 SwingDir { get; set;}

#endregion
}
}