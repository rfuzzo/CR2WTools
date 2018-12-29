using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorMimiLipsyncCorrectionConstraint : IBehaviorMimicConstraint
{
#region RED Properties

[REDProp("controlTrack")]
public int ControlTrack { get; set;}

[REDProp("trackBegin")]
public int TrackBegin { get; set;}

[REDProp("trackEnd")]
public int TrackEnd { get; set;}

#endregion
}
}