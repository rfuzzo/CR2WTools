using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SEnvProbeGenParams 
{
#region RED Properties

[REDProp("useInInterior")]
public bool UseInInterior { get; set;}

[REDProp("useInExterior")]
public bool UseInExterior { get; set;}

[REDProp("isInteriorFallback")]
public bool IsInteriorFallback { get; set;}

[REDProp("cullingDistance")]
public float CullingDistance { get; set;}

[REDProp("ambientColor")]
public Color AmbientColor { get; set;}

[REDProp("ambientIntensity")]
public float AmbientIntensity { get; set;}

[REDProp("dimmerFactor")]
public float DimmerFactor { get; set;}

[REDProp("fadeInDuration")]
public float FadeInDuration { get; set;}

[REDProp("fadeOutDuration")]
public float FadeOutDuration { get; set;}

[REDProp("lightScaleGlobal")]
public float LightScaleGlobal { get; set;}

[REDProp("lightScaleLocals")]
public float LightScaleLocals { get; set;}

[REDProp("fogAmount")]
public float FogAmount { get; set;}

[REDProp("daycycleAmbientIntensity")]
public SSimpleCurve DaycycleAmbientIntensity { get; set;}

[REDProp("daycycleLightScaleLocals")]
public SSimpleCurve DaycycleLightScaleLocals { get; set;}

[REDProp("daycycleEffectIntensity")]
public SSimpleCurve DaycycleEffectIntensity { get; set;}

#endregion
}
}