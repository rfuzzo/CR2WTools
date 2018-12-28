using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CExtAnimCutsceneEffectEvent : CExtAnimDurationEvent
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

[REDProp("effect")]
public CName Effect { get; set;}

[REDProp("tag")]
public TagList Tag { get; set;}

[REDProp("template")]
public Soft<CEntityTemplate> Template { get; set;}

[REDProp("spawnPosMS")]
public Vector SpawnPosMS { get; set;}

[REDProp("spawnRotMS")]
public EulerAngles SpawnRotMS { get; set;}

#endregion
}
}