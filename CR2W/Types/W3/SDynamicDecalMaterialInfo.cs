using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SDynamicDecalMaterialInfo 
{
#region RED Properties

[REDProp("diffuseTexture")]
public Handle<CBitmapTexture> DiffuseTexture { get; set;}

[REDProp("diffuseRandomColor0")]
public Color DiffuseRandomColor0 { get; set;}

[REDProp("diffuseRandomColor1")]
public Color DiffuseRandomColor1 { get; set;}

[REDProp("subUVType")]
public ERenderDynamicDecalAtlas SubUVType { get; set;}

[REDProp("normalTexture")]
public Handle<CBitmapTexture> NormalTexture { get; set;}

[REDProp("additiveNormals")]
public bool AdditiveNormals { get; set;}

[REDProp("specularColor")]
public Color SpecularColor { get; set;}

[REDProp("specularScale")]
public float SpecularScale { get; set;}

[REDProp("specularBase")]
public float SpecularBase { get; set;}

[REDProp("specularity")]
public float Specularity { get; set;}

#endregion
}
}