using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBuffEffectExecutor : IGameplayEffectExecutor
{
#region RED Properties

[REDProp("effectType")]
public EEffectType EffectType { get; set;}

[REDProp("duration")]
public float Duration { get; set;}

[REDProp("customEffectValue")]
public SAbilityAttributeValue CustomEffectValue { get; set;}

#endregion
}
}