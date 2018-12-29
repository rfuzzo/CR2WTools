using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_AirDrainDive : CBaseGameplayEffect
{
#region RED Properties

[REDProp("effectValueMultInIdle")]
public SAbilityAttributeValue EffectValueMultInIdle { get; set;}

[REDProp("effectValueMultWhileSprinting")]
public SAbilityAttributeValue EffectValueMultWhileSprinting { get; set;}

#endregion
}
}