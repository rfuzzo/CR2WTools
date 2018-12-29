using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4PlayerStateSwimming : CR4PlayerStateExtendedMovable
{
#region RED Properties

[REDProp("START_SWIMMING_WATER_LEVEL")]
public float START_SWIMMING_WATER_LEVEL { get; set;}

[REDProp("LEAVE_STATE_WATER_LEVEL")]
public float LEAVE_STATE_WATER_LEVEL { get; set;}

[REDProp("LEAVE_STATE_SUBMERGE_DEPTH")]
public float LEAVE_STATE_SUBMERGE_DEPTH { get; set;}

[REDProp("WALK_DEEP_WATER_LEVEL")]
public float WALK_DEEP_WATER_LEVEL { get; set;}

[REDProp("MIN_WATER_LEVEL_FOR_DIVING")]
public float MIN_WATER_LEVEL_FOR_DIVING { get; set;}

[REDProp("ENTER_DIVING_WATER_LEVEL")]
public float ENTER_DIVING_WATER_LEVEL { get; set;}

[REDProp("EXIT_DIVING_WATER_LEVEL")]
public float EXIT_DIVING_WATER_LEVEL { get; set;}

[REDProp("MINIMAL_SUBMERGE_DEPTH")]
public float MINIMAL_SUBMERGE_DEPTH { get; set;}

[REDProp("jumpToWaterAnimDist")]
public float JumpToWaterAnimDist { get; set;}

[REDProp("swimToIdleAnimDist")]
public float SwimToIdleAnimDist { get; set;}

[REDProp("splashEntityTemplate")]
public Handle<CEntityTemplate> SplashEntityTemplate { get; set;}

[REDProp("walkDeep")]
public bool WalkDeep { get; set;}

[REDProp("swimming")]
public bool Swimming { get; set;}

[REDProp("diving")]
public bool Diving { get; set;}

[REDProp("divingStarting")]
public bool DivingStarting { get; set;}

[REDProp("swimStart")]
public bool SwimStart { get; set;}

[REDProp("unlimitedDiving")]
public bool UnlimitedDiving { get; set;}

[REDProp("swimStagger")]
public bool SwimStagger { get; set;}

[REDProp("minSubmergeDepthReached")]
public bool MinSubmergeDepthReached { get; set;}

[REDProp("inDivingState")]
public bool InDivingState { get; set;}

[REDProp("divingEnd")]
public bool DivingEnd { get; set;}

[REDProp("blockPopState")]
public bool BlockPopState { get; set;}

[REDProp("usePredicitonDepth")]
public bool UsePredicitonDepth { get; set;}

[REDProp("divingEffectPlaying")]
public bool DivingEffectPlaying { get; set;}

[REDProp("jumpToWaterInProgress")]
public bool JumpToWaterInProgress { get; set;}

[REDProp("startSwimPos")]
public Vector StartSwimPos { get; set;}

[REDProp("isCiri")]
public bool IsCiri { get; set;}

[REDProp("currentWaterDepth")]
public float CurrentWaterDepth { get; set;}

[REDProp("cachedVerCameraTimeout")]
public float CachedVerCameraTimeout { get; set;}

[REDProp("defaultEmergeSpeed")]
public float DefaultEmergeSpeed { get; set;}

[REDProp("windPower")]
public float WindPower { get; set;}

[REDProp("predictedWaterDepth")]
public float PredictedWaterDepth { get; set;}

[REDProp("blockDiveDown")]
public bool BlockDiveDown { get; set;}

[REDProp("runJumpInProgress")]
public bool RunJumpInProgress { get; set;}

[REDProp("cameraIsUnderwater")]
public bool CameraIsUnderwater { get; set;}

[REDProp("cameraPitch")]
public float CameraPitch { get; set;}

#endregion
}
}