using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3CurveFishManager : CGameplayEntity
{
#region RED Properties

[REDProp("fishSpawnPointsTag")]
public CName FishSpawnPointsTag { get; set;}

[REDProp("fishTemplate")]
public Array<Handle<CEntityTemplate>> FishTemplate { get; set;}

[REDProp("randomFishRotation")]
public bool RandomFishRotation { get; set;}

[REDProp("fishSpawnpoints")]
public Array<SFishSpawnpoint> FishSpawnpoints { get; set;}

[REDProp("m_spawnDistance")]
public float M_spawnDistance { get; set;}

[REDProp("m_despawnDistance")]
public float M_despawnDistance { get; set;}

[REDProp("m_spawned")]
public bool M_spawned { get; set;}

[REDProp("m_firstTimeCollectSpawnpoints")]
public bool M_firstTimeCollectSpawnpoints { get; set;}

[REDProp("m_spawnedFish")]
public Array<Handle<W3CurveFish>> M_spawnedFish { get; set;}

#endregion
}
}