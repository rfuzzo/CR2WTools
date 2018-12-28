using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CCommunityAreaTypeSpawnRadius : CCommunityAreaType
{
#region RED Properties

[REDProp("spawnRadius")]
public float SpawnRadius { get; set;}

[REDProp("despawnRadius")]
public float DespawnRadius { get; set;}

[REDProp("dontRestore")]
public bool DontRestore { get; set;}

#endregion
}
}