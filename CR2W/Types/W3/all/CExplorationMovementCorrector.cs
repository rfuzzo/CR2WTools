using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationMovementCorrector : CObject
{
#region RED Properties

[REDProp("m_ExplorationO")]
public Handle<CExplorationStateManager> M_ExplorationO { get; set;}

[REDProp("correctionNone")]
public Handle<NavigationCorrection> CorrectionNone { get; set;}

[REDProp("correctionOnCollision")]
public Handle<NavigationCorrection> CorrectionOnCollision { get; set;}

[REDProp("correctionOnPhysics")]
public Handle<NavigationCorrection> CorrectionOnPhysics { get; set;}

[REDProp("correctionOnPush")]
public Handle<NavigationCorrection> CorrectionOnPush { get; set;}

[REDProp("correctionOnNavMesh")]
public Handle<NavigationCorrection> CorrectionOnNavMesh { get; set;}

[REDProp("correctionOnExploration")]
public Handle<NavigationCorrection> CorrectionOnExploration { get; set;}

[REDProp("correctionOnDoors")]
public Handle<NavigationCorrection> CorrectionOnDoors { get; set;}

[REDProp("correctionOnFalling")]
public Handle<NavigationCorrection> CorrectionOnFalling { get; set;}

[REDProp("correctionAccepted")]
public Handle<NavigationCorrection> CorrectionAccepted { get; set;}

[REDProp("validExploration")]
public SExplorationQueryToken ValidExploration { get; set;}

[REDProp("checkingForRun")]
public bool CheckingForRun { get; set;}

[REDProp("checkingForCombat")]
public bool CheckingForCombat { get; set;}

[REDProp("inputDiference")]
public float InputDiference { get; set;}

[REDProp("pushSlowingTimeCooldown")]
public float PushSlowingTimeCooldown { get; set;}

[REDProp("pushSlowingTimeCur")]
public float PushSlowingTimeCur { get; set;}

[REDProp("maxPushAngleSlow")]
public float MaxPushAngleSlow { get; set;}

[REDProp("maxPushAngleTurn")]
public float MaxPushAngleTurn { get; set;}

[REDProp("pushCooldownTotal")]
public float PushCooldownTotal { get; set;}

[REDProp("pushCooldownCur")]
public float PushCooldownCur { get; set;}

[REDProp("pushDirection")]
public Vector PushDirection { get; set;}

[REDProp("collisionStopped")]
public bool CollisionStopped { get; set;}

[REDProp("enableCollisionWalking")]
public bool EnableCollisionWalking { get; set;}

[REDProp("enableCollisionRunning")]
public bool EnableCollisionRunning { get; set;}

[REDProp("enablePushCombat")]
public bool EnablePushCombat { get; set;}

[REDProp("enablePushWhileMoving")]
public bool EnablePushWhileMoving { get; set;}

[REDProp("enablePhysicsWalking")]
public bool EnablePhysicsWalking { get; set;}

[REDProp("enablePhysicsRunning")]
public bool EnablePhysicsRunning { get; set;}

[REDProp("enableNavMeshWalking")]
public bool EnableNavMeshWalking { get; set;}

[REDProp("enableNavMeshRunning")]
public bool EnableNavMeshRunning { get; set;}

[REDProp("enableExplorationWalking")]
public bool EnableExplorationWalking { get; set;}

[REDProp("enableExplorationRunning")]
public bool EnableExplorationRunning { get; set;}

[REDProp("enableDoorsWalking")]
public bool EnableDoorsWalking { get; set;}

[REDProp("enableDoorsRunning")]
public bool EnableDoorsRunning { get; set;}

[REDProp("limitCorrectionTurningSide")]
public bool LimitCorrectionTurningSide { get; set;}

[REDProp("inputDifToSide")]
public float InputDifToSide { get; set;}

[REDProp("maxPhysicSideDistance")]
public float MaxPhysicSideDistance { get; set;}

[REDProp("maxPhysicPortalDistance")]
public float MaxPhysicPortalDistance { get; set;}

[REDProp("maxPhysicDistanceWalk")]
public float MaxPhysicDistanceWalk { get; set;}

[REDProp("maxPhysicDistanceRun")]
public float MaxPhysicDistanceRun { get; set;}

[REDProp("maxPhysicAngleWalk")]
public float MaxPhysicAngleWalk { get; set;}

[REDProp("maxPhysicAngleRun")]
public float MaxPhysicAngleRun { get; set;}

[REDProp("maxNavmeshDistanceWalk")]
public float MaxNavmeshDistanceWalk { get; set;}

[REDProp("maxNavmeshDistanceRun")]
public float MaxNavmeshDistanceRun { get; set;}

[REDProp("maxNavmeshAngleWalk")]
public float MaxNavmeshAngleWalk { get; set;}

[REDProp("maxNavmeshAngleRun")]
public float MaxNavmeshAngleRun { get; set;}

[REDProp("maxExplorationDistanceWalk")]
public float MaxExplorationDistanceWalk { get; set;}

[REDProp("maxExplorationDistanceRun")]
public float MaxExplorationDistanceRun { get; set;}

[REDProp("maxExplorationAngleWalk")]
public float MaxExplorationAngleWalk { get; set;}

[REDProp("maxExplorationAngleRun")]
public float MaxExplorationAngleRun { get; set;}

[REDProp("maxDoorDistanceWalk")]
public float MaxDoorDistanceWalk { get; set;}

[REDProp("maxDoorDistanceRun")]
public float MaxDoorDistanceRun { get; set;}

[REDProp("maxDoorAngleWalk")]
public float MaxDoorAngleWalk { get; set;}

[REDProp("maxDoorAngleRun")]
public float MaxDoorAngleRun { get; set;}

[REDProp("maxDoorAngleGather")]
public float MaxDoorAngleGather { get; set;}

[REDProp("maxDoorBack")]
public float MaxDoorBack { get; set;}

[REDProp("maxDoorHeight")]
public float MaxDoorHeight { get; set;}

[REDProp("turnAdjustBlocked")]
public bool TurnAdjustBlocked { get; set;}

[REDProp("animEventBlockTurnAdjust")]
public CName AnimEventBlockTurnAdjust { get; set;}

[REDProp("turnAdjustmentEnabled")]
public bool TurnAdjustmentEnabled { get; set;}

[REDProp("turnAdjustmentTimeCur")]
public float TurnAdjustmentTimeCur { get; set;}

[REDProp("turnAdjustmentTimeMax")]
public float TurnAdjustmentTimeMax { get; set;}

[REDProp("inputLastModule")]
public float InputLastModule { get; set;}

[REDProp("inputSpeedLast")]
public float InputSpeedLast { get; set;}

[REDProp("inputSpeedToStartRun")]
public float InputSpeedToStartRun { get; set;}

[REDProp("inputSpeedToStartRunHiFPS")]
public float InputSpeedToStartRunHiFPS { get; set;}

[REDProp("cameraRequestByDoor")]
public bool CameraRequestByDoor { get; set;}

[REDProp("doorPoint")]
public Vector DoorPoint { get; set;}

[REDProp("auxDiff")]
public float AuxDiff { get; set;}

[REDProp("debugPush")]
public bool DebugPush { get; set;}

[REDProp("debugingSpeed")]
public bool DebugingSpeed { get; set;}

[REDProp("disallowRotWhenGoingToSleep")]
public bool DisallowRotWhenGoingToSleep { get; set;}

#endregion
}
}