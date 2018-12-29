using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CParticleEmitter : IParticleModule
{
#region RED Properties

[REDProp("editorName")]
public string EditorName { get; set;}

[REDProp("editorColor")]
public Color EditorColor { get; set;}

[REDProp("editorGroup")]
public string EditorGroup { get; set;}

[REDProp("isEnabled")]
public bool IsEnabled { get; set;}

[REDProp("isShowing")]
public bool IsShowing { get; set;}

[REDProp("isSelected")]
public bool IsSelected { get; set;}

[REDProp("modules")]
public Array<Ptr<IParticleModule>> Modules { get; set;}

[REDProp("positionX")]
public int PositionX { get; set;}

[REDProp("positionY")]
public int PositionY { get; set;}

[REDProp("material")]
public Handle<IMaterial> Material { get; set;}

[REDProp("maxParticles")]
public uint MaxParticles { get; set;}

[REDProp("emitterLoops")]
public int EmitterLoops { get; set;}

[REDProp("particleDrawer")]
public Ptr<IParticleDrawer> ParticleDrawer { get; set;}

[REDProp("decalSpawner")]
public Ptr<CDecalSpawner> DecalSpawner { get; set;}

[REDProp("collisionDecalSpawner")]
public Ptr<CDecalSpawner> CollisionDecalSpawner { get; set;}

[REDProp("motionDecalSpawner")]
public Ptr<CDecalSpawner> MotionDecalSpawner { get; set;}

[REDProp("useSubFrameEmission")]
public bool UseSubFrameEmission { get; set;}

[REDProp("keepSimulationLocal")]
public bool KeepSimulationLocal { get; set;}

[REDProp("envColorGroup")]
public EEnvColorGroup EnvColorGroup { get; set;}

[REDProp("windInfluence")]
public float WindInfluence { get; set;}

[REDProp("useOnlyWindInfluence")]
public bool UseOnlyWindInfluence { get; set;}

[REDProp("modifierSetMask")]
public uint ModifierSetMask { get; set;}

[REDProp("numModifiers")]
public uint NumModifiers { get; set;}

[REDProp("initializerSetMask")]
public uint InitializerSetMask { get; set;}

[REDProp("numInitializers")]
public uint NumInitializers { get; set;}

[REDProp("seeds")]
public Array<SSeedKeyValue> Seeds { get; set;}

[REDProp("internalPriority")]
public byte InternalPriority { get; set;}

[REDProp("lods")]
public Array<SParticleEmitterLODLevel> Lods { get; set;}

#endregion
}
}