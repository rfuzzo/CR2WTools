using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class COldCommunitySpawnStrategy : IEngineSpawnStrategy
{
#region RED Properties

[REDProp("spawnRadius")]
public float SpawnRadius { get; set;}

[REDProp("despawnRadius")]
public float DespawnRadius { get; set;}

#endregion
}
}