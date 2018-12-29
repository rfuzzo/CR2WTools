using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CTriggerActivatorComponent : CComponent
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

[REDProp("radius")]
public float Radius { get; set;}

[REDProp("height")]
public float Height { get; set;}

[REDProp("channels")]
public ETriggerChannel Channels { get; set;}

[REDProp("enableCCD")]
public bool EnableCCD { get; set;}

[REDProp("maxContinousDistance")]
public float MaxContinousDistance { get; set;}

#endregion
}
}