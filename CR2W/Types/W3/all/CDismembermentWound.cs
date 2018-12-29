using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
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
}
}