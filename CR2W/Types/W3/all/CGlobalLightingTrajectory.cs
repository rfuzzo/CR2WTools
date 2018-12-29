using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CGlobalLightingTrajectory 
{
#region RED Properties

[REDProp("yawDegrees")]
public float YawDegrees { get; set;}

[REDProp("yawDegreesSunOffset")]
public float YawDegreesSunOffset { get; set;}

[REDProp("yawDegreesMoonOffset")]
public float YawDegreesMoonOffset { get; set;}

[REDProp("sunCurveShiftFactor")]
public float SunCurveShiftFactor { get; set;}

[REDProp("moonCurveShiftFactor")]
public float MoonCurveShiftFactor { get; set;}

[REDProp("sunSqueeze")]
public float SunSqueeze { get; set;}

[REDProp("moonSqueeze")]
public float MoonSqueeze { get; set;}

[REDProp("sunHeight")]
public SSimpleCurve SunHeight { get; set;}

[REDProp("moonHeight")]
public SSimpleCurve MoonHeight { get; set;}

[REDProp("lightHeight")]
public SSimpleCurve LightHeight { get; set;}

[REDProp("lightDirChoice")]
public SSimpleCurve LightDirChoice { get; set;}

[REDProp("skyDayAmount")]
public SSimpleCurve SkyDayAmount { get; set;}

[REDProp("moonShaftsBeginHour")]
public float MoonShaftsBeginHour { get; set;}

[REDProp("moonShaftsEndHour")]
public float MoonShaftsEndHour { get; set;}

#endregion
}
}