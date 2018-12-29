using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SDismembermentWoundDecal 
{
#region RED Properties

[REDProp("materialInfo")]
public SDynamicDecalMaterialInfo MaterialInfo { get; set;}

[REDProp("scale")]
public Vector2 Scale { get; set;}

[REDProp("depthScale")]
public float DepthScale { get; set;}

[REDProp("offset")]
public Vector2 Offset { get; set;}

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

[REDProp("applyToFillMesh")]
public bool ApplyToFillMesh { get; set;}

#endregion
}
}