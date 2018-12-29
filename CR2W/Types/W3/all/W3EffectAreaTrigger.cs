using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3EffectAreaTrigger : CGameplayEntity
{
#region RED Properties

[REDProp("effect")]
public EEffectType Effect { get; set;}

[REDProp("useDefaultValuesFromXML")]
public bool UseDefaultValuesFromXML { get; set;}

[REDProp("effectDuration")]
public float EffectDuration { get; set;}

[REDProp("customDamageValuePerSec")]
public SAbilityAttributeValue CustomDamageValuePerSec { get; set;}

[REDProp("immunityFact")]
public string ImmunityFact { get; set;}

[REDProp("customParams")]
public Handle<W3BuffCustomParams> CustomParams { get; set;}

[REDProp("entitiesInRange")]
public Array<Handle<CActor>> EntitiesInRange { get; set;}

#endregion
}
}