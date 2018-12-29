using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class EmitterDurationSettings 
{
#region RED Properties

[REDProp("emitterDuration")]
public float EmitterDuration { get; set;}

[REDProp("emitterDurationLow")]
public float EmitterDurationLow { get; set;}

[REDProp("useEmitterDurationRange")]
public bool UseEmitterDurationRange { get; set;}

#endregion
}
}