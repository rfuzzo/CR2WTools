using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CFormationKeepComradesSpeedSteeringTask : IFormationSteeringTask
{
#region RED Properties

[REDProp("speedImportance")]
public float SpeedImportance { get; set;}

[REDProp("distanceToComrades")]
public float DistanceToComrades { get; set;}

#endregion
}
}