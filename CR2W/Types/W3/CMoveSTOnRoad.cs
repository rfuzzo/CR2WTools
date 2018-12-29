using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CMoveSTOnRoad : IMoveSteeringTask
{
#region RED Properties

[REDProp("headingImportance")]
public float HeadingImportance { get; set;}

[REDProp("speedImportance")]
public float SpeedImportance { get; set;}

[REDProp("anticipatedPositionDistance")]
public float AnticipatedPositionDistance { get; set;}

[REDProp("roadMaxDist")]
public float RoadMaxDist { get; set;}

#endregion
}
}