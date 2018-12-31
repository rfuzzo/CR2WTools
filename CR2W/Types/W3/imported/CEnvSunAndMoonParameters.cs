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
public class CEnvSunAndMoonParameters 
{
#region RED Properties

[REDProp("activated")]
public bool Activated { get; set;}

[REDProp("sunSize")]
public SSimpleCurve SunSize { get; set;}

[REDProp("sunColor")]
public SSimpleCurve SunColor { get; set;}

[REDProp("sunFlareSize")]
public SSimpleCurve SunFlareSize { get; set;}

[REDProp("sunFlareColor")]
public CEnvFlareColorParameters SunFlareColor { get; set;}

[REDProp("moonSize")]
public SSimpleCurve MoonSize { get; set;}

[REDProp("moonColor")]
public SSimpleCurve MoonColor { get; set;}

[REDProp("moonFlareSize")]
public SSimpleCurve MoonFlareSize { get; set;}

[REDProp("moonFlareColor")]
public CEnvFlareColorParameters MoonFlareColor { get; set;}

#endregion
}
}