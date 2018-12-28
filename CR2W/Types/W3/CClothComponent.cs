using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CClothComponent : CMeshTypeComponent
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

[REDProp("drawableFlags")]
public EDrawableFlags DrawableFlags { get; set;}

[REDProp("lightChannels")]
public ELightChannel LightChannels { get; set;}

[REDProp("renderingPlane")]
public ERenderingPlane RenderingPlane { get; set;}

[REDProp("forceLODLevel")]
public int ForceLODLevel { get; set;}

[REDProp("forceAutoHideDistance")]
public UInt16 ForceAutoHideDistance { get; set;}

[REDProp("shadowImportanceBias")]
public EMeshShadowImportanceBias ShadowImportanceBias { get; set;}

[REDProp("defaultEffectParams")]
public Vector DefaultEffectParams { get; set;}

[REDProp("defaultEffectColor")]
public Color DefaultEffectColor { get; set;}

[REDProp("resource")]
public Handle<CApexResource> Resource { get; set;}

/*[REDProp("dispacher selection")]
public EDispatcherSelection Dispacher selection { get; set;}*/

[REDProp("recomputeNormals")]
public bool RecomputeNormals { get; set;}

[REDProp("correctSimulationNormals")]
public bool CorrectSimulationNormals { get; set;}

[REDProp("slowStart")]
public bool SlowStart { get; set;}

[REDProp("useStiffSolver")]
public bool UseStiffSolver { get; set;}

[REDProp("pressure")]
public float Pressure { get; set;}

/*[REDProp("lodWeights.maxDistance")]
public float LodWeights.maxDistance { get; set;}

[REDProp("lodWeights.distanceWeight")]
public float LodWeights.distanceWeight { get; set;}

[REDProp("lodWeights.bias")]
public float LodWeights.bias { get; set;}

[REDProp("lodWeights.benefitsBias")]
public float LodWeights.benefitsBias { get; set;}*/

[REDProp("maxDistanceBlendTime")]
public float MaxDistanceBlendTime { get; set;}

[REDProp("uvChannelForTangentUpdate")]
public uint UvChannelForTangentUpdate { get; set;}

/*[REDProp("maxDistanceScale.Multipliable")]
public bool MaxDistanceScale.Multipliable { get; set;}

[REDProp("maxDistanceScale.Scale")]
public float MaxDistanceScale.Scale { get; set;}*/

[REDProp("collisionResponseCoefficient")]
public float CollisionResponseCoefficient { get; set;}

[REDProp("allowAdaptiveTargetFrequency")]
public bool AllowAdaptiveTargetFrequency { get; set;}

[REDProp("windScaler")]
public float WindScaler { get; set;}

[REDProp("triggeringCollisionGroupNames")]
public Array<CName> TriggeringCollisionGroupNames { get; set;}

[REDProp("triggerType")]
public ETriggerShape TriggerType { get; set;}

[REDProp("triggerDimensions")]
public Vector TriggerDimensions { get; set;}

/*[REDProp("triggerLocalOffset.V[ 3 ]")]
public Vector TriggerLocalOffset.V[ 3 ] { get; set;}*/

[REDProp("shadowDistanceOverride")]
public float ShadowDistanceOverride { get; set;}

#endregion
}
}