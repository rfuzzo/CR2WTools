using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CFlyingSwarmGroup 
{
#region RED Properties

[REDProp("groupId")]
public CFlyingGroupId GroupId { get; set;}

[REDProp("groupCenter")]
public Vector GroupCenter { get; set;}

[REDProp("targetPosition")]
public Vector TargetPosition { get; set;}

[REDProp("currentGroupState")]
public CName CurrentGroupState { get; set;}

[REDProp("boidCount")]
public int BoidCount { get; set;}

[REDProp("toSpawnCount")]
public int ToSpawnCount { get; set;}

[REDProp("spawnPoiType")]
public CName SpawnPoiType { get; set;}

[REDProp("toDespawnCount")]
public int ToDespawnCount { get; set;}

[REDProp("despawnPoiType")]
public CName DespawnPoiType { get; set;}

[REDProp("changeGroupState")]
public CName ChangeGroupState { get; set;}

#endregion
}
}