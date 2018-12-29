using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMonsterNestEntity : CInteractiveEntity
{
#region RED Properties

[REDProp("bombActivators")]
public Array<CName> BombActivators { get; set;}

[REDProp("lootOnNestDestroyed")]
public Handle<CEntityTemplate> LootOnNestDestroyed { get; set;}

[REDProp("interactionOnly")]
public bool InteractionOnly { get; set;}

[REDProp("desiredPlayerToEntityDistance")]
public float DesiredPlayerToEntityDistance { get; set;}

[REDProp("matchPlayerHeadingWithHeadingOfTheEntity")]
public bool MatchPlayerHeadingWithHeadingOfTheEntity { get; set;}

[REDProp("settingExplosivesTime")]
public float SettingExplosivesTime { get; set;}

[REDProp("shouldPlayFXOnExplosion")]
public bool ShouldPlayFXOnExplosion { get; set;}

[REDProp("appearanceChangeDelayAfterExplosion")]
public float AppearanceChangeDelayAfterExplosion { get; set;}

[REDProp("shouldDealDamageOnExplosion")]
public bool ShouldDealDamageOnExplosion { get; set;}

[REDProp("factSetAfterFindingNest")]
public string FactSetAfterFindingNest { get; set;}

[REDProp("factSetAfterSuccessfulDestruction")]
public string FactSetAfterSuccessfulDestruction { get; set;}

[REDProp("linkingMode")]
public bool LinkingMode { get; set;}

[REDProp("linkedEncounterHandle")]
public EntityHandle LinkedEncounterHandle { get; set;}

[REDProp("linkedEncounterTag")]
public CName LinkedEncounterTag { get; set;}

[REDProp("setDestructionFactImmediately")]
public bool SetDestructionFactImmediately { get; set;}

[REDProp("expOnNestDestroyed")]
public Int32 ExpOnNestDestroyed { get; set;}

[REDProp("bonusExpOnBossKilled")]
public Int32 BonusExpOnBossKilled { get; set;}

[REDProp("addExpOnlyOnce")]
public bool AddExpOnlyOnce { get; set;}

[REDProp("nestUpdateDefintion")]
public SMonsterNestUpdateDefinition NestUpdateDefintion { get; set;}

[REDProp("monsterNestType")]
public ENestType MonsterNestType { get; set;}

[REDProp("regionType")]
public EEP2PoiType RegionType { get; set;}

[REDProp("entityType")]
public EMonsterNestType EntityType { get; set;}

[REDProp("explodeAfter")]
public float ExplodeAfter { get; set;}

[REDProp("nestBurnedAfter")]
public float NestBurnedAfter { get; set;}

[REDProp("playerInventory")]
public Handle<CInventoryComponent> PlayerInventory { get; set;}

[REDProp("usedBomb")]
public SItemUniqueId UsedBomb { get; set;}

[REDProp("encounter")]
public Handle<CEncounter> Encounter { get; set;}

[REDProp("nestFound")]
public bool NestFound { get; set;}

[REDProp("messageTimestamp")]
public float MessageTimestamp { get; set;}

[REDProp("bossKilled")]
public bool BossKilled { get; set;}

[REDProp("container")]
public Handle<W3Container> Container { get; set;}

[REDProp("bossKilledCounter")]
public Int32 BossKilledCounter { get; set;}

[REDProp("expWasAdded")]
public bool ExpWasAdded { get; set;}

[REDProp("bombEntity")]
public Handle<CEntity> BombEntity { get; set;}

[REDProp("bombEntityTemplate")]
public Handle<CEntityTemplate> BombEntityTemplate { get; set;}

[REDProp("bombName")]
public CName BombName { get; set;}

[REDProp("actionBlockingExceptions")]
public Array<EInputActionBlock> ActionBlockingExceptions { get; set;}

[REDProp("saveLockIdx")]
public Int32 SaveLockIdx { get; set;}

[REDProp("voicesetTime")]
public float VoicesetTime { get; set;}

[REDProp("voicesetPlayed")]
public bool VoicesetPlayed { get; set;}

[REDProp("canPlayVset")]
public bool CanPlayVset { get; set;}

[REDProp("l_enginetime")]
public float L_enginetime { get; set;}

[REDProp("airDmg")]
public bool AirDmg { get; set;}

[REDProp("interactionComponent")]
public Handle<CInteractionComponent> InteractionComponent { get; set;}

[REDProp("wasExploded")]
public bool WasExploded { get; set;}

#endregion
}
}