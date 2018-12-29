using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CMoveSTForwardCollisionResponse : CMoveSTCollisionResponse
{
#region RED Properties

[REDProp("headingImportanceMin")]
public float HeadingImportanceMin { get; set;}

[REDProp("headingImportanceMax")]
public float HeadingImportanceMax { get; set;}

[REDProp("radiusMult")]
public float RadiusMult { get; set;}

[REDProp("probeDistanceInTime")]
public float ProbeDistanceInTime { get; set;}

[REDProp("crowdThroughVar")]
public CName CrowdThroughVar { get; set;}

#endregion
}
}