using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CParticleEmitter : IParticleModule
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

        [REDProp("modules", 2,0)]
        public Array<Ptr<IParticleModule>> Modules { get; set;}

        [REDProp("positionX")]
        public Int32 PositionX { get; set;}

        [REDProp("positionY")]
        public Int32 PositionY { get; set;}

        [REDProp("material")]
        public Handle<IMaterial> Material { get; set;}

        [REDProp("maxParticles")]
        public UInt32 MaxParticles { get; set;}

        [REDProp("emitterLoops")]
        public Int32 EmitterLoops { get; set;}

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
        public UInt32 ModifierSetMask { get; set;}

        [REDProp("numModifiers")]
        public UInt32 NumModifiers { get; set;}

        [REDProp("initializerSetMask")]
        public UInt32 InitializerSetMask { get; set;}

        [REDProp("numInitializers")]
        public UInt32 NumInitializers { get; set;}

        [REDProp("seeds", 2,0)]
        public Array<SSeedKeyValue> Seeds { get; set;}

        [REDProp("internalPriority")]
        public byte InternalPriority { get; set;}

        [REDProp("lods", 2,0)]
        public Array<SParticleEmitterLODLevel> Lods { get; set;}

        #endregion


        //UNKNOWN BYTES


        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseBytes(br, size);


        }
    }
}