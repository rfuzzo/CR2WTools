using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SStorySceneCameraLightMod 
{
#region RED Properties

[REDProp("deactivateLight")]
public bool DeactivateLight { get; set;}

[REDProp("useCustomLight")]
public bool UseCustomLight { get; set;}

[REDProp("overrideColor")]
public SSimpleCurve OverrideColor { get; set;}

[REDProp("lightOffset")]
public Vector LightOffset { get; set;}

[REDProp("brightnessScale")]
public float BrightnessScale { get; set;}

[REDProp("radiusScale")]
public float RadiusScale { get; set;}

[REDProp("useCustomAttenuation")]
public bool UseCustomAttenuation { get; set;}

[REDProp("attenuation")]
public float Attenuation { get; set;}

[REDProp("usageMask")]
public ECameraLightBitfield UsageMask { get; set;}

#endregion
}
}