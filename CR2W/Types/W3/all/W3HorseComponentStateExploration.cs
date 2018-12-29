using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3HorseComponentStateExploration : CScriptableState
{
#region RED Properties

[REDProp("parentActor")]
public Handle<CActor> ParentActor { get; set;}

[REDProp("isStopping")]
public bool IsStopping { get; set;}

[REDProp("isSlowlyStopping")]
public bool IsSlowlyStopping { get; set;}

[REDProp("destSpeed")]
public float DestSpeed { get; set;}

[REDProp("currSpeed")]
public float CurrSpeed { get; set;}

[REDProp("staminaCooldown")]
public float StaminaCooldown { get; set;}

[REDProp("staminaCooldownTimer")]
public float StaminaCooldownTimer { get; set;}

[REDProp("staminaBreak")]
public bool StaminaBreak { get; set;}

[REDProp("speedImpulseTimestamp")]
public float SpeedImpulseTimestamp { get; set;}

[REDProp("dismountRequest")]
public bool DismountRequest { get; set;}

[REDProp("roadFollowBlock")]
public float RoadFollowBlock { get; set;}

[REDProp("speedLocks")]
public Array<CName> SpeedLocks { get; set;}

[REDProp("speedRestriction")]
public float SpeedRestriction { get; set;}

[REDProp("useSimpleStaminaManagement")]
public bool UseSimpleStaminaManagement { get; set;}

[REDProp("inclinationCheckCollisionGroups")]
public Array<CName> InclinationCheckCollisionGroups { get; set;}

[REDProp("waterCheckCollisionGroups")]
public Array<CName> WaterCheckCollisionGroups { get; set;}

[REDProp("threatSum")]
public float ThreatSum { get; set;}

[REDProp("triedDoubleTap")]
public bool TriedDoubleTap { get; set;}

[REDProp("mac")]
public Handle<CMovingAgentComponent> Mac { get; set;}

[REDProp("isFollowingRoad")]
public bool IsFollowingRoad { get; set;}

[REDProp("shouldGoToCanterAfterStop")]
public bool ShouldGoToCanterAfterStop { get; set;}

[REDProp("grassCollider")]
public Handle<CComponent> GrassCollider { get; set;}

[REDProp("currSpeedSound")]
public float CurrSpeedSound { get; set;}

[REDProp("desiredSpeedSound")]
public float DesiredSpeedSound { get; set;}

[REDProp("jumpStartPos")]
public Vector JumpStartPos { get; set;}

[REDProp("jumpEndPos")]
public Vector JumpEndPos { get; set;}

[REDProp("noSaveLock")]
public Int32 NoSaveLock { get; set;}

[REDProp("MIN_SPEED")]
public float MIN_SPEED { get; set;}

[REDProp("SLOW_SPEED")]
public float SLOW_SPEED { get; set;}

[REDProp("WALK_SPEED")]
public float WALK_SPEED { get; set;}

[REDProp("TROT_SPEED")]
public float TROT_SPEED { get; set;}

[REDProp("GALLOP_SPEED")]
public float GALLOP_SPEED { get; set;}

[REDProp("CANTER_SPEED")]
public float CANTER_SPEED { get; set;}

[REDProp("threatApplicationTimestamp")]
public float ThreatApplicationTimestamp { get; set;}

[REDProp("dismountFinishedTimeStamp")]
public float DismountFinishedTimeStamp { get; set;}

[REDProp("timeAfterDismountFinished")]
public float TimeAfterDismountFinished { get; set;}

[REDProp("cachedCombatAction")]
public EVehicleCombatAction CachedCombatAction { get; set;}

[REDProp("stopRequest")]
public bool StopRequest { get; set;}

[REDProp("isRefusingToGo")]
public bool IsRefusingToGo { get; set;}

[REDProp("collisionAnimTimestamp")]
public float CollisionAnimTimestamp { get; set;}

[REDProp("collsionAnimCooldown")]
public float CollsionAnimCooldown { get; set;}

[REDProp("prediction")]
public Handle<CHorsePrediction> Prediction { get; set;}

[REDProp("INPUTMAG_TROT")]
public float INPUTMAG_TROT { get; set;}

[REDProp("INPUTMAG_WALK")]
public float INPUTMAG_WALK { get; set;}

[REDProp("HEADING_WT")]
public float HEADING_WT { get; set;}

[REDProp("INPUT_WT")]
public float INPUT_WT { get; set;}

[REDProp("NAVDATA_RADIUS")]
public float NAVDATA_RADIUS { get; set;}

[REDProp("NAVDATA_LENGTH_MOD_TROT")]
public float NAVDATA_LENGTH_MOD_TROT { get; set;}

[REDProp("NAVDATA_LENGTH_MOD_GALLOP")]
public float NAVDATA_LENGTH_MOD_GALLOP { get; set;}

[REDProp("NAVDATA_LENGTH_MOD_CANTER")]
public float NAVDATA_LENGTH_MOD_CANTER { get; set;}

[REDProp("INCLINATION_MAX_ANGLE")]
public float INCLINATION_MAX_ANGLE { get; set;}

[REDProp("INCLINATION_BASE_DIST")]
public float INCLINATION_BASE_DIST { get; set;}

[REDProp("INCLINATION_TESTS_COUNT_TROT")]
public Int32 INCLINATION_TESTS_COUNT_TROT { get; set;}

[REDProp("INCLINATION_TESTS_COUNT_GALLOP")]
public Int32 INCLINATION_TESTS_COUNT_GALLOP { get; set;}

[REDProp("INCLINATION_TESTS_COUNT_CANTER")]
public Int32 INCLINATION_TESTS_COUNT_CANTER { get; set;}

[REDProp("INCLINATION_Z_OFFSET")]
public float INCLINATION_Z_OFFSET { get; set;}

[REDProp("WATER_MAX_DEPTH")]
public float WATER_MAX_DEPTH { get; set;}

[REDProp("WATER_DIST_TROT")]
public float WATER_DIST_TROT { get; set;}

[REDProp("WATER_DIST_GALLOP")]
public float WATER_DIST_GALLOP { get; set;}

[REDProp("WATER_DIST_CANTER")]
public float WATER_DIST_CANTER { get; set;}

[REDProp("NAVTEST_RADIUS")]
public float NAVTEST_RADIUS { get; set;}

[REDProp("rl")]
public float Rl { get; set;}

[REDProp("fb")]
public float Fb { get; set;}

[REDProp("startSlidingTimeStamp")]
public float StartSlidingTimeStamp { get; set;}

[REDProp("notSlidingTimeStamp")]
public float NotSlidingTimeStamp { get; set;}

[REDProp("SLIDING_MINSLIDINGCOEF")]
public float SLIDING_MINSLIDINGCOEF { get; set;}

[REDProp("SLIDING_MAXSLIDINTIME")]
public float SLIDING_MAXSLIDINTIME { get; set;}

[REDProp("SLIDING_MAXROTATIONSPEED")]
public float SLIDING_MAXROTATIONSPEED { get; set;}

[REDProp("requestJump")]
public bool RequestJump { get; set;}

[REDProp("isInJumpAnim")]
public bool IsInJumpAnim { get; set;}

[REDProp("startTestingLanding")]
public bool StartTestingLanding { get; set;}

[REDProp("maintainSpeedTimer")]
public float MaintainSpeedTimer { get; set;}

[REDProp("speedTimeoutValue")]
public float SpeedTimeoutValue { get; set;}

[REDProp("accelerateTimestamp")]
public float AccelerateTimestamp { get; set;}

[REDProp("DOUBLE_TAP_WINDOW")]
public float DOUBLE_TAP_WINDOW { get; set;}

[REDProp("jumpPressTimestamp")]
public float JumpPressTimestamp { get; set;}

[REDProp("voicsetTimeStamp")]
public float VoicsetTimeStamp { get; set;}

[REDProp("voicsetFasterTimeStamp")]
public float VoicsetFasterTimeStamp { get; set;}

[REDProp("voicsetSlowerTimeSTamp")]
public float VoicsetSlowerTimeSTamp { get; set;}

[REDProp("VOICESET_COOLDOWN")]
public float VOICESET_COOLDOWN { get; set;}

[REDProp("VOICESET_FASTER_COOLDOWN")]
public float VOICESET_FASTER_COOLDOWN { get; set;}

[REDProp("VOICESET_SLOWER_COOLDOWN")]
public float VOICESET_SLOWER_COOLDOWN { get; set;}

#endregion
}
}