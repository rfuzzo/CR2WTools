using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SFurClumping 
{
#region RED Properties

[REDProp("clumpScale")]
public float ClumpScale { get; set;}

[REDProp("clumpScaleTex")]
public Handle<CBitmapTexture> ClumpScaleTex { get; set;}

[REDProp("clumpScaleTexChannel")]
public EHairTextureChannel ClumpScaleTexChannel { get; set;}

[REDProp("clumpRoundness")]
public float ClumpRoundness { get; set;}

[REDProp("clumpRoundnessTex")]
public Handle<CBitmapTexture> ClumpRoundnessTex { get; set;}

[REDProp("clumpRoundnessTexChannel")]
public EHairTextureChannel ClumpRoundnessTexChannel { get; set;}

[REDProp("clumpNoise")]
public float ClumpNoise { get; set;}

[REDProp("clumpNoiseTex")]
public Handle<CBitmapTexture> ClumpNoiseTex { get; set;}

[REDProp("clumpNoiseTexChannel")]
public EHairTextureChannel ClumpNoiseTexChannel { get; set;}

[REDProp("clumpNumSubclumps")]
public uint ClumpNumSubclumps { get; set;}

#endregion
}
}