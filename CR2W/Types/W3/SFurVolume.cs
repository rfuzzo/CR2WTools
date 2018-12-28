using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SFurVolume 
{
#region RED Properties

[REDProp("density")]
public float Density { get; set;}

[REDProp("densityTex")]
public Handle<CBitmapTexture> DensityTex { get; set;}

[REDProp("densityTexChannel")]
public EHairTextureChannel DensityTexChannel { get; set;}

[REDProp("usePixelDensity")]
public bool UsePixelDensity { get; set;}

[REDProp("lengthNoise")]
public float LengthNoise { get; set;}

[REDProp("lengthScale")]
public float LengthScale { get; set;}

[REDProp("lengthTex")]
public Handle<CBitmapTexture> LengthTex { get; set;}

[REDProp("lengthTexChannel")]
public EHairTextureChannel LengthTexChannel { get; set;}

#endregion
}
}