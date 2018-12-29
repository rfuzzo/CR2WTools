using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CToadAcidPool : CInteractiveEntity
{
#region RED Properties

[REDProp("poisonDamage")]
public SAbilityAttributeValue PoisonDamage { get; set;}

[REDProp("fxOnSpawn")]
public CName FxOnSpawn { get; set;}

[REDProp("immunityFact")]
public string ImmunityFact { get; set;}

[REDProp("despawnTimer")]
public float DespawnTimer { get; set;}

[REDProp("damageVal")]
public float DamageVal { get; set;}

[REDProp("explosionRange")]
public float ExplosionRange { get; set;}

[REDProp("destroyTimer")]
public float DestroyTimer { get; set;}

[REDProp("settled")]
public bool Settled { get; set;}

[REDProp("victim")]
public Handle<CActor> Victim { get; set;}

[REDProp("victims")]
public Array<Handle<CActor>> Victims { get; set;}

[REDProp("poisonArea")]
public Handle<CTriggerAreaComponent> PoisonArea { get; set;}

[REDProp("buffParams")]
public SCustomEffectParams BuffParams { get; set;}

[REDProp("damage")]
public Handle<W3DamageAction> Damage { get; set;}

[REDProp("entitiesInRange")]
public Array<Handle<CGameplayEntity>> EntitiesInRange { get; set;}

[REDProp("targetEntity")]
public Handle<CActor> TargetEntity { get; set;}

[REDProp("fxStartTime")]
public float FxStartTime { get; set;}

[REDProp("hasExploded")]
public bool HasExploded { get; set;}

#endregion
}
}