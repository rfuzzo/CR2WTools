using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4TestMenu : CR4MenuBase
{
#region RED Properties

[REDProp("entityTemplateIndex")]
public Int32 EntityTemplateIndex { get; set;}

[REDProp("appearanceIndex")]
public Int32 AppearanceIndex { get; set;}

[REDProp("environmentDefinitionIndex")]
public Int32 EnvironmentDefinitionIndex { get; set;}

[REDProp("entityTemplates")]
public Array<string> EntityTemplates { get; set;}

[REDProp("appearances")]
public Array<CName> Appearances { get; set;}

[REDProp("environmentDefinitions")]
public Array<string> EnvironmentDefinitions { get; set;}

[REDProp("sunRotation")]
public EulerAngles SunRotation { get; set;}

#endregion
}
}