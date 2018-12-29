using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class TaskTeleportAction : IBehTreeTask
{
#region RED Properties

[REDProp("teleportType")]
public ETeleportType TeleportType { get; set;}

[REDProp("teleportToActorHeading")]
public bool TeleportToActorHeading { get; set;}

[REDProp("teleportAwayFromActorHeading")]
public bool TeleportAwayFromActorHeading { get; set;}

[REDProp("teleportInFrontOfTarget")]
public bool TeleportInFrontOfTarget { get; set;}

[REDProp("teleportInFrontOfOwner")]
public bool TeleportInFrontOfOwner { get; set;}

[REDProp("teleportOutsidePlayerFOV")]
public bool TeleportOutsidePlayerFOV { get; set;}

[REDProp("teleportWithinPlayerFOV")]
public bool TeleportWithinPlayerFOV { get; set;}

[REDProp("teleportBehindTarget")]
public bool TeleportBehindTarget { get; set;}

[REDProp("requestedFacingDirectionNoiseAngle")]
public float RequestedFacingDirectionNoiseAngle { get; set;}

[REDProp("minDistance")]
public float MinDistance { get; set;}

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("minDistanceFromLastPosition")]
public float MinDistanceFromLastPosition { get; set;}

[REDProp("setIsTeleportingFlag")]
public bool SetIsTeleportingFlag { get; set;}

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

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

[REDProp("paramsOverriden")]
public bool ParamsOverriden { get; set;}

[REDProp("cashedBool")]
public bool CashedBool { get; set;}

[REDProp("setInvulnerable")]
public bool SetInvulnerable { get; set;}

[REDProp("dontTeleportOutsideGuardArea")]
public bool DontTeleportOutsideGuardArea { get; set;}

[REDProp("minDistanceFromEnititesWithTag")]
public CName MinDistanceFromEnititesWithTag { get; set;}

[REDProp("minDistanceFromTaggedEntities")]
public float MinDistanceFromTaggedEntities { get; set;}

[REDProp("alreadyTeleported")]
public bool AlreadyTeleported { get; set;}

[REDProp("isTeleporting")]
public bool IsTeleporting { get; set;}

[REDProp("distFromLastTelePos")]
public float DistFromLastTelePos { get; set;}

[REDProp("dangerZone")]
public float DangerZone { get; set;}

[REDProp("angle")]
public float Angle { get; set;}

[REDProp("lastTelePos")]
public Vector LastTelePos { get; set;}

[REDProp("lastPos")]
public Vector LastPos { get; set;}

[REDProp("guardArea")]
public Handle<CAreaComponent> GuardArea { get; set;}

#endregion
}
}