using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CCreatureEntry : CBaseCreatureEntry
{
#region RED Properties

[REDProp("nodeName")]
public CName NodeName { get; set;}

[REDProp("id")]
public UInt64 Id { get; set;}

[REDProp("initializers")]
public Array<Handle<ISpawnTreeInitializer>> Initializers { get; set;}

[REDProp("quantityMin")]
public int QuantityMin { get; set;}

[REDProp("quantityMax")]
public int QuantityMax { get; set;}

[REDProp("spawnInterval")]
public float SpawnInterval { get; set;}

[REDProp("waveDelay")]
public float WaveDelay { get; set;}

[REDProp("waveCounterHitAtDeathRatio")]
public float WaveCounterHitAtDeathRatio { get; set;}

[REDProp("randomizeRotation")]
public bool RandomizeRotation { get; set;}

[REDProp("group")]
public int Group { get; set;}

[REDProp("baseSpawner")]
public CSpawnTreeWaypointSpawner BaseSpawner { get; set;}

[REDProp("recalculateDelay")]
public GameTime RecalculateDelay { get; set;}

[REDProp("creatureDefinition")]
public CName CreatureDefinition { get; set;}

#endregion
}
}