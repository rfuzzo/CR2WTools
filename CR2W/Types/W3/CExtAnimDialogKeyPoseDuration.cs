using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CExtAnimDialogKeyPoseDuration : CExtAnimDurationEvent
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

[REDProp("duration")]
public float Duration { get; set;}

[REDProp("alwaysFiresEnd")]
public bool AlwaysFiresEnd { get; set;}

[REDProp("transition")]
public bool Transition { get; set;}

[REDProp("keyPose")]
public bool KeyPose { get; set;}

#endregion
}
}