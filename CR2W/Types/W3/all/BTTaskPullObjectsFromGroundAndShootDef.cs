using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskPullObjectsFromGroundAndShootDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("createEntityResourceName")]
public CName CreateEntityResourceName { get; set;}

[REDProp("zAxisSpawnOffset")]
public float ZAxisSpawnOffset { get; set;}

[REDProp("raiseObjectsToCapsuleHeightRatio")]
public float RaiseObjectsToCapsuleHeightRatio { get; set;}

[REDProp("raiseObjectsHeightNoise")]
public float RaiseObjectsHeightNoise { get; set;}

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

[REDProp("shootEntityOnAnimEvent")]
public CName ShootEntityOnAnimEvent { get; set;}

[REDProp("shootEntityAfter")]
public float ShootEntityAfter { get; set;}

[REDProp("drawSpeedLimit")]
public float DrawSpeedLimit { get; set;}

[REDProp("calculateSpeedFromPullDuration")]
public float CalculateSpeedFromPullDuration { get; set;}

[REDProp("drawEntityRotationSpeed")]
public float DrawEntityRotationSpeed { get; set;}

[REDProp("shootAtLookatTarget")]
public bool ShootAtLookatTarget { get; set;}

[REDProp("shootEntitiesInRandomOrder")]
public bool ShootEntitiesInRandomOrder { get; set;}

[REDProp("shootInAllDirections")]
public bool ShootInAllDirections { get; set;}

[REDProp("completeTaskAfterShooting")]
public bool CompleteTaskAfterShooting { get; set;}

[REDProp("shootDirectionNoise")]
public float ShootDirectionNoise { get; set;}

[REDProp("shootEntitiesInterval")]
public float ShootEntitiesInterval { get; set;}

[REDProp("playEffectOnEntityCreation")]
public CName PlayEffectOnEntityCreation { get; set;}

[REDProp("stopEffectOnDeactivate")]
public CName StopEffectOnDeactivate { get; set;}

#endregion
}
}