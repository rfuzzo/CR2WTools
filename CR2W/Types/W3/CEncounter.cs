using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CEncounter : CGameplayEntity
{
#region RED Properties

[REDProp("tags")]
public TagList Tags { get; set;}

[REDProp("transform")]
public EngineTransform Transform { get; set;}

[REDProp("transformParent")]
public Ptr<CHardAttachment> TransformParent { get; set;}

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("components")]
public Array<Ptr<CComponent>> Components { get; set;}

[REDProp("template")]
public Handle<CEntityTemplate> Template { get; set;}

[REDProp("streamingDataBuffer")]
public SharedDataBuffer StreamingDataBuffer { get; set;}

[REDProp("streamingDistance")]
public byte StreamingDistance { get; set;}

[REDProp("entityStaticFlags")]
public EEntityStaticFlags EntityStaticFlags { get; set;}

[REDProp("autoPlayEffectName")]
public CName AutoPlayEffectName { get; set;}

[REDProp("entityFlags")]
public byte EntityFlags { get; set;}

[REDProp("idTag")]
public IdTag IdTag { get; set;}

[REDProp("isSaveable")]
public bool IsSaveable { get; set;}

[REDProp("propertyAnimationSet")]
public Ptr<CPropertyAnimationSet> PropertyAnimationSet { get; set;}

[REDProp("displayName")]
public LocalizedString DisplayName { get; set;}

[REDProp("stats")]
public Ptr<CCharacterStats> Stats { get; set;}

[REDProp("isInteractionActivator")]
public bool IsInteractionActivator { get; set;}

[REDProp("aimVector")]
public Vector AimVector { get; set;}

[REDProp("gameplayFlags")]
public uint GameplayFlags { get; set;}

[REDProp("focusModeVisibility")]
public EFocusModeVisibility FocusModeVisibility { get; set;}

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("ignoreAreaTrigger")]
public bool IgnoreAreaTrigger { get; set;}

[REDProp("fullRespawnScheduled")]
public bool FullRespawnScheduled { get; set;}

[REDProp("spawnTree")]
public Ptr<ISpawnTreeBranch> SpawnTree { get; set;}

[REDProp("creatureDefinition")]
public Array<Ptr<CEncounterCreatureDefinition>> CreatureDefinition { get; set;}

[REDProp("encounterParameters")]
public Handle<CEncounterParameters> EncounterParameters { get; set;}

[REDProp("spawnArea")]
public EntityHandle SpawnArea { get; set;}

[REDProp("fullRespawnDelay")]
public GameTime FullRespawnDelay { get; set;}

[REDProp("isFullRespawnTimeInGameTime")]
public bool IsFullRespawnTimeInGameTime { get; set;}

[REDProp("fullRespawnTime")]
public GameTime FullRespawnTime { get; set;}

[REDProp("wasRaining")]
public bool WasRaining { get; set;}

[REDProp("conditionRetestTimeout")]
public float ConditionRetestTimeout { get; set;}

[REDProp("defaultImmediateDespawnConfiguration")]
public SSpawnTreeDespawnConfiguration DefaultImmediateDespawnConfiguration { get; set;}

[REDProp("spawnTreeType")]
public ESpawnTreeType SpawnTreeType { get; set;}

#endregion
}
}