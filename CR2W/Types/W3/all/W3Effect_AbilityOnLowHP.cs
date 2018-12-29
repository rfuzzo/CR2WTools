using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_AbilityOnLowHP : CBaseGameplayEffect
{
#region RED Properties

[REDProp("lowHPAbilityName")]
public CName LowHPAbilityName { get; set;}

#endregion
}
}