using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class EmitterDelaySettings 
{
#region RED Properties

[REDProp("emitterDelay")]
public float EmitterDelay { get; set;}

[REDProp("emitterDelayLow")]
public float EmitterDelayLow { get; set;}

[REDProp("useEmitterDelayRange")]
public bool UseEmitterDelayRange { get; set;}

[REDProp("useEmitterDelayOnce")]
public bool UseEmitterDelayOnce { get; set;}

#endregion
}
}