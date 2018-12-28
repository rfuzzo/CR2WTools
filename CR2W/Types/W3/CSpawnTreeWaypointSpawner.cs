using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSpawnTreeWaypointSpawner 
{
#region RED Properties

[REDProp("visibility")]
public ESpawnTreeSpawnVisibility Visibility { get; set;}

[REDProp("spawnpointDelay")]
public float SpawnpointDelay { get; set;}

[REDProp("tags")]
public TagList Tags { get; set;}

[REDProp("useLocationTest")]
public bool UseLocationTest { get; set;}

#endregion
}
}