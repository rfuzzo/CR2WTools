using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskPullObjectsFromGroundAndShoot : IBehTreeTask
{
#region RED Properties

[REDProp("createEntityResourceName")]
public CName CreateEntityResourceName { get; set;}

[REDProp("numberToSpawn")]
public Int32 NumberToSpawn { get; set;}

[REDProp("numberOfCircles")]
public Int32 NumberOfCircles { get; set;}

[REDProp("spawnPositionPattern")]
public ESpawnPositionPattern SpawnPositionPattern { get; set;}

[REDProp("spawnRotation")]
public ESpawnRotation SpawnRotation { get; set;}

[REDProp("spawnInTargetDirection")]
public bool SpawnInTargetDirection { get; set;}

[REDProp("zAxisSpawnOffset")]
public float ZAxisSpawnOffset { get; set;}

[REDProp("raiseObjectsToCapsuleHeightRatio")]
public float RaiseObjectsToCapsuleHeightRatio { get; set;}

[REDProp("raiseObjectsHeightNoise")]
public float RaiseObjectsHeightNoise { get; set;}

[REDProp("spawnObjectsInConeAngle")]
public float SpawnObjectsInConeAngle { get; set;}

[REDProp("randomnessInCircles")]
public float RandomnessInCircles { get; set;}

[REDProp("useRandomSpaceBetweenSpawns")]
public bool UseRandomSpaceBetweenSpawns { get; set;}

[REDProp("spawnRadiusMin")]
public float SpawnRadiusMin { get; set;}

[REDProp("spawnRadiusMax")]
public float SpawnRadiusMax { get; set;}

[REDProp("spawnInRandomOrder")]
public bool SpawnInRandomOrder { get; set;}

[REDProp("delayBetweenSpawn")]
public float DelayBetweenSpawn { get; set;}

[REDProp("activateOnAnimEvent")]
public CName ActivateOnAnimEvent { get; set;}

[REDProp("activateAfter")]
public float ActivateAfter { get; set;}

[REDProp("calculateSpeedFromPullDuration")]
public float CalculateSpeedFromPullDuration { get; set;}

[REDProp("drawSpeedLimit")]
public float DrawSpeedLimit { get; set;}

[REDProp("drawEntityRotationSpeed")]
public float DrawEntityRotationSpeed { get; set;}

[REDProp("completeTaskAfterShooting")]
public bool CompleteTaskAfterShooting { get; set;}

[REDProp("shootEntitiesInRandomOrder")]
public bool ShootEntitiesInRandomOrder { get; set;}

[REDProp("shootAtLookatTarget")]
public bool ShootAtLookatTarget { get; set;}

[REDProp("shootInAllDirections")]
public bool ShootInAllDirections { get; set;}

[REDProp("shootDirectionNoise")]
public float ShootDirectionNoise { get; set;}

[REDProp("shootEntityOnAnimEvent")]
public CName ShootEntityOnAnimEvent { get; set;}

[REDProp("shootEntityAfter")]
public float ShootEntityAfter { get; set;}

[REDProp("shootEntitiesInterval")]
public float ShootEntitiesInterval { get; set;}

[REDProp("playEffectOnEntityCreation")]
public CName PlayEffectOnEntityCreation { get; set;}

[REDProp("stopEffectOnDeactivate")]
public CName StopEffectOnDeactivate { get; set;}

[REDProp("m_Npc")]
public Handle<CNewNPC> M_Npc { get; set;}

[REDProp("m_CreateEntityTemplate")]
public Handle<CEntityTemplate> M_CreateEntityTemplate { get; set;}

[REDProp("m_CreatedEntities")]
public Array<Handle<CEntity>> M_CreatedEntities { get; set;}

[REDProp("m_entitiesToPull")]
public Array<Handle<CEntity>> M_entitiesToPull { get; set;}

[REDProp("m_entitiesToShoot")]
public Array<Handle<CEntity>> M_entitiesToShoot { get; set;}

[REDProp("m_activateEventReceived")]
public bool M_activateEventReceived { get; set;}

[REDProp("m_shootEntityEventReceived")]
public bool M_shootEntityEventReceived { get; set;}

[REDProp("m_aardHitEventReceived")]
public bool M_aardHitEventReceived { get; set;}

[REDProp("m_initialPosArray")]
public Array<Vector> M_initialPosArray { get; set;}

[REDProp("m_finalPosArray")]
public Array<Vector> M_finalPosArray { get; set;}

[REDProp("m_prevSpeed")]
public float M_prevSpeed { get; set;}

[REDProp("m_lastShootTime")]
public float M_lastShootTime { get; set;}

[REDProp("m_collisionGroups")]
public Array<CName> M_collisionGroups { get; set;}

[REDProp("couldntLoadResource")]
public bool CouldntLoadResource { get; set;}

#endregion
}
}