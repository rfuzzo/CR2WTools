using CR2W.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CDismembermentWound : ISerializable
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("disabledOnAppearances")]
public Array<CName> DisabledOnAppearances { get; set;}

[REDProp("transform")]
public EngineTransform Transform { get; set;}

[REDProp("excludeTag")]
public CName ExcludeTag { get; set;}

[REDProp("fillMesh")]
public Handle<CMesh> FillMesh { get; set;}

[REDProp("singleSpawnArray")]
public Array<SDismembermentWoundSingleSpawn> SingleSpawnArray { get; set;}

[REDProp("particles")]
public Soft<CParticleSystem> Particles { get; set;}

[REDProp("attachedParticles")]
public Soft<CParticleSystem> AttachedParticles { get; set;}

[REDProp("isExplosionWound")]
public bool IsExplosionWound { get; set;}

[REDProp("isFrostWound")]
public bool IsFrostWound { get; set;}

[REDProp("decal")]
public SDismembermentWoundDecal Decal { get; set;}

[REDProp("mainEntityCurveName")]
public CName MainEntityCurveName { get; set;}

        #endregion

        //FIXME abstract classes
        public override UInt16 Flags { get; set; }
        public override UInt32 Template { get; set; }

        public override event SerializeEventHandler Serialize;
        public override event DeSerializeEventHandler DeSerialize;

        public override void OnSerialize(IFile source, REDEventArgs e) { }
        public override void OnDeSerialize(IFile source, REDEventArgs e) { }
    }
}