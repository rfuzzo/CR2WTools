using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3PostFXOnGroundComponent : CSelfUpdatingComponent
{
#region RED Properties

[REDProp("fadeInTime")]
public float FadeInTime { get; set;}

[REDProp("activeTime")]
public float ActiveTime { get; set;}

[REDProp("fadeOutTime")]
public float FadeOutTime { get; set;}

[REDProp("range")]
public float Range { get; set;}

[REDProp("type")]
public Int32 Type { get; set;}

[REDProp("updateDelay")]
public float UpdateDelay { get; set;}

[REDProp("stopAtDeath")]
public bool StopAtDeath { get; set;}

[REDProp("m_Actor")]
public Handle<CActor> M_Actor { get; set;}

[REDProp("m_DelaySinceLastUpdate")]
public float M_DelaySinceLastUpdate { get; set;}

[REDProp("m_DefaultFadeInTime")]
public float M_DefaultFadeInTime { get; set;}

[REDProp("m_DefaultActiveTime")]
public float M_DefaultActiveTime { get; set;}

[REDProp("m_DefaultFadeOutTime")]
public float M_DefaultFadeOutTime { get; set;}

[REDProp("m_DefaultRange")]
public float M_DefaultRange { get; set;}

#endregion
}
}