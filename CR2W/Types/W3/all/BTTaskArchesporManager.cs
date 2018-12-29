using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskArchesporManager : IBehTreeTask
{
#region RED Properties

[REDProp("data")]
public Handle<CArchesporeAICombatStorage> Data { get; set;}

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

[REDProp("allBaseEntities")]
public Array<Handle<CGameplayEntity>> AllBaseEntities { get; set;}

[REDProp("usedPos")]
public Array<Vector> UsedPos { get; set;}

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("anchorPos")]
public Vector AnchorPos { get; set;}

[REDProp("privateBulb")]
public Handle<W3ArchesporBulb> PrivateBulb { get; set;}

[REDProp("guardArea")]
public Handle<CAreaComponent> GuardArea { get; set;}

[REDProp("losTestCollisionGroups")]
public Array<CName> LosTestCollisionGroups { get; set;}

[REDProp("baseEntitiesSearchingRange")]
public float BaseEntitiesSearchingRange { get; set;}

[REDProp("baseEntityTag")]
public CName BaseEntityTag { get; set;}

[REDProp("resourceName")]
public string ResourceName { get; set;}

[REDProp("baseEntitiesToSpawnCount")]
public Int32 BaseEntitiesToSpawnCount { get; set;}

[REDProp("minDistFromOwner")]
public float MinDistFromOwner { get; set;}

[REDProp("maxDistFromOwner")]
public float MaxDistFromOwner { get; set;}

[REDProp("minDistFromEachOther")]
public float MinDistFromEachOther { get; set;}

[REDProp("maxDistFromAnchor")]
public float MaxDistFromAnchor { get; set;}

[REDProp("spawnEntitiesAroundPlayer")]
public bool SpawnEntitiesAroundPlayer { get; set;}

#endregion
}
}