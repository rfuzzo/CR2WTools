using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CEnvDepthOfFieldParameters 
{
#region RED Properties

[REDProp("activated")]
public bool Activated { get; set;}

[REDProp("nearBlurDist")]
public SSimpleCurve NearBlurDist { get; set;}

[REDProp("nearFocusDist")]
public SSimpleCurve NearFocusDist { get; set;}

[REDProp("farFocusDist")]
public SSimpleCurve FarFocusDist { get; set;}

[REDProp("farBlurDist")]
public SSimpleCurve FarBlurDist { get; set;}

[REDProp("intensity")]
public SSimpleCurve Intensity { get; set;}

[REDProp("activatedSkyThreshold")]
public bool ActivatedSkyThreshold { get; set;}

[REDProp("skyThreshold")]
public float SkyThreshold { get; set;}

[REDProp("activatedSkyRange")]
public bool ActivatedSkyRange { get; set;}

[REDProp("skyRange")]
public float SkyRange { get; set;}

#endregion
}
}