using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CEnvRadialBlurParameters 
{
#region RED Properties

[REDProp("radialBlurSource")]
public Vector RadialBlurSource { get; set;}

[REDProp("radialBlurAmount")]
public float RadialBlurAmount { get; set;}

[REDProp("sineWaveAmount")]
public float SineWaveAmount { get; set;}

[REDProp("sineWaveSpeed")]
public float SineWaveSpeed { get; set;}

[REDProp("sineWaveFreq")]
public float SineWaveFreq { get; set;}

[REDProp("centerMultiplier")]
public float CenterMultiplier { get; set;}

[REDProp("distance")]
public float Distance { get; set;}

#endregion
}
}