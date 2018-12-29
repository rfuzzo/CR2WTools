using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskPerformParryDef : CBTTaskPlayAnimationEventDecoratorDef
{
#region RED Properties

[REDProp("activationTimeLimitBonusHeavy")]
public CBehTreeValFloat ActivationTimeLimitBonusHeavy { get; set;}

[REDProp("activationTimeLimitBonusLight")]
public CBehTreeValFloat ActivationTimeLimitBonusLight { get; set;}

[REDProp("checkParryChance")]
public bool CheckParryChance { get; set;}

[REDProp("interruptTaskToExecuteCounter")]
public bool InterruptTaskToExecuteCounter { get; set;}

[REDProp("allowParryOverlap")]
public bool AllowParryOverlap { get; set;}

#endregion
}
}