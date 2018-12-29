using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CDoorMarking : CScriptedComponent
{
#region RED Properties

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