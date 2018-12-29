using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskMoveToWaypoint : IBehTreeTask
{
#region RED Properties

[REDProp("waypoint")]
public CName Waypoint { get; set;}

[REDProp("moveType")]
public EMoveType MoveType { get; set;}

[REDProp("moveSpeed")]
public float MoveSpeed { get; set;}

[REDProp("isMoving")]
public bool IsMoving { get; set;}

[REDProp("gotTarget")]
public bool GotTarget { get; set;}

#endregion
}
}