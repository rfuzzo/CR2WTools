using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CCombatCameraPositionController : ICustomCameraPositionController
{
#region RED Properties

[REDProp("controllerName")]
public CName ControllerName { get; set;}

[REDProp("enableAutoCollisionAvoidance")]
public bool EnableAutoCollisionAvoidance { get; set;}

[REDProp("enableScreenSpaceCorrections")]
public bool EnableScreenSpaceCorrections { get; set;}

[REDProp("defaultCameraAngle")]
public float DefaultCameraAngle { get; set;}

[REDProp("defaultCameraZOffset")]
public float DefaultCameraZOffset { get; set;}

[REDProp("flipCameraAngle")]
public float FlipCameraAngle { get; set;}

[REDProp("followRotation")]
public Ptr<CCurve> FollowRotation { get; set;}

[REDProp("followRotationSprint")]
public Ptr<CCurve> FollowRotationSprint { get; set;}

[REDProp("followRotationFlip")]
public Ptr<CCurve> FollowRotationFlip { get; set;}

[REDProp("slopeCameraAngleChange")]
public Ptr<CCurve> SlopeCameraAngleChange { get; set;}

[REDProp("slopeAngleCameraSpaceMultiplier")]
public Ptr<CCurve> SlopeAngleCameraSpaceMultiplier { get; set;}

[REDProp("slopeResetTimeout")]
public Ptr<CCurve> SlopeResetTimeout { get; set;}

[REDProp("cameraPivotDampMult")]
public Ptr<CCurve> CameraPivotDampMult { get; set;}

[REDProp("combatPivotDampMult")]
public float CombatPivotDampMult { get; set;}

[REDProp("bigMonsterHeightThreshold")]
public float BigMonsterHeightThreshold { get; set;}

/*[REDProp("180FlipThreshold")]
public float 180FlipThreshold { get; set;}*/

[REDProp("explorationRotationCtrlName")]
public CName ExplorationRotationCtrlName { get; set;}

[REDProp("combatRotationCtrlName")]
public CName CombatRotationCtrlName { get; set;}

[REDProp("offsetSmoothTime")]
public float OffsetSmoothTime { get; set;}

[REDProp("combatPitch")]
public float CombatPitch { get; set;}

[REDProp("combatEnemiesToDistanceMap")]
public Array<SCameraDistanceInfo> CombatEnemiesToDistanceMap { get; set;}

[REDProp("bigMonsterCountMultiplier")]
public uint BigMonsterCountMultiplier { get; set;}

[REDProp("monsterSizeAdditiveOffset")]
public Ptr<CCurve> MonsterSizeAdditiveOffset { get; set;}

[REDProp("monsterSizeAdditivePitch")]
public Ptr<CCurve> MonsterSizeAdditivePitch { get; set;}

/*[REDProp("1v1Pitch")]
public Ptr<CCurve> 1v1Pitch { get; set;}

[REDProp("1v1AdditivePitch")]
public Ptr<CCurve> 1v1AdditivePitch { get; set;}

[REDProp("1v1BigMonsterPitch")]
public Ptr<CCurve> 1v1BigMonsterPitch { get; set;}

[REDProp("1v1BMAdditivePitch")]
public Ptr<CCurve> 1v1BMAdditivePitch { get; set;}

[REDProp("1v1Distance")]
public Ptr<CCurve> 1v1Distance { get; set;}

[REDProp("1v1SignificanceAddDistance")]
public Ptr<CCurve> 1v1SignificanceAddDistance { get; set;}

[REDProp("1v1ZOffset")]
public Ptr<CCurve> 1v1ZOffset { get; set;}

[REDProp("1v1BigMonsterZOffset")]
public Ptr<CCurve> 1v1BigMonsterZOffset { get; set;}

[REDProp("1v1PivotMultiplier")]
public float 1v1PivotMultiplier { get; set;}

[REDProp("1v1KeepAngle")]
public float 1v1KeepAngle { get; set;}

[REDProp("1v1OffScreenMult")]
public float 1v1OffScreenMult { get; set;}*/

[REDProp("oneOnOneCtrlName")]
public CName OneOnOneCtrlName { get; set;}

[REDProp("screenSpaceXRatio")]
public float ScreenSpaceXRatio { get; set;}

[REDProp("screenSpaceYRatio")]
public float ScreenSpaceYRatio { get; set;}

[REDProp("ssCorrectionXTreshold")]
public float SsCorrectionXTreshold { get; set;}

[REDProp("ssCorrectionYTreshold")]
public float SsCorrectionYTreshold { get; set;}

[REDProp("ssPivotCorrSmooth")]
public float SsPivotCorrSmooth { get; set;}

[REDProp("ssDistCorrSmooth")]
public float SsDistCorrSmooth { get; set;}

[REDProp("useExplorationCamInSprint")]
public bool UseExplorationCamInSprint { get; set;}

[REDProp("collisionController")]
public Ptr<ICustomCameraCollisionController> CollisionController { get; set;}

[REDProp("collisionController2")]
public Ptr<ICustomCameraCollisionController> CollisionController2 { get; set;}

[REDProp("defaultCollisionOriginOffset")]
public Vector DefaultCollisionOriginOffset { get; set;}

#endregion
}
}