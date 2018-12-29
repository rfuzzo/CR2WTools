using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SFlareParameters 
{
#region RED Properties

[REDProp("category")]
public EFlareCategory Category { get; set;}

[REDProp("colorGroup")]
public EEnvFlareColorGroup ColorGroup { get; set;}

[REDProp("lensFlareGroup")]
public ELensFlareGroup LensFlareGroup { get; set;}

[REDProp("occlusionExtent")]
public float OcclusionExtent { get; set;}

[REDProp("flareRadius")]
public float FlareRadius { get; set;}

[REDProp("fadeInMaxSpeed")]
public float FadeInMaxSpeed { get; set;}

[REDProp("fadeOutMaxSpeed")]
public float FadeOutMaxSpeed { get; set;}

[REDProp("fadeInAccel")]
public float FadeInAccel { get; set;}

[REDProp("fadeOutAccel")]
public float FadeOutAccel { get; set;}

[REDProp("visibilityFullDist")]
public float VisibilityFullDist { get; set;}

[REDProp("visibilityFadeRange")]
public float VisibilityFadeRange { get; set;}

#endregion
}
}