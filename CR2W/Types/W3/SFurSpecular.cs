using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SFurSpecular 
{
#region RED Properties

[REDProp("specularColor")]
public Color SpecularColor { get; set;}

[REDProp("specularTex")]
public Handle<CBitmapTexture> SpecularTex { get; set;}

[REDProp("specularPrimary")]
public float SpecularPrimary { get; set;}

[REDProp("specularPowerPrimary")]
public float SpecularPowerPrimary { get; set;}

[REDProp("specularPrimaryBreakup")]
public float SpecularPrimaryBreakup { get; set;}

[REDProp("specularSecondary")]
public float SpecularSecondary { get; set;}

[REDProp("specularPowerSecondary")]
public float SpecularPowerSecondary { get; set;}

[REDProp("specularSecondaryOffset")]
public float SpecularSecondaryOffset { get; set;}

[REDProp("specularNoiseScale")]
public float SpecularNoiseScale { get; set;}

[REDProp("specularEnvScale")]
public float SpecularEnvScale { get; set;}

#endregion
}
}