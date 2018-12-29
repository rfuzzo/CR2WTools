using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SFurStrandWidth 
{
#region RED Properties

[REDProp("width")]
public float Width { get; set;}

[REDProp("widthRootScale")]
public float WidthRootScale { get; set;}

[REDProp("widthTipScale")]
public float WidthTipScale { get; set;}

[REDProp("rootWidthTex")]
public Handle<CBitmapTexture> RootWidthTex { get; set;}

[REDProp("rootWidthTexChannel")]
public EHairTextureChannel RootWidthTexChannel { get; set;}

[REDProp("tipWidthTex")]
public Handle<CBitmapTexture> TipWidthTex { get; set;}

[REDProp("tipWidthTexChannel")]
public EHairTextureChannel TipWidthTexChannel { get; set;}

[REDProp("widthNoise")]
public float WidthNoise { get; set;}

#endregion
}
}