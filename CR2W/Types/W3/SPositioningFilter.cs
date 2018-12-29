using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SPositioningFilter 
{
#region RED Properties

[REDProp("minDistance")]
public float MinDistance { get; set;}

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("zDiff")]
public float ZDiff { get; set;}

[REDProp("angleLimit")]
public float AngleLimit { get; set;}

[REDProp("personalSpace")]
public float PersonalSpace { get; set;}

[REDProp("awayFromCamera")]
public bool AwayFromCamera { get; set;}

[REDProp("onlyReachable")]
public bool OnlyReachable { get; set;}

[REDProp("noRoughTerrain")]
public bool NoRoughTerrain { get; set;}

[REDProp("noInteriors")]
public bool NoInteriors { get; set;}

[REDProp("limitToBaseArea")]
public bool LimitToBaseArea { get; set;}

#endregion
}
}