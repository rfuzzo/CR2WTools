using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CRiftEntity : CInteractiveEntity
{
#region RED Properties

[REDProp("linkingMode")]
public bool LinkingMode { get; set;}

[REDProp("controlledEncounter")]
public EntityHandle ControlledEncounter { get; set;}

[REDProp("controlledEncounterTag")]
public CName ControlledEncounterTag { get; set;}

[REDProp("activationDelay")]
public float ActivationDelay { get; set;}

[REDProp("closeAfter")]
public float CloseAfter { get; set;}

[REDProp("canBeDisabled")]
public bool CanBeDisabled { get; set;}

[REDProp("damageVal")]
public SAbilityAttributeValue DamageVal { get; set;}

[REDProp("factSetAfterRiftWasDisabled")]
public string FactSetAfterRiftWasDisabled { get; set;}

[REDProp("isIntact")]
public bool IsIntact { get; set;}

[REDProp("currState")]
public CName CurrState { get; set;}

[REDProp("encounter")]
public Handle<CEncounter> Encounter { get; set;}

[REDProp("coldArea")]
public Handle<CTriggerAreaComponent> ColdArea { get; set;}

[REDProp("entitiesInRange")]
public Array<Handle<CActor>> EntitiesInRange { get; set;}

[REDProp("isEncounterEnabled")]
public bool IsEncounterEnabled { get; set;}

[REDProp("buffParams")]
public SCustomEffectParams BuffParams { get; set;}

[REDProp("spawnCounter")]
public Int32 SpawnCounter { get; set;}

[REDProp("encounterSpawnLimit")]
public Int32 EncounterSpawnLimit { get; set;}

[REDProp("collisionEntityTemplate")]
public Handle<CEntityTemplate> CollisionEntityTemplate { get; set;}

[REDProp("collisionEntity")]
public Handle<CEntity> CollisionEntity { get; set;}

#endregion
}
}