using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAINpcDettlaffVampireParryAction : CAINpcDefenseAction
{
#region RED Properties

[REDProp("activationTimeLimitBonusHeavy")]
public float ActivationTimeLimitBonusHeavy { get; set;}

[REDProp("activationTimeLimitBonusLight")]
public float ActivationTimeLimitBonusLight { get; set;}

#endregion
}
}