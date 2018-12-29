using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBirdsManager : CGameplayEntity
{
#region RED Properties

[REDProp("birdsSpawnPointsTag")]
public CName BirdsSpawnPointsTag { get; set;}

[REDProp("birdType")]
public EBirdType BirdType { get; set;}

[REDProp("spawnRange")]
public float SpawnRange { get; set;}

[REDProp("customBirdTemplate")]
public Handle<CEntityTemplate> CustomBirdTemplate { get; set;}

[REDProp("respawnDelay")]
public float RespawnDelay { get; set;}

[REDProp("respawnMinDistance")]
public float RespawnMinDistance { get; set;}

[REDProp("spawnOnlyInsideBirdsArea")]
public bool SpawnOnlyInsideBirdsArea { get; set;}

[REDProp("disableSnapToCollisions")]
public bool DisableSnapToCollisions { get; set;}

[REDProp("birdSpawnpoints")]
public Array<SBirdSpawnpoint> BirdSpawnpoints { get; set;}

[REDProp("shouldBirdsFly")]
public bool ShouldBirdsFly { get; set;}

[REDProp("despawnTime")]
public float DespawnTime { get; set;}

[REDProp("wasEverVisible")]
public bool WasEverVisible { get; set;}

[REDProp("birdArea")]
public Handle<CTriggerAreaComponent> BirdArea { get; set;}

[REDProp("birdTemplate")]
public Handle<CEntityTemplate> BirdTemplate { get; set;}

#endregion
}
}