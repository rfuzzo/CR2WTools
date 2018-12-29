using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SE_AddBuff : W3SwitchEvent
{
#region RED Properties

[REDProp("applyEffect")]
public EEffectType ApplyEffect { get; set;}

[REDProp("useDefaultValuesFromXML")]
public bool UseDefaultValuesFromXML { get; set;}

[REDProp("effectDuration")]
public float EffectDuration { get; set;}

[REDProp("customDamageValuePerSec")]
public SAbilityAttributeValue CustomDamageValuePerSec { get; set;}

#endregion
}
}