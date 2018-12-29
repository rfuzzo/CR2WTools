using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CDestructionSystemComponent : CDrawableComponent
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

[REDProp("m_resource")]
public Handle<CApexResource> M_resource { get; set;}

[REDProp("targetEntityCollisionScriptName")]
public CName TargetEntityCollisionScriptName { get; set;}

[REDProp("parentEntityCollisionScriptEventName")]
public CName ParentEntityCollisionScriptEventName { get; set;}

/*[REDProp("parameters.m_materials")]
public Array<Handle<CMaterialGraph>> Parameters.m_materials { get; set;}*/

[REDProp("m_physicalCollisionType")]
public CPhysicalCollision M_physicalCollisionType { get; set;}

[REDProp("m_fracturedPhysicalCollisionType")]
public CPhysicalCollision M_fracturedPhysicalCollisionType { get; set;}

/*[REDProp("dispacher selection")]
public EDispatcherSelection Dispacher selection { get; set;}*/

[REDProp("dynamic")]
public bool Dynamic { get; set;}

[REDProp("supportDepth")]
public uint SupportDepth { get; set;}

[REDProp("useAssetDefinedSupport")]
public bool UseAssetDefinedSupport { get; set;}

[REDProp("debrisDepth")]
public int DebrisDepth { get; set;}

[REDProp("essentialDepth")]
public uint EssentialDepth { get; set;}

[REDProp("debrisTimeout")]
public bool DebrisTimeout { get; set;}

[REDProp("debrisLifetimeMin")]
public float DebrisLifetimeMin { get; set;}

[REDProp("debrisLifetimeMax")]
public float DebrisLifetimeMax { get; set;}

[REDProp("debrisMaxSeparation")]
public bool DebrisMaxSeparation { get; set;}

[REDProp("debrisMaxSeparationMin")]
public float DebrisMaxSeparationMin { get; set;}

[REDProp("debrisMaxSeparationMax")]
public float DebrisMaxSeparationMax { get; set;}

[REDProp("fadeOutTime")]
public float FadeOutTime { get; set;}

[REDProp("minimumFractureDepth")]
public uint MinimumFractureDepth { get; set;}

[REDProp("preset")]
public EDestructionPreset Preset { get; set;}

[REDProp("debrisDestructionProbability")]
public float DebrisDestructionProbability { get; set;}

[REDProp("crumbleSmallestChunks")]
public bool CrumbleSmallestChunks { get; set;}

[REDProp("accumulateDamage")]
public bool AccumulateDamage { get; set;}

[REDProp("damageCap")]
public float DamageCap { get; set;}

[REDProp("damageThreshold")]
public float DamageThreshold { get; set;}

[REDProp("damageToRadius")]
public float DamageToRadius { get; set;}

[REDProp("forceToDamage")]
public float ForceToDamage { get; set;}

[REDProp("fractureImpulseScale")]
public float FractureImpulseScale { get; set;}

[REDProp("impactDamageDefaultDepth")]
public int ImpactDamageDefaultDepth { get; set;}

[REDProp("impactVelocityThreshold")]
public float ImpactVelocityThreshold { get; set;}

[REDProp("materialStrength")]
public float MaterialStrength { get; set;}

[REDProp("maxChunkSpeed")]
public float MaxChunkSpeed { get; set;}

[REDProp("useWorldSupport")]
public bool UseWorldSupport { get; set;}

[REDProp("useHardSleeping")]
public bool UseHardSleeping { get; set;}

[REDProp("useStressSolver")]
public bool UseStressSolver { get; set;}

[REDProp("stressSolverTimeDelay")]
public float StressSolverTimeDelay { get; set;}

[REDProp("stressSolverMassThreshold")]
public float StressSolverMassThreshold { get; set;}

[REDProp("sleepVelocityFrameDecayConstant")]
public float SleepVelocityFrameDecayConstant { get; set;}

[REDProp("eventOnDestruction")]
public Array<Ptr<IPerformableAction>> EventOnDestruction { get; set;}

[REDProp("pathLibCollisionType")]
public EPathLibCollision PathLibCollisionType { get; set;}

[REDProp("disableObstacleOnDestruction")]
public bool DisableObstacleOnDestruction { get; set;}

[REDProp("shadowDistanceOverride")]
public float ShadowDistanceOverride { get; set;}

#endregion
}
}