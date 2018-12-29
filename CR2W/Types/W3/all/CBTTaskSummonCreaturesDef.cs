using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSummonCreaturesDef : CBTTaskPlayAnimationEventDecoratorDef
{
#region RED Properties

[REDProp("dontResummonUntilMinionsAreDead")]
public bool DontResummonUntilMinionsAreDead { get; set;}

[REDProp("preventActivationUntilMinionsAreDead")]
public bool PreventActivationUntilMinionsAreDead { get; set;}

[REDProp("teleportOutsidePlayerFOV")]
public bool TeleportOutsidePlayerFOV { get; set;}

[REDProp("killSummonedCreaturesOnSummonerDeath")]
public bool KillSummonedCreaturesOnSummonerDeath { get; set;}

[REDProp("spawnOnAnimEventName")]
public CName SpawnOnAnimEventName { get; set;}

[REDProp("entityToSummonName")]
public CName EntityToSummonName { get; set;}

[REDProp("raiseEventOnSummon")]
public CName RaiseEventOnSummon { get; set;}

[REDProp("overrideAttitude")]
public bool OverrideAttitude { get; set;}

[REDProp("attitudeToPlayer")]
public EAIAttitude AttitudeToPlayer { get; set;}

[REDProp("count")]
public Int32 Count { get; set;}

[REDProp("minDistance")]
public float MinDistance { get; set;}

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("spawnAnimation")]
public EExplorationMode SpawnAnimation { get; set;}

[REDProp("forcedSpawnAnim")]
public Int32 ForcedSpawnAnim { get; set;}

[REDProp("spawnTag")]
public CName SpawnTag { get; set;}

[REDProp("targetShouldBeAccessible")]
public bool TargetShouldBeAccessible { get; set;}

[REDProp("spawnerShouldBeAccessible")]
public bool SpawnerShouldBeAccessible { get; set;}

[REDProp("spawnConditionsCheckInterval")]
public float SpawnConditionsCheckInterval { get; set;}

[REDProp("spawnConditionsChecksNumber")]
public Int32 SpawnConditionsChecksNumber { get; set;}

#endregion
}
}