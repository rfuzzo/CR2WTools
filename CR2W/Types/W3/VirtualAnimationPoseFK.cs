using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class VirtualAnimationPoseFK 
{
#region RED Properties

[REDProp("time")]
public float Time { get; set;}

[REDProp("controlPoints")]
public Vector ControlPoints { get; set;}

[REDProp("indices")]
public Array<Int32> Indices { get; set;}

[REDProp("transforms")]
public Array<EngineQsTransform> Transforms { get; set;}

#endregion
}
}