using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SStorySceneLightTrackingInfo 
{
#region RED Properties

[REDProp("enable")]
public bool Enable { get; set;}

[REDProp("trackingType")]
public ELightTrackingType TrackingType { get; set;}

[REDProp("radius")]
public SSimpleCurve Radius { get; set;}

[REDProp("angleOffset")]
public SSimpleCurve AngleOffset { get; set;}

#endregion
}
}