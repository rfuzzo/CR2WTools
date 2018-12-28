using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SFurColor 
{
#region RED Properties

[REDProp("rootAlphaFalloff")]
public float RootAlphaFalloff { get; set;}

[REDProp("rootColor")]
public Color RootColor { get; set;}

[REDProp("rootColorTex")]
public Handle<CBitmapTexture> RootColorTex { get; set;}

[REDProp("tipColor")]
public Color TipColor { get; set;}

[REDProp("tipColorTex")]
public Handle<CBitmapTexture> TipColorTex { get; set;}

[REDProp("rootTipColorWeight")]
public float RootTipColorWeight { get; set;}

[REDProp("rootTipColorFalloff")]
public float RootTipColorFalloff { get; set;}

[REDProp("strandTex")]
public Handle<CBitmapTexture> StrandTex { get; set;}

[REDProp("strandBlendMode")]
public EHairStrandBlendModeType StrandBlendMode { get; set;}

[REDProp("strandBlendScale")]
public float StrandBlendScale { get; set;}

[REDProp("textureBrightness")]
public float TextureBrightness { get; set;}

[REDProp("ambientEnvScale")]
public float AmbientEnvScale { get; set;}

#endregion
}
}