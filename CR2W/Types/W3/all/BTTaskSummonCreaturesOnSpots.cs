using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskSummonCreaturesOnSpots : IBehTreeTask
{
#region RED Properties

[REDProp("entityToSpawn")]
public Handle<CEntityTemplate> EntityToSpawn { get; set;}

[REDProp("summonOnAnimEvent")]
public CName SummonOnAnimEvent { get; set;}

[REDProp("spotTag")]
public CName SpotTag { get; set;}

[REDProp("minDistance")]
public float MinDistance { get; set;}

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("maxSpawnQuantity")]
public Int32 MaxSpawnQuantity { get; set;}

[REDProp("betweenSpawnDelay")]
public SRangeF BetweenSpawnDelay { get; set;}

[REDProp("completeAfterSpawn")]
public bool CompleteAfterSpawn { get; set;}

[REDProp("spawnAreaCenter")]
public ETargetName SpawnAreaCenter { get; set;}

[REDProp("minDistanceFromSpawner")]
public float MinDistanceFromSpawner { get; set;}

[REDProp("spawnBehVarName")]
public CName SpawnBehVarName { get; set;}

[REDProp("spawnBehVar")]
public float SpawnBehVar { get; set;}

[REDProp("shouldForceBehaviorOnSpawn")]
public bool ShouldForceBehaviorOnSpawn { get; set;}

[REDProp("m_Npc")]
public Handle<CNewNPC> M_Npc { get; set;}

[REDProp("m_AllSpots")]
public Array<Handle<CNode>> M_AllSpots { get; set;}

[REDProp("m_CreateEntityHelper")]
public Handle<CCreateEntityHelper> M_CreateEntityHelper { get; set;}

[REDProp("m_WaitingToSpawn")]
public bool M_WaitingToSpawn { get; set;}

[REDProp("m_IsSpawned")]
public bool M_IsSpawned { get; set;}

#endregion
}
}