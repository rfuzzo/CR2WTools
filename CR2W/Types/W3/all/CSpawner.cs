using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CSpawner : CEntity
{
#region RED Properties

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("count")]
public Int32 Count { get; set;}

[REDProp("immortalityMode")]
public EActorImmortalityMode ImmortalityMode { get; set;}

[REDProp("attitudeOverride")]
public bool AttitudeOverride { get; set;}

[REDProp("attitudeToPlayer")]
public EAIAttitude AttitudeToPlayer { get; set;}

[REDProp("hostileSpawnerTag")]
public CName HostileSpawnerTag { get; set;}

[REDProp("spawnTags")]
public Array<CName> SpawnTags { get; set;}

[REDProp("respawn")]
public bool Respawn { get; set;}

[REDProp("respawnDelay")]
public float RespawnDelay { get; set;}

[REDProp("initialHealth")]
public Int32 InitialHealth { get; set;}

[REDProp("spawnAnimation")]
public EExplorationMode SpawnAnimation { get; set;}

[REDProp("spawnedNPCs")]
public Array<Handle<CNewNPC>> SpawnedNPCs { get; set;}

[REDProp("respawnTime")]
public Array<EngineTime> RespawnTime { get; set;}

[REDProp("respawnNeeded")]
public Array<bool> RespawnNeeded { get; set;}

#endregion
}
}