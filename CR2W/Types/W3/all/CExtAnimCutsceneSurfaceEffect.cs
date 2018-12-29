using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExtAnimCutsceneSurfaceEffect : CExtAnimCutsceneEvent
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

[REDProp("type")]
public ESceneEventSurfacePostFXType Type { get; set;}

[REDProp("worldPos")]
public bool WorldPos { get; set;}

[REDProp("position")]
public Vector Position { get; set;}

[REDProp("radius")]
public float Radius { get; set;}

[REDProp("fadeInTime")]
public float FadeInTime { get; set;}

[REDProp("fadeOutTime")]
public float FadeOutTime { get; set;}

[REDProp("durationTime")]
public float DurationTime { get; set;}

#endregion
}
}