using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_StaminaDrain : CBaseGameplayEffect
{
#region RED Properties

[REDProp("effectValueDrain")]
public SAbilityAttributeValue EffectValueDrain { get; set;}

#endregion
}
}