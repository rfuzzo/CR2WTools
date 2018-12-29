using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSpawnMultipleEntitiesAttack : CBTTaskSpawnEntityAttack
{
#region RED Properties

[REDProp("numberToSpawn")]
public Int32 NumberToSpawn { get; set;}

[REDProp("numberOfCircles")]
public Int32 NumberOfCircles { get; set;}

[REDProp("randomnessInCircles")]
public float RandomnessInCircles { get; set;}

[REDProp("useRandomSpaceBetweenSpawns")]
public bool UseRandomSpaceBetweenSpawns { get; set;}

[REDProp("spawnRadiusMin")]
public float SpawnRadiusMin { get; set;}

[REDProp("spawnRadiusMax")]
public float SpawnRadiusMax { get; set;}

[REDProp("spawnEntityRadius")]
public float SpawnEntityRadius { get; set;}

[REDProp("spawnPositionPattern")]
public ESpawnPositionPattern SpawnPositionPattern { get; set;}

[REDProp("spawnRotation")]
public ESpawnRotation SpawnRotation { get; set;}

[REDProp("leaveOpenSpaceForDodge")]
public bool LeaveOpenSpaceForDodge { get; set;}

[REDProp("spawnInRandomOrder")]
public bool SpawnInRandomOrder { get; set;}

[REDProp("delayBetweenSpawn")]
public float DelayBetweenSpawn { get; set;}

[REDProp("spawnOnGround")]
public bool SpawnOnGround { get; set;}

[REDProp("m_dodgeDistance")]
public float M_dodgeDistance { get; set;}

[REDProp("m_dodgeSafeAreaRadius")]
public float M_dodgeSafeAreaRadius { get; set;}

[REDProp("m_shouldSpawn")]
public bool M_shouldSpawn { get; set;}

[REDProp("m_entitiesSpawned")]
public Int32 M_entitiesSpawned { get; set;}

[REDProp("m_canComplete")]
public bool M_canComplete { get; set;}

#endregion
}
}