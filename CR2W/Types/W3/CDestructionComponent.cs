using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CDestructionComponent : CMeshTypeComponent
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

[REDProp("m_baseResource")]
public Handle<CPhysicsDestructionResource> M_baseResource { get; set;}

[REDProp("m_fracturedResource")]
public Handle<CPhysicsDestructionResource> M_fracturedResource { get; set;}

/*[REDProp("parameters.m_pose")]
public Matrix Parameters.m_pose { get; set;}*/

[REDProp("m_physicalCollisionType")]
public CPhysicalCollision M_physicalCollisionType { get; set;}

[REDProp("m_fracturedPhysicalCollisionType")]
public CPhysicalCollision M_fracturedPhysicalCollisionType { get; set;}

[REDProp("dynamic")]
public bool Dynamic { get; set;}

[REDProp("kinematic")]
public bool Kinematic { get; set;}

[REDProp("debrisTimeout")]
public bool DebrisTimeout { get; set;}

[REDProp("debrisTimeoutMin")]
public float DebrisTimeoutMin { get; set;}

[REDProp("debrisTimeoutMax")]
public float DebrisTimeoutMax { get; set;}

[REDProp("initialBaseVelocity")]
public Vector InitialBaseVelocity { get; set;}

[REDProp("hasInitialFractureVelocity")]
public bool HasInitialFractureVelocity { get; set;}

[REDProp("maxVelocity")]
public float MaxVelocity { get; set;}

[REDProp("maxAngularFractureVelocity")]
public float MaxAngularFractureVelocity { get; set;}

[REDProp("debrisMaxSeparationDistance")]
public float DebrisMaxSeparationDistance { get; set;}

[REDProp("simulationDistance")]
public float SimulationDistance { get; set;}

[REDProp("fadeOutTime")]
public float FadeOutTime { get; set;}

[REDProp("forceToDamage")]
public float ForceToDamage { get; set;}

[REDProp("damageThreshold")]
public float DamageThreshold { get; set;}

[REDProp("damageEndurance")]
public float DamageEndurance { get; set;}

[REDProp("accumulateDamage")]
public bool AccumulateDamage { get; set;}

[REDProp("useWorldSupport")]
public bool UseWorldSupport { get; set;}

[REDProp("fractureSoundEvent")]
public StringAnsi FractureSoundEvent { get; set;}

[REDProp("fxName")]
public CName FxName { get; set;}

[REDProp("eventOnDestruction")]
public Array<Ptr<IPerformableAction>> EventOnDestruction { get; set;}

[REDProp("pathLibCollisionType")]
public EPathLibCollision PathLibCollisionType { get; set;}

[REDProp("disableObstacleOnDestruction")]
public bool DisableObstacleOnDestruction { get; set;}

#endregion
}
}