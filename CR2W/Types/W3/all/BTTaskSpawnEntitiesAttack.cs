using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskSpawnEntitiesAttack : IBehTreeTask
{
#region RED Properties

[REDProp("resourceName")]
public CName ResourceName { get; set;}

[REDProp("eventName")]
public CName EventName { get; set;}

[REDProp("numberOfEntities")]
public Int32 NumberOfEntities { get; set;}

[REDProp("timeBetweenSpawn")]
public float TimeBetweenSpawn { get; set;}

[REDProp("minDistFromTarget")]
public float MinDistFromTarget { get; set;}

[REDProp("maxDistFromTarget")]
public float MaxDistFromTarget { get; set;}

[REDProp("minDistFromEachOther")]
public float MinDistFromEachOther { get; set;}

[REDProp("initialDelay")]
public float InitialDelay { get; set;}

[REDProp("behVariableToSetOnEnd")]
public CName BehVariableToSetOnEnd { get; set;}

[REDProp("shouldStart")]
public bool ShouldStart { get; set;}

[REDProp("lastSpawnTimestamp")]
public float LastSpawnTimestamp { get; set;}

[REDProp("spawnTimeout")]
public float SpawnTimeout { get; set;}

[REDProp("checkDistanceOfNpcToTarget")]
public bool CheckDistanceOfNpcToTarget { get; set;}

[REDProp("spawnEntitiesAroundOwner")]
public bool SpawnEntitiesAroundOwner { get; set;}

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("usedPos")]
public Array<Vector> UsedPos { get; set;}

#endregion
}
}