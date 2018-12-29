using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CFXTrackItemEnvironmentModifier : CFXTrackItem
{
#region RED Properties

[REDProp("timeBegin")]
public float TimeBegin { get; set;}

[REDProp("timeDuration")]
public float TimeDuration { get; set;}

[REDProp("lightDirection")]
public Vector LightDirection { get; set;}

[REDProp("sunLightDiffuse")]
public Color SunLightDiffuse { get; set;}

[REDProp("sunLightBrightness")]
public float SunLightBrightness { get; set;}

[REDProp("ambientOverride")]
public Color AmbientOverride { get; set;}

[REDProp("ambientOverrideBrightness")]
public float AmbientOverrideBrightness { get; set;}

[REDProp("overrideBalancing")]
public bool OverrideBalancing { get; set;}

[REDProp("parametricBalanceLow")]
public Color ParametricBalanceLow { get; set;}

[REDProp("parametricBalanceLowScale")]
public float ParametricBalanceLowScale { get; set;}

[REDProp("parametricBalanceMid")]
public Color ParametricBalanceMid { get; set;}

[REDProp("parametricBalanceMidScale")]
public float ParametricBalanceMidScale { get; set;}

[REDProp("parametricBalanceHigh")]
public Color ParametricBalanceHigh { get; set;}

[REDProp("parametricBalanceHighScale")]
public float ParametricBalanceHighScale { get; set;}

#endregion
}
}