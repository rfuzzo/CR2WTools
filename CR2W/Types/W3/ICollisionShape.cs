using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class ICollisionShape : CObject
{
#region RED Properties

[REDProp("pose")]
public Matrix Pose { get; set;}

[REDProp("densityScaler")]
public float DensityScaler { get; set;}

#endregion
}
}