using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExtAnimCutsceneLightEvent : CExtAnimEvent
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

[REDProp("tag")]
public TagList Tag { get; set;}

[REDProp("isEnabled")]
public bool IsEnabled { get; set;}

[REDProp("radius")]
public float Radius { get; set;}

[REDProp("brightness")]
public float Brightness { get; set;}

[REDProp("color")]
public Color Color { get; set;}

[REDProp("lightFlickering")]
public SLightFlickering LightFlickering { get; set;}

#endregion
}
}