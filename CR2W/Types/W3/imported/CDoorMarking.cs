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
public class CDoorMarking : CScriptedComponent
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

[REDProp("changeCamera")]
public bool ChangeCamera { get; set;}

[REDProp("calculated")]
public bool Calculated { get; set;}

[REDProp("pointA")]
public Vector PointA { get; set;}

[REDProp("pointB")]
public Vector PointB { get; set;}

[REDProp("middlePoint")]
public Vector MiddlePoint { get; set;}

[REDProp("normal")]
public Vector Normal { get; set;}

[REDProp("checkState")]
public EDoorMarkingState CheckState { get; set;}

[REDProp("initialized")]
public bool Initialized { get; set;}

#endregion
}
}