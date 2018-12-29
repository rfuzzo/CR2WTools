using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3FlammableAreaTrigger : W3EffectAreaTrigger
{
#region RED Properties

[REDProp("activeFor")]
public float ActiveFor { get; set;}

[REDProp("fxOnExplosion")]
public CName FxOnExplosion { get; set;}

[REDProp("fxOnSustain")]
public CName FxOnSustain { get; set;}

[REDProp("explosionRange")]
public float ExplosionRange { get; set;}

[REDProp("explosionDamage")]
public SAbilityAttributeValue ExplosionDamage { get; set;}

[REDProp("igniteFlammableAreasAfter")]
public float IgniteFlammableAreasAfter { get; set;}

[REDProp("isActive")]
public bool IsActive { get; set;}

[REDProp("area")]
public Handle<CTriggerAreaComponent> Area { get; set;}

#endregion
}
}