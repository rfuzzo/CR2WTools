using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SGuiSceneDescription 
{
#region RED Properties

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("worldClass")]
public CName WorldClass { get; set;}

[REDProp("defaultEnvDef")]
public Soft<CEnvironmentDefinition> DefaultEnvDef { get; set;}

[REDProp("defaultSunRotation")]
public EulerAngles DefaultSunRotation { get; set;}

[REDProp("enablePhysics")]
public bool EnablePhysics { get; set;}

#endregion
}
}