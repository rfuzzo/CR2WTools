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
public class CSoundEmitterComponent : CComponent
{
#region RED Properties

[REDProp("tags")]
public TagList Tags { get; set;}

[REDProp("transform")]
public EngineTransform Transform { get; set;}

[REDProp("transformParent")]
public Ptr<CHardAttachment> TransformParent { get; set;}

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("isStreamed")]
public bool IsStreamed { get; set;}

[REDProp("loopStart")]
public StringAnsi LoopStart { get; set;}

[REDProp("loopStop")]
public StringAnsi LoopStop { get; set;}

[REDProp("intensityParameter")]
public StringAnsi IntensityParameter { get; set;}

[REDProp("eventsOnAttach", 2,0)]
public Array<StringAnsi> EventsOnAttach { get; set;}

[REDProp("eventsOnDetach", 2,0)]
public Array<StringAnsi> EventsOnDetach { get; set;}

[REDProp("banksDependency", 2,0)]
public Array<CName> BanksDependency { get; set;}

[REDProp("switchesOnAttach", 2,0)]
public Array<SSoundSwitch> SwitchesOnAttach { get; set;}

[REDProp("rtpcsOnAttach", 2,0)]
public Array<SSoundProperty> RtpcsOnAttach { get; set;}

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("occlusionEnabled")]
public bool OcclusionEnabled { get; set;}

[REDProp("isInGameMusic")]
public bool IsInGameMusic { get; set;}

[REDProp("listenerOverride")]
public string ListenerOverride { get; set;}

[REDProp("updateAzimuth")]
public bool UpdateAzimuth { get; set;}

#endregion
}
}