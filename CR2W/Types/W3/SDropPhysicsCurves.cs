using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SDropPhysicsCurves 
{
#region RED Properties

[REDProp("trajectory")]
public SMultiCurve Trajectory { get; set;}

[REDProp("rotation")]
public SMultiCurve Rotation { get; set;}

#endregion
}
}