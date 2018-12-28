using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSoundAmbientAreaComponent : CSoftTriggerAreaComponent
{
#region RED Properties

[REDProp("tags")]
public TagList Tags { get; set;}

[REDProp("transform")]
public EngineTransform Transform { get; set;}

[REDProp("transformParent")]
public Ptr<CHardAttachment> TransformParent { get; set;}

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("isStreamed")]
public bool IsStreamed { get; set;}

[REDProp("boundingBox")]
public Box BoundingBox { get; set;}

[REDProp("height")]
public float Height { get; set;}

[REDProp("color")]
public Color Color { get; set;}

[REDProp("terrainSide")]
public EAreaTerrainSide TerrainSide { get; set;}

[REDProp("clippingMode")]
public EAreaClippingMode ClippingMode { get; set;}

[REDProp("clippingAreaTags")]
public TagList ClippingAreaTags { get; set;}

[REDProp("saveShapeToLayer")]
public bool SaveShapeToLayer { get; set;}

[REDProp("localPoints")]
public Array<Vector> LocalPoints { get; set;}

[REDProp("worldPoints")]
public Array<Vector> WorldPoints { get; set;}

[REDProp("isEnabled")]
public bool IsEnabled { get; set;}

[REDProp("includedChannels")]
public ETriggerChannel IncludedChannels { get; set;}

[REDProp("excludedChannels")]
public ETriggerChannel ExcludedChannels { get; set;}

[REDProp("triggerPriority")]
public uint TriggerPriority { get; set;}

[REDProp("enableCCD")]
public bool EnableCCD { get; set;}

[REDProp("outerClippingAreaTags")]
public TagList OuterClippingAreaTags { get; set;}

[REDProp("outerIncludedChannels")]
public ETriggerChannel OuterIncludedChannels { get; set;}

[REDProp("outerExcludedChannels")]
public ETriggerChannel OuterExcludedChannels { get; set;}

[REDProp("invertPenetrationFraction")]
public bool InvertPenetrationFraction { get; set;}

[REDProp("soundEvents")]
public StringAnsi SoundEvents { get; set;}

[REDProp("reverb")]
public SReverbDefinition Reverb { get; set;}

[REDProp("customEventOnEnter")]
public StringAnsi CustomEventOnEnter { get; set;}

[REDProp("soundEventsOnEnter")]
public Array<StringAnsi> SoundEventsOnEnter { get; set;}

[REDProp("soundEventsOnExit")]
public Array<StringAnsi> SoundEventsOnExit { get; set;}

[REDProp("enterExitEventsUsePosition")]
public bool EnterExitEventsUsePosition { get; set;}

[REDProp("intensityParameter")]
public float IntensityParameter { get; set;}

[REDProp("intensityParameterFadeTime")]
public float IntensityParameterFadeTime { get; set;}

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("maxDistanceVertical")]
public float MaxDistanceVertical { get; set;}

[REDProp("banksDependency")]
public Array<CName> BanksDependency { get; set;}

[REDProp("occlusionEnabled")]
public bool OcclusionEnabled { get; set;}

[REDProp("outerListnerReverbRatio")]
public float OuterListnerReverbRatio { get; set;}

[REDProp("priorityParameterMusic")]
public bool PriorityParameterMusic { get; set;}

[REDProp("parameterEnteringTime")]
public float ParameterEnteringTime { get; set;}

[REDProp("parameterEnteringCurve")]
public ESoundParameterCurveType ParameterEnteringCurve { get; set;}

[REDProp("parameterExitingTime")]
public float ParameterExitingTime { get; set;}

[REDProp("parameterExitingCurve")]
public ESoundParameterCurveType ParameterExitingCurve { get; set;}

[REDProp("useListernerDistance")]
public bool UseListernerDistance { get; set;}

[REDProp("isGate")]
public bool IsGate { get; set;}

[REDProp("gatewayRotation")]
public float GatewayRotation { get; set;}

[REDProp("isWalla")]
public bool IsWalla { get; set;}

[REDProp("wallaSoundEvents")]
public Array<StringAnsi> WallaSoundEvents { get; set;}

[REDProp("wallaEmitterSpread")]
public float WallaEmitterSpread { get; set;}

[REDProp("wallaOmniFactor")]
public float WallaOmniFactor { get; set;}

[REDProp("wallaMinDistance")]
public float WallaMinDistance { get; set;}

[REDProp("wallaMaxDistance")]
public float WallaMaxDistance { get; set;}

[REDProp("wallaBoxExtention")]
public float WallaBoxExtention { get; set;}

[REDProp("wallaRotation")]
public float WallaRotation { get; set;}

[REDProp("wallaAfraidRetriggerTime")]
public float WallaAfraidRetriggerTime { get; set;}

[REDProp("wallaAfraidDecreaseRate")]
public float WallaAfraidDecreaseRate { get; set;}

[REDProp("parameters")]
public Array<SSoundGameParameterValue> Parameters { get; set;}

[REDProp("parameterCulling")]
public Array<SSoundParameterCullSettings> ParameterCulling { get; set;}

[REDProp("fitWaterShore")]
public bool FitWaterShore { get; set;}

[REDProp("waterGridCellCount")]
public uint WaterGridCellCount { get; set;}

[REDProp("waterLevelOffset")]
public float WaterLevelOffset { get; set;}

[REDProp("fitFoliage")]
public bool FitFoliage { get; set;}

[REDProp("foliageMaxDistance")]
public float FoliageMaxDistance { get; set;}

[REDProp("foliageStepNeighbors")]
public uint FoliageStepNeighbors { get; set;}

[REDProp("foliageVitalAreaRadius")]
public float FoliageVitalAreaRadius { get; set;}

[REDProp("foliageVitalAreaPoints")]
public uint FoliageVitalAreaPoints { get; set;}

[REDProp("dynamicParameters")]
public Array<ESoundAmbientDynamicParameter> DynamicParameters { get; set;}

[REDProp("dynamicEvents")]
public Array<SSoundAmbientDynamicSoundEvents> DynamicEvents { get; set;}

#endregion
}
}