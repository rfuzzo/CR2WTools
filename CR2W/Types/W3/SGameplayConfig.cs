using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SGameplayConfig 
{
#region RED Properties

[REDProp("gameCamera")]
public SGameplayConfigGameCamera GameCamera { get; set;}

[REDProp("LOD")]
public SGameplayLODConfig LOD { get; set;}

[REDProp("debugA")]
public float DebugA { get; set;}

[REDProp("debugB")]
public float DebugB { get; set;}

[REDProp("debugC")]
public float DebugC { get; set;}

[REDProp("debugD")]
public float DebugD { get; set;}

[REDProp("debugE")]
public float DebugE { get; set;}

[REDProp("debugF")]
public float DebugF { get; set;}

[REDProp("debugG")]
public float DebugG { get; set;}

[REDProp("horseProp")]
public bool HorseProp { get; set;}

[REDProp("horseSpeedCtrl")]
public bool HorseSpeedCtrl { get; set;}

[REDProp("horseSpeedInc")]
public float HorseSpeedInc { get; set;}

[REDProp("horseSpeedDec")]
public float HorseSpeedDec { get; set;}

[REDProp("horseSpeedStep")]
public float HorseSpeedStep { get; set;}

[REDProp("horseInputCooldown")]
public float HorseInputCooldown { get; set;}

[REDProp("horseStaminaInc")]
public float HorseStaminaInc { get; set;}

[REDProp("horseStaminaDec")]
public float HorseStaminaDec { get; set;}

[REDProp("horseStaminaCooldown")]
public float HorseStaminaCooldown { get; set;}

[REDProp("horseSpeedDecCooldown")]
public float HorseSpeedDecCooldown { get; set;}

[REDProp("horsePathFactor")]
public float HorsePathFactor { get; set;}

[REDProp("horsePathDamping")]
public float HorsePathDamping { get; set;}

[REDProp("horseRoadSearchRadius")]
public float HorseRoadSearchRadius { get; set;}

[REDProp("horseRoadSearchDistanceSlow")]
public float HorseRoadSearchDistanceSlow { get; set;}

[REDProp("horseRoadSearchDistanceFast")]
public float HorseRoadSearchDistanceFast { get; set;}

[REDProp("horseRoadSelectionAngleCoeff")]
public float HorseRoadSelectionAngleCoeff { get; set;}

[REDProp("horseRoadSelectionDistanceCoeff")]
public float HorseRoadSelectionDistanceCoeff { get; set;}

[REDProp("horseRoadSelectionCurrentRoadPreferenceCoeff")]
public float HorseRoadSelectionCurrentRoadPreferenceCoeff { get; set;}

[REDProp("horseRoadSelectionTurnAmountFeeCoeff")]
public float HorseRoadSelectionTurnAmountFeeCoeff { get; set;}

[REDProp("horseRoadFollowingCooldownTime")]
public float HorseRoadFollowingCooldownTime { get; set;}

[REDProp("horseRoadFollowingCooldownDistance")]
public float HorseRoadFollowingCooldownDistance { get; set;}

[REDProp("strayActorDespawnDistance")]
public float StrayActorDespawnDistance { get; set;}

[REDProp("strayActorMaxHoursToKeep")]
public int StrayActorMaxHoursToKeep { get; set;}

[REDProp("strayActorMaxActorsToKeep")]
public int StrayActorMaxActorsToKeep { get; set;}

[REDProp("playerPreviewInventory")]
public int PlayerPreviewInventory { get; set;}

[REDProp("interactionTestCameraRange")]
public bool InteractionTestCameraRange { get; set;}

[REDProp("interactionTestCameraRangeAngle")]
public float InteractionTestCameraRangeAngle { get; set;}

[REDProp("interactionTestPlayerRange")]
public bool InteractionTestPlayerRange { get; set;}

[REDProp("interactionTestPlayerRangeAngle")]
public float InteractionTestPlayerRangeAngle { get; set;}

[REDProp("interactionTestIsInPlayerRadius")]
public bool InteractionTestIsInPlayerRadius { get; set;}

[REDProp("interactionTestPlayerRadius")]
public float InteractionTestPlayerRadius { get; set;}

[REDProp("forceLookAtPlayer")]
public bool ForceLookAtPlayer { get; set;}

[REDProp("forceLookAtPlayerDist")]
public float ForceLookAtPlayerDist { get; set;}

[REDProp("useBehaviorLod")]
public bool UseBehaviorLod { get; set;}

[REDProp("forceBehaviorLod")]
public bool ForceBehaviorLod { get; set;}

[REDProp("forceBehaviorLodLevel")]
public int ForceBehaviorLodLevel { get; set;}

[REDProp("logMissingAnimations")]
public bool LogMissingAnimations { get; set;}

[REDProp("logRequestedAnimations")]
public bool LogRequestedAnimations { get; set;}

[REDProp("logSampledAnimations")]
public bool LogSampledAnimations { get; set;}

[REDProp("animationMultiUpdate")]
public bool AnimationMultiUpdate { get; set;}

[REDProp("animationAsyncUpdate")]
public bool AnimationAsyncUpdate { get; set;}

[REDProp("animationAsyncJobs")]
public bool AnimationAsyncJobs { get; set;}

[REDProp("animationCanUseAsyncJobs")]
public bool AnimationCanUseAsyncJobs { get; set;}

[REDProp("animationAsyncJobsUpdateFrustum")]
public bool AnimationAsyncJobsUpdateFrustum { get; set;}

[REDProp("useWorkFreezing")]
public bool UseWorkFreezing { get; set;}

[REDProp("streamOnlyVisibleLayers")]
public bool StreamOnlyVisibleLayers { get; set;}

[REDProp("workFreezingRadiusForInvisibleActors")]
public float WorkFreezingRadiusForInvisibleActors { get; set;}

[REDProp("workSynchronization")]
public bool WorkSynchronization { get; set;}

[REDProp("workResetInFreezing")]
public bool WorkResetInFreezing { get; set;}

[REDProp("workFreezingDelay")]
public float WorkFreezingDelay { get; set;}

[REDProp("workMaxFreezingTime")]
public float WorkMaxFreezingTime { get; set;}

[REDProp("workAnimSpeedMulMin")]
public float WorkAnimSpeedMulMin { get; set;}

[REDProp("workAnimSpeedMulMax")]
public float WorkAnimSpeedMulMax { get; set;}

[REDProp("workMaxAnimOffset")]
public float WorkMaxAnimOffset { get; set;}

[REDProp("lookAtConfig")]
public SGameplayConfigLookAts LookAtConfig { get; set;}

[REDProp("cameraHidePlayerDistMin")]
public float CameraHidePlayerDistMin { get; set;}

[REDProp("cameraHidePlayerDistMax")]
public float CameraHidePlayerDistMax { get; set;}

[REDProp("cameraHidePlayerSwordsDistMin")]
public float CameraHidePlayerSwordsDistMin { get; set;}

[REDProp("cameraHidePlayerSwordsDistMax")]
public float CameraHidePlayerSwordsDistMax { get; set;}

[REDProp("cameraHidePlayerSwordsAngleMin")]
public float CameraHidePlayerSwordsAngleMin { get; set;}

[REDProp("cameraHidePlayerSwordsAngleMax")]
public float CameraHidePlayerSwordsAngleMax { get; set;}

[REDProp("cameraPositionDamp")]
public bool CameraPositionDamp { get; set;}

[REDProp("cameraPositionDampLength")]
public float CameraPositionDampLength { get; set;}

[REDProp("cameraPositionDampLengthOffset")]
public float CameraPositionDampLengthOffset { get; set;}

[REDProp("cameraPositionDampSpeed")]
public float CameraPositionDampSpeed { get; set;}

[REDProp("processNpcsAndCameraCollisions")]
public bool ProcessNpcsAndCameraCollisions { get; set;}

[REDProp("physicsTerrainAdditionalElevation")]
public float PhysicsTerrainAdditionalElevation { get; set;}

[REDProp("physicsTerrainThickness")]
public float PhysicsTerrainThickness { get; set;}

[REDProp("physicsKillingZVelocity")]
public float PhysicsKillingZVelocity { get; set;}

[REDProp("physicsTerrainDebugMaxSlope")]
public float PhysicsTerrainDebugMaxSlope { get; set;}

[REDProp("physicsTerrainDebugRange")]
public float PhysicsTerrainDebugRange { get; set;}

[REDProp("physicsCollisionPredictionTime")]
public float PhysicsCollisionPredictionTime { get; set;}

[REDProp("physicsCollisionPredictionSteps")]
public uint PhysicsCollisionPredictionSteps { get; set;}

[REDProp("physicsCCTMaxDisp")]
public float PhysicsCCTMaxDisp { get; set;}

[REDProp("virtualRadiusTime")]
public float VirtualRadiusTime { get; set;}

[REDProp("movingSwimmingOffset")]
public float MovingSwimmingOffset { get; set;}

[REDProp("emergeSpeed")]
public float EmergeSpeed { get; set;}

[REDProp("submergeSpeed")]
public float SubmergeSpeed { get; set;}

[REDProp("terrainInfluenceLimitMin")]
public float TerrainInfluenceLimitMin { get; set;}

[REDProp("terrainInfluenceLimitMax")]
public float TerrainInfluenceLimitMax { get; set;}

[REDProp("terrainInfluenceMul")]
public float TerrainInfluenceMul { get; set;}

[REDProp("slidingLimitMin")]
public float SlidingLimitMin { get; set;}

[REDProp("slidingLimitMax")]
public float SlidingLimitMax { get; set;}

[REDProp("slidingDamping")]
public float SlidingDamping { get; set;}

[REDProp("maxPlatformDisplacement")]
public float MaxPlatformDisplacement { get; set;}

[REDProp("showSegments")]
public bool ShowSegments { get; set;}

[REDProp("showRotations")]
public bool ShowRotations { get; set;}

[REDProp("showNodes")]
public bool ShowNodes { get; set;}

[REDProp("curvePrecision")]
public int CurvePrecision { get; set;}

[REDProp("timeScale")]
public float TimeScale { get; set;}

[REDProp("gcAfterCutscenesWithCamera")]
public bool GcAfterCutscenesWithCamera { get; set;}

[REDProp("gcAfterNotGameplayScenes")]
public bool GcAfterNotGameplayScenes { get; set;}

[REDProp("autosaveCooldown")]
public float AutosaveCooldown { get; set;}

[REDProp("autosaveDelay")]
public float AutosaveDelay { get; set;}

[REDProp("doNotClickMe")]
public bool DoNotClickMe { get; set;}

[REDProp("enableMeshFlushInScenes")]
public bool EnableMeshFlushInScenes { get; set;}

[REDProp("enableSceneRewind")]
public bool EnableSceneRewind { get; set;}

[REDProp("enableTextureFlushInScenes")]
public bool EnableTextureFlushInScenes { get; set;}

[REDProp("enableAnimationFlushInScenes")]
public bool EnableAnimationFlushInScenes { get; set;}

[REDProp("enableSimplePriorityLoadingInScenes")]
public bool EnableSimplePriorityLoadingInScenes { get; set;}

[REDProp("useFrozenFrameInsteadOfBlackscreen")]
public bool UseFrozenFrameInsteadOfBlackscreen { get; set;}

[REDProp("sceneIgnoreInputDuration")]
public float SceneIgnoreInputDuration { get; set;}

[REDProp("movementTorsoDamp")]
public float MovementTorsoDamp { get; set;}

[REDProp("movementRotDamp")]
public float MovementRotDamp { get; set;}

[REDProp("movementSmoothing")]
public float MovementSmoothing { get; set;}

[REDProp("movementSmoothingOnHorse")]
public float MovementSmoothingOnHorse { get; set;}

[REDProp("idUseNewVoicePipeline")]
public bool IdUseNewVoicePipeline { get; set;}

[REDProp("woundDistanceWeight")]
public float WoundDistanceWeight { get; set;}

[REDProp("woundDirectionWeight")]
public float WoundDirectionWeight { get; set;}

#endregion
}
}