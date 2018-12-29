using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskFrostAreaAttackDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("spawnedEntities")]
public Array<CName> SpawnedEntities { get; set;}

[REDProp("duration")]
public SRangeF Duration { get; set;}

[REDProp("spreadingSpeed")]
public float SpreadingSpeed { get; set;}

[REDProp("maxRadius")]
public float MaxRadius { get; set;}

[REDProp("spawnAtOnce")]
public SRange SpawnAtOnce { get; set;}

[REDProp("createArena")]
public bool CreateArena { get; set;}

[REDProp("arenaAngle")]
public float ArenaAngle { get; set;}

[REDProp("scaleSpawnQuantityWithRadius")]
public bool ScaleSpawnQuantityWithRadius { get; set;}

[REDProp("spawnAttackDelay")]
public SRangeF SpawnAttackDelay { get; set;}

[REDProp("spawnAttackOnTargetDelay")]
public SRangeF SpawnAttackOnTargetDelay { get; set;}

[REDProp("frostWallReloadDelay")]
public float FrostWallReloadDelay { get; set;}

#endregion
}
}