using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMoveSTKeepAwayWallsInPathfollow : IMoveSteeringTask
{
#region RED Properties

[REDProp("wallDetectionDistance")]
public float WallDetectionDistance { get; set;}

[REDProp("headingImportance")]
public float HeadingImportance { get; set;}

#endregion
}
}