using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SWorldSkyboxParameters 
{
#region RED Properties

[REDProp("sunMesh")]
public Handle<CMesh> SunMesh { get; set;}

[REDProp("sunMaterial")]
public Handle<CMaterialInstance> SunMaterial { get; set;}

[REDProp("moonMesh")]
public Handle<CMesh> MoonMesh { get; set;}

[REDProp("moonMaterial")]
public Handle<CMaterialInstance> MoonMaterial { get; set;}

[REDProp("skyboxMesh")]
public Handle<CMesh> SkyboxMesh { get; set;}

[REDProp("skyboxMaterial")]
public Handle<CMaterialInstance> SkyboxMaterial { get; set;}

[REDProp("cloudsMesh")]
public Handle<CMesh> CloudsMesh { get; set;}

[REDProp("cloudsMaterial")]
public Handle<CMaterialInstance> CloudsMaterial { get; set;}

#endregion
}
}