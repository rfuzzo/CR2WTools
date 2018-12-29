using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskFlightStyle : IBehTreeTask
{
#region RED Properties

[REDProp("GlideChance")]
public float GlideChance { get; set;}

[REDProp("BackToRegularChance")]
public float BackToRegularChance { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("onMain")]
public bool OnMain { get; set;}

[REDProp("glideCheck")]
public bool GlideCheck { get; set;}

[REDProp("backToRegularCheck")]
public bool BackToRegularCheck { get; set;}

[REDProp("altitudeCheck")]
public bool AltitudeCheck { get; set;}

[REDProp("altitude")]
public float Altitude { get; set;}

[REDProp("frequency")]
public float Frequency { get; set;}

[REDProp("lastChange")]
public float LastChange { get; set;}

[REDProp("actorPosition")]
public Vector ActorPosition { get; set;}

#endregion
}
}