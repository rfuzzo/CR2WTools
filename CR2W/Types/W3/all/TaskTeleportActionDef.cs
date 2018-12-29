using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class TaskTeleportActionDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("setIsTeleportingFlag")]
public bool SetIsTeleportingFlag { get; set;}

[REDProp("minDistance")]
public float MinDistance { get; set;}

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("minDistanceFromLastPosition")]
public float MinDistanceFromLastPosition { get; set;}

[REDProp("teleportToActorHeading")]
public bool TeleportToActorHeading { get; set;}

[REDProp("teleportAwayFromActorHeading")]
public bool TeleportAwayFromActorHeading { get; set;}

[REDProp("teleportInFrontOfTarget")]
public bool TeleportInFrontOfTarget { get; set;}

[REDProp("teleportInFrontOfOwner")]
public bool TeleportInFrontOfOwner { get; set;}

[REDProp("requestedFacingDirectionNoiseAngle")]
public float RequestedFacingDirectionNoiseAngle { get; set;}

[REDProp("teleportBehindTarget")]
public bool TeleportBehindTarget { get; set;}

[REDProp("teleportOutsidePlayerFOV")]
public bool TeleportOutsidePlayerFOV { get; set;}

[REDProp("teleportWithinPlayerFOV")]
public bool TeleportWithinPlayerFOV { get; set;}

[REDProp("teleportType")]
public ETeleportType TeleportType { get; set;}

[REDProp("minWaterDepthToAppear")]
public float MinWaterDepthToAppear { get; set;}

[REDProp("maxWaterDepthToAppear")]
public float MaxWaterDepthToAppear { get; set;}

[REDProp("zTolerance")]
public float ZTolerance { get; set;}

[REDProp("rotateToTarget")]
public bool RotateToTarget { get; set;}

[REDProp("testLOSforNewPosition")]
public bool TestLOSforNewPosition { get; set;}

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

[REDProp("testNavigationBetweenCombatTargetAndNewPosition")]
public bool TestNavigationBetweenCombatTargetAndNewPosition { get; set;}

[REDProp("overrideActorRadiusForNavigationTests")]
public bool OverrideActorRadiusForNavigationTests { get; set;}

[REDProp("actorRadiusForNavigationTests")]
public float ActorRadiusForNavigationTests { get; set;}

[REDProp("checkWaterLevel")]
public bool CheckWaterLevel { get; set;}

[REDProp("searchingTimeout")]
public float SearchingTimeout { get; set;}

[REDProp("nodeTag")]
public CName NodeTag { get; set;}

[REDProp("shouldSpawnMarkers")]
public bool ShouldSpawnMarkers { get; set;}

[REDProp("setInvulnerable")]
public bool SetInvulnerable { get; set;}

[REDProp("dontTeleportOutsideGuardArea")]
public bool DontTeleportOutsideGuardArea { get; set;}

[REDProp("minDistanceFromEnititesWithTag")]
public CName MinDistanceFromEnititesWithTag { get; set;}

[REDProp("minDistanceFromTaggedEntities")]
public float MinDistanceFromTaggedEntities { get; set;}

#endregion
}
}