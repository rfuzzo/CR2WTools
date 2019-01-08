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
public class CFXTrackItemRadialBlur : CFXTrackItemCurveBase
{
#region RED Properties

[REDProp("timeBegin")]
public float TimeBegin { get; set;}

[REDProp("timeDuration")]
public float TimeDuration { get; set;}

[REDProp("trackComponentPosition")]
public bool TrackComponentPosition { get; set;}

[REDProp("distanceFromCamera")]
public float DistanceFromCamera { get; set;}

[REDProp("centerMultiplier")]
public float CenterMultiplier { get; set;}

#endregion
}
}