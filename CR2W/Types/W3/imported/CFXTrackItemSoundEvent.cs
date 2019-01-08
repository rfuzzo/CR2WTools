using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFXTrackItemSoundEvent : CFXTrackItem
{
#region RED Properties

[REDProp("timeBegin")]
public float TimeBegin { get; set;}

[REDProp("timeDuration")]
public float TimeDuration { get; set;}

//[REDProp("soundEventName")]
//public StringAnsi SoundEventName { get; set;}

[REDProp("stopFadeTime")]
public float StopFadeTime { get; set;}

[REDProp("isAmbient")]
public bool IsAmbient { get; set;}

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("useDistanceParameter")]
public bool UseDistanceParameter { get; set;}

[REDProp("latchDistanceParameterBelow")]
public float LatchDistanceParameterBelow { get; set;}

[REDProp("invertLatchDistance")]
public bool InvertLatchDistance { get; set;}

//[REDProp("latchEvent")]
//public StringAnsi LatchEvent { get; set;}

[REDProp("boneName")]
public CName BoneName { get; set;}

[REDProp("speed")]
public float Speed { get; set;}

[REDProp("decelDist")]
public float DecelDist { get; set;}

#endregion
}
}