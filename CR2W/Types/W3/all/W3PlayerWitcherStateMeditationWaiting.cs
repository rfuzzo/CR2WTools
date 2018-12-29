using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3PlayerWitcherStateMeditationWaiting : W3PlayerWitcherStateMeditationBase
{
#region RED Properties

[REDProp("TARGET_HOURS_PER_MINUTE")]
public float TARGET_HOURS_PER_MINUTE { get; set;}

[REDProp("BLEND_TIME_SECONDS_REAL")]
public float BLEND_TIME_SECONDS_REAL { get; set;}

[REDProp("storedHoursPerMinute")]
public float StoredHoursPerMinute { get; set;}

[REDProp("waitStartTime")]
public GameTime WaitStartTime { get; set;}

[REDProp("requestedTargetTime")]
public GameTime RequestedTargetTime { get; set;}

[REDProp("abortRequested")]
public bool AbortRequested { get; set;}

#endregion
}
}