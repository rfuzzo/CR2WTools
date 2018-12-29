using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CClimbProbe : CObject
{
#region RED Properties

[REDProp("valid")]
public bool Valid { get; set;}

[REDProp("setupReady")]
public bool SetupReady { get; set;}

[REDProp("exploratorPosition")]
public Vector ExploratorPosition { get; set;}

[REDProp("directionChecking")]
public Vector DirectionChecking { get; set;}

[REDProp("directionRequiresInput")]
public bool DirectionRequiresInput { get; set;}

[REDProp("distForwardToCheck")]
public float DistForwardToCheck { get; set;}

[REDProp("distanceCheckType")]
public EClimbDistanceType DistanceCheckType { get; set;}

[REDProp("distForwardToCheckClose")]
public float DistForwardToCheckClose { get; set;}

[REDProp("distForwardToCheckMedium")]
public float DistForwardToCheckMedium { get; set;}

[REDProp("maxAttempts")]
public Int32 MaxAttempts { get; set;}

[REDProp("distForwardToCheckLong")]
public float DistForwardToCheckLong { get; set;}

[REDProp("characterRadius")]
public float CharacterRadius { get; set;}

[REDProp("heightTotalMin")]
public float HeightTotalMin { get; set;}

[REDProp("heightTotalMax")]
public float HeightTotalMax { get; set;}

[REDProp("ceilingDoubleCheck")]
public bool CeilingDoubleCheck { get; set;}

[REDProp("ceilingCheckingClose")]
public bool CeilingCheckingClose { get; set;}

[REDProp("ceilingBackOffsetClose")]
public float CeilingBackOffsetClose { get; set;}

[REDProp("ceilingBackOffsetFar")]
public float CeilingBackOffsetFar { get; set;}

[REDProp("ceilingHeightNeeded")]
public float CeilingHeightNeeded { get; set;}

[REDProp("ceilingRadius")]
public float CeilingRadius { get; set;}

[REDProp("ceilingFound")]
public bool CeilingFound { get; set;}

[REDProp("ceilingPoint")]
public Vector CeilingPoint { get; set;}

[REDProp("ceilingHeightFree")]
public float CeilingHeightFree { get; set;}

[REDProp("ceilingCheckFrom")]
public Vector CeilingCheckFrom { get; set;}

[REDProp("ceilingCheckTo")]
public Vector CeilingCheckTo { get; set;}

[REDProp("groundRadiusToCheck")]
public float GroundRadiusToCheck { get; set;}

[REDProp("groundNormalMinZ")]
public float GroundNormalMinZ { get; set;}

[REDProp("groundFound")]
public bool GroundFound { get; set;}

[REDProp("groundEndPoint")]
public Vector GroundEndPoint { get; set;}

[REDProp("groundEndNormal")]
public Vector GroundEndNormal { get; set;}

[REDProp("heightTarget")]
public float HeightTarget { get; set;}

[REDProp("heightAdded")]
public float HeightAdded { get; set;}

[REDProp("groundCheckFrom")]
public Vector GroundCheckFrom { get; set;}

[REDProp("groundCheckTo")]
public Vector GroundCheckTo { get; set;}

[REDProp("groundRefineEnabled")]
public bool GroundRefineEnabled { get; set;}

[REDProp("groundRefineDistCheck")]
public float GroundRefineDistCheck { get; set;}

[REDProp("groundRefineHeightCheck")]
public float GroundRefineHeightCheck { get; set;}

[REDProp("groundRefineRadius")]
public float GroundRefineRadius { get; set;}

[REDProp("groundRefined")]
public bool GroundRefined { get; set;}

[REDProp("climbableFound")]
public bool ClimbableFound { get; set;}

[REDProp("climbableObjName")]
public string ClimbableObjName { get; set;}

[REDProp("climbableObjTagOnLayer")]
public bool ClimbableObjTagOnLayer { get; set;}

[REDProp("climbableObjForceAllow")]
public bool ClimbableObjForceAllow { get; set;}

[REDProp("climbablePoint")]
public Vector ClimbablePoint { get; set;}

[REDProp("climbableRadius")]
public float ClimbableRadius { get; set;}

[REDProp("climbableLockTag")]
public CName ClimbableLockTag { get; set;}

[REDProp("climbableUnLockTag")]
public CName ClimbableUnLockTag { get; set;}

[REDProp("holeForwardNeeded")]
public float HoleForwardNeeded { get; set;}

[REDProp("holeIsBlocked")]
public bool HoleIsBlocked { get; set;}

[REDProp("holeCollision")]
public Vector HoleCollision { get; set;}

[REDProp("holeCheckFrom")]
public Vector HoleCheckFrom { get; set;}

[REDProp("holeCheckTo")]
public Vector HoleCheckTo { get; set;}

[REDProp("wallRadiusToCheck")]
public float WallRadiusToCheck { get; set;}

[REDProp("wallNormalCheckBackExtra")]
public float WallNormalCheckBackExtra { get; set;}

[REDProp("wallSideSeparation")]
public float WallSideSeparation { get; set;}

[REDProp("wallFound")]
public bool WallFound { get; set;}

[REDProp("wallNormalOrigin")]
public Vector WallNormalOrigin { get; set;}

[REDProp("wallNormalDirection")]
public Vector WallNormalDirection { get; set;}

[REDProp("wallCheckFromL")]
public Vector WallCheckFromL { get; set;}

[REDProp("wallCheckToL")]
public Vector WallCheckToL { get; set;}

[REDProp("wallCheckFromR")]
public Vector WallCheckFromR { get; set;}

[REDProp("wallCheckToR")]
public Vector WallCheckToR { get; set;}

[REDProp("wallCollL")]
public Vector WallCollL { get; set;}

[REDProp("wallCollR")]
public Vector WallCollR { get; set;}

[REDProp("slopeAngleMax")]
public float SlopeAngleMax { get; set;}

[REDProp("slopeNormalZMax")]
public float SlopeNormalZMax { get; set;}

[REDProp("slopeForwardDistance")]
public float SlopeForwardDistance { get; set;}

[REDProp("slopeLeftDistance")]
public float SlopeLeftDistance { get; set;}

[REDProp("horizHeightRdius")]
public float HorizHeightRdius { get; set;}

[REDProp("horizHeightSeparation")]
public float HorizHeightSeparation { get; set;}

[REDProp("horizHeightAngleMin")]
public float HorizHeightAngleMin { get; set;}

[REDProp("horizHeightAngleMax")]
public float HorizHeightAngleMax { get; set;}

[REDProp("horizFoundLeft")]
public bool HorizFoundLeft { get; set;}

[REDProp("horizFoundRight")]
public bool HorizFoundRight { get; set;}

[REDProp("horizHeightAngleCur")]
public float HorizHeightAngleCur { get; set;}

[REDProp("horizPointLeft")]
public Vector HorizPointLeft { get; set;}

[REDProp("horizPointRight")]
public Vector HorizPointRight { get; set;}

[REDProp("horizCorrectSideCoef")]
public float HorizCorrectSideCoef { get; set;}

[REDProp("vertSlopeAngleOffset")]
public float VertSlopeAngleOffset { get; set;}

[REDProp("vertSlopeAngleMax")]
public float VertSlopeAngleMax { get; set;}

[REDProp("vertSlopeAngleCur")]
public float VertSlopeAngleCur { get; set;}

[REDProp("vertSlopeAngleFrom")]
public Vector VertSlopeAngleFrom { get; set;}

[REDProp("vertSlopeAngleTo")]
public Vector VertSlopeAngleTo { get; set;}

[REDProp("vertSlopeAnglePoint")]
public Vector VertSlopeAnglePoint { get; set;}

[REDProp("vertSlopeAngleLowOffset")]
public float VertSlopeAngleLowOffset { get; set;}

[REDProp("vertSlopeLowAngleMax")]
public float VertSlopeLowAngleMax { get; set;}

[REDProp("vertSlopeLowAngleCur")]
public float VertSlopeLowAngleCur { get; set;}

[REDProp("vertSlopeLowAngleFrom")]
public Vector VertSlopeLowAngleFrom { get; set;}

[REDProp("vertSlopeLowAngleTo")]
public Vector VertSlopeLowAngleTo { get; set;}

[REDProp("vertSlopeLowAnglePoint")]
public Vector VertSlopeLowAnglePoint { get; set;}

[REDProp("vertFreeHeightEnable")]
public bool VertFreeHeightEnable { get; set;}

[REDProp("vertFreeHorOffset")]
public float VertFreeHorOffset { get; set;}

[REDProp("vertFreeHorMin")]
public float VertFreeHorMin { get; set;}

[REDProp("vertFreeHeightMin")]
public float VertFreeHeightMin { get; set;}

[REDProp("vertFreeHeightGrndMax")]
public float VertFreeHeightGrndMax { get; set;}

[REDProp("vertFreeHeightCur")]
public float VertFreeHeightCur { get; set;}

[REDProp("vertFreeFrom")]
public Vector VertFreeFrom { get; set;}

[REDProp("vertFreeTo")]
public Vector VertFreeTo { get; set;}

[REDProp("vertFreeCollPoint")]
public Vector VertFreeCollPoint { get; set;}

[REDProp("vaultHeight")]
public float VaultHeight { get; set;}

[REDProp("vaultHeightOffset")]
public float VaultHeightOffset { get; set;}

[REDProp("vaultDistance")]
public float VaultDistance { get; set;}

[REDProp("vaultRadius")]
public float VaultRadius { get; set;}

[REDProp("heightOffsetToEndFall")]
public float HeightOffsetToEndFall { get; set;}

[REDProp("heighAbsToEndFall")]
public float HeighAbsToEndFall { get; set;}

[REDProp("vaultingFound")]
public EClimbRequirementVault VaultingFound { get; set;}

[REDProp("vaultCollision")]
public Vector VaultCollision { get; set;}

[REDProp("vaultEndsFalling")]
public bool VaultEndsFalling { get; set;}

[REDProp("vaultCheckFrom")]
public Vector VaultCheckFrom { get; set;}

[REDProp("vaultCheckTo")]
public Vector VaultCheckTo { get; set;}

[REDProp("platformFound")]
public EClimbRequirementPlatform PlatformFound { get; set;}

[REDProp("platformFrom")]
public Vector PlatformFrom { get; set;}

[REDProp("platformTo")]
public Vector PlatformTo { get; set;}

[REDProp("platformCollision")]
public Vector PlatformCollision { get; set;}

[REDProp("platformHeightDown")]
public float PlatformHeightDown { get; set;}

[REDProp("platformRadius")]
public float PlatformRadius { get; set;}

[REDProp("platformDeep")]
public float PlatformDeep { get; set;}

[REDProp("platformMinToCheck")]
public float PlatformMinToCheck { get; set;}

[REDProp("collisionClimbableNames")]
public Array<CName> CollisionClimbableNames { get; set;}

[REDProp("collisionObstaclesNames")]
public Array<CName> CollisionObstaclesNames { get; set;}

[REDProp("collisionForceAllowNames")]
public Array<CName> CollisionForceAllowNames { get; set;}

[REDProp("collisionLockNames")]
public Array<CName> CollisionLockNames { get; set;}

[REDProp("debugPrefix")]
public string DebugPrefix { get; set;}

[REDProp("debugIsTop")]
public string DebugIsTop { get; set;}

[REDProp("debugColorDiv")]
public Int32 DebugColorDiv { get; set;}

[REDProp("debugLogFails")]
public bool DebugLogFails { get; set;}

[REDProp("onlyDebugPoint")]
public Vector OnlyDebugPoint { get; set;}

[REDProp("debugLastErrorMessage")]
public string DebugLastErrorMessage { get; set;}

[REDProp("debugLastErrorPosition")]
public Vector DebugLastErrorPosition { get; set;}

[REDProp("debugDrawGraphics")]
public bool DebugDrawGraphics { get; set;}

[REDProp("debugCeiling")]
public bool DebugCeiling { get; set;}

[REDProp("debugGround")]
public bool DebugGround { get; set;}

[REDProp("debugWall")]
public bool DebugWall { get; set;}

[REDProp("debugHole")]
public bool DebugHole { get; set;}

[REDProp("debugVault")]
public bool DebugVault { get; set;}

[REDProp("debugVertSlope")]
public bool DebugVertSlope { get; set;}

[REDProp("debugVertFree")]
public bool DebugVertFree { get; set;}

[REDProp("debugHorSlope")]
public bool DebugHorSlope { get; set;}

[REDProp("debugPlatform")]
public bool DebugPlatform { get; set;}

[REDProp("vectorUp")]
public Vector VectorUp { get; set;}

[REDProp("vectorZero")]
public Vector VectorZero { get; set;}

#endregion
}
}