using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAreaEnvironmentComponent : CTriggerAreaComponent
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

[REDProp("priority")]
public int Priority { get; set;}

[REDProp("blendingDistance")]
public float BlendingDistance { get; set;}

[REDProp("blendingScale")]
public float BlendingScale { get; set;}

[REDProp("blendInTime")]
public float BlendInTime { get; set;}

[REDProp("blendOutTime")]
public float BlendOutTime { get; set;}

[REDProp("terrainBlendingDistance")]
public float TerrainBlendingDistance { get; set;}

[REDProp("blendAboveAndBelow")]
public bool BlendAboveAndBelow { get; set;}

[REDProp("rainDropsParticleSystem")]
public Handle<CParticleSystem> RainDropsParticleSystem { get; set;}

[REDProp("rainSplashesParticleSystem")]
public Handle<CParticleSystem> RainSplashesParticleSystem { get; set;}

[REDProp("additionalEnvEntity")]
public Handle<CEntityTemplate> AdditionalEnvEntity { get; set;}

[REDProp("environmentDefinition")]
public Handle<CEnvironmentDefinition> EnvironmentDefinition { get; set;}

[REDProp("blendingCurveEnabled")]
public bool BlendingCurveEnabled { get; set;}

[REDProp("blendingCurve")]
public SSimpleCurve BlendingCurve { get; set;}

[REDProp("points")]
public Array<SAreaEnvironmentPoint> Points { get; set;}

#endregion
}
}