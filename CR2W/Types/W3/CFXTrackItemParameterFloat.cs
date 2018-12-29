using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CFXTrackItemParameterFloat : CFXTrackItemCurveBase
{
#region RED Properties

[REDProp("timeBegin")]
public float TimeBegin { get; set;}

[REDProp("timeDuration")]
public float TimeDuration { get; set;}

[REDProp("parameterName")]
public CName ParameterName { get; set;}

[REDProp("restoreAtEnd")]
public bool RestoreAtEnd { get; set;}

[REDProp("allComponents")]
public bool AllComponents { get; set;}

#endregion
}
}