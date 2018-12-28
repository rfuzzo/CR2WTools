using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CExtAnimProjectileEvent : CExtAnimEvent
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

[REDProp("spell")]
public Handle<CEntityTemplate> Spell { get; set;}

[REDProp("castPosition")]
public EProjectileCastPosition CastPosition { get; set;}

[REDProp("boneName")]
public CName BoneName { get; set;}

#endregion
}
}