using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CExtAnimCutsceneEnvironmentEvent : CExtAnimEvent
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

[REDProp("stabilizeBlending")]
public bool StabilizeBlending { get; set;}

[REDProp("instantEyeAdaptation")]
public bool InstantEyeAdaptation { get; set;}

[REDProp("instantDissolve")]
public bool InstantDissolve { get; set;}

[REDProp("forceSetupLocalEnvironments")]
public bool ForceSetupLocalEnvironments { get; set;}

[REDProp("forceSetupGlobalEnvironments")]
public bool ForceSetupGlobalEnvironments { get; set;}

[REDProp("environmentName")]
public string EnvironmentName { get; set;}

[REDProp("environmentActivate")]
public bool EnvironmentActivate { get; set;}

[REDProp("forceNoOtherEnvironments")]
public bool ForceNoOtherEnvironments { get; set;}

#endregion
}
}