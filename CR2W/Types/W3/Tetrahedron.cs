using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class Tetrahedron 
{
#region RED Properties

[REDProp("point1")]
public Vector Point1 { get; set;}

[REDProp("point2")]
public Vector Point2 { get; set;}

[REDProp("point3")]
public Vector Point3 { get; set;}

[REDProp("point4")]
public Vector Point4 { get; set;}

#endregion
}
}