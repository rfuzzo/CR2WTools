using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateSkateStopFast : CExplorationStateSkatingDrift
{
#region RED Properties

[REDProp("inputRangeToEnter")]
public float InputRangeToEnter { get; set;}

[REDProp("duration")]
public float Duration { get; set;}

[REDProp("speedStopCurve")]
public Handle<CCurve> SpeedStopCurve { get; set;}

#endregion
}
}