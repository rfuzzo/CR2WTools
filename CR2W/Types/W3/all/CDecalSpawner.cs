using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CDecalSpawner : CObject
{
#region RED Properties

[REDProp("material")]
public SDynamicDecalMaterialInfo Material { get; set;}

[REDProp("farZ")]
public float FarZ { get; set;}

[REDProp("nearZ")]
public float NearZ { get; set;}

[REDProp("size")]
public Ptr<IEvaluatorFloat> Size { get; set;}

[REDProp("depthFadePower")]
public float DepthFadePower { get; set;}

[REDProp("normalFadeBias")]
public float NormalFadeBias { get; set;}

[REDProp("normalFadeScale")]
public float NormalFadeScale { get; set;}

[REDProp("doubleSided")]
public bool DoubleSided { get; set;}

[REDProp("projectionMode")]
public ERenderDynamicDecalProjection ProjectionMode { get; set;}

[REDProp("decalLifetime")]
public Ptr<IEvaluatorFloat> DecalLifetime { get; set;}

[REDProp("decalFadeTime")]
public float DecalFadeTime { get; set;}

[REDProp("decalFadeInTime")]
public float DecalFadeInTime { get; set;}

[REDProp("projectOnlyOnStatic")]
public bool ProjectOnlyOnStatic { get; set;}

[REDProp("startScale")]
public float StartScale { get; set;}

[REDProp("scaleTime")]
public float ScaleTime { get; set;}

[REDProp("useVerticalProjection")]
public bool UseVerticalProjection { get; set;}

[REDProp("spawnPriority")]
public EDynamicDecalSpawnPriority SpawnPriority { get; set;}

[REDProp("autoHideDistance")]
public float AutoHideDistance { get; set;}

[REDProp("chance")]
public float Chance { get; set;}

[REDProp("spawnFrequency")]
public float SpawnFrequency { get; set;}

#endregion
}
}