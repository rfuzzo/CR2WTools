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
public class CFXTrackItemForceFeedback : CFXTrackItem
{
#region RED Properties

[REDProp("timeBegin")]
public float TimeBegin { get; set;}

[REDProp("timeDuration")]
public float TimeDuration { get; set;}

[REDProp("highFrequencyMotorSpeed")]
public float HighFrequencyMotorSpeed { get; set;}

[REDProp("lowFrequencyMotorSpeed")]
public float LowFrequencyMotorSpeed { get; set;}

#endregion
}
}