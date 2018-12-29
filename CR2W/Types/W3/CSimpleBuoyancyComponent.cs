using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CSimpleBuoyancyComponent : CComponent
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

[REDProp("waterOffset")]
public float WaterOffset { get; set;}

[REDProp("linearDamping")]
public float LinearDamping { get; set;}

[REDProp("pointFront")]
public Vector PointFront { get; set;}

[REDProp("pointBack")]
public Vector PointBack { get; set;}

[REDProp("pointLeft")]
public Vector PointLeft { get; set;}

[REDProp("pointRight")]
public Vector PointRight { get; set;}

#endregion
}
}