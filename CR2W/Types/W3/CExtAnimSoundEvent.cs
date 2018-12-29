using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CExtAnimSoundEvent : CExtAnimEvent
{
#region RED Properties

[REDProp("eventName")]
public CName EventName { get; set;}

[REDProp("startTime")]
public float StartTime { get; set;}

[REDProp("reportToScript")]
public bool ReportToScript { get; set;}

[REDProp("reportToScriptMinWeight")]
public float ReportToScriptMinWeight { get; set;}

[REDProp("animationName")]
public CName AnimationName { get; set;}

[REDProp("soundEventName")]
public StringAnsi SoundEventName { get; set;}

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("bone")]
public CName Bone { get; set;}

[REDProp("switchesToUpdate")]
public Array<StringAnsi> SwitchesToUpdate { get; set;}

[REDProp("parametersToUpdate")]
public Array<StringAnsi> ParametersToUpdate { get; set;}

[REDProp("filter")]
public bool Filter { get; set;}

[REDProp("filterCooldown")]
public float FilterCooldown { get; set;}

[REDProp("useDistanceParameter")]
public bool UseDistanceParameter { get; set;}

[REDProp("speed")]
public float Speed { get; set;}

[REDProp("decelDist")]
public float DecelDist { get; set;}

#endregion
}
}