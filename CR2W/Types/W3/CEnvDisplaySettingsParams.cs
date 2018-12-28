using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CEnvDisplaySettingsParams 
{
#region RED Properties

[REDProp("enableInstantAdaptation")]
public bool EnableInstantAdaptation { get; set;}

[REDProp("enableGlobalLightingTrajectory")]
public bool EnableGlobalLightingTrajectory { get; set;}

[REDProp("enableEnvProbeInstantUpdate")]
public bool EnableEnvProbeInstantUpdate { get; set;}

[REDProp("allowEnvProbeUpdate")]
public bool AllowEnvProbeUpdate { get; set;}

[REDProp("allowBloom")]
public bool AllowBloom { get; set;}

[REDProp("allowColorMod")]
public bool AllowColorMod { get; set;}

[REDProp("allowAntialiasing")]
public bool AllowAntialiasing { get; set;}

[REDProp("allowGlobalFog")]
public bool AllowGlobalFog { get; set;}

[REDProp("allowDOF")]
public bool AllowDOF { get; set;}

[REDProp("allowSSAO")]
public bool AllowSSAO { get; set;}

[REDProp("allowCloudsShadow")]
public bool AllowCloudsShadow { get; set;}

[REDProp("allowVignette")]
public bool AllowVignette { get; set;}

[REDProp("allowWaterShader")]
public bool AllowWaterShader { get; set;}

[REDProp("gamma")]
public float Gamma { get; set;}

#endregion
}
}