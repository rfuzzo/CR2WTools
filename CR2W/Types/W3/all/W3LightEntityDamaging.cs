using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3LightEntityDamaging : CLightEntitySimple
{
#region RED Properties

[REDProp("hitReactionType")]
public EHitReactionType HitReactionType { get; set;}

[REDProp("damagePerSec")]
public float DamagePerSec { get; set;}

[REDProp("appliesBurning")]
public bool AppliesBurning { get; set;}

[REDProp("area")]
public Handle<CTriggerAreaComponent> Area { get; set;}

[REDProp("entitiesInRange")]
public Array<Handle<CGameplayEntity>> EntitiesInRange { get; set;}

[REDProp("entitiesInRangeEnterTime")]
public Array<EngineTime> EntitiesInRangeEnterTime { get; set;}

[REDProp("buffDamageVal")]
public SAbilityAttributeValue BuffDamageVal { get; set;}

[REDProp("damageDealingEnabled")]
public bool DamageDealingEnabled { get; set;}

[REDProp("buffParams")]
public SCustomEffectParams BuffParams { get; set;}

[REDProp("spawned")]
public bool Spawned { get; set;}

[REDProp("FIRE_DAMAGE_FX")]
public CName FIRE_DAMAGE_FX { get; set;}

#endregion
}
}