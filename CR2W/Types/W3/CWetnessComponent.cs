using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CWetnessComponent : CComponent
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

[REDProp("blendInFromOcean")]
public float BlendInFromOcean { get; set;}

[REDProp("blendInFromRain")]
public float BlendInFromRain { get; set;}

[REDProp("blendOutFromOcean")]
public float BlendOutFromOcean { get; set;}

[REDProp("blendOutFromRain")]
public float BlendOutFromRain { get; set;}

#endregion
}
}