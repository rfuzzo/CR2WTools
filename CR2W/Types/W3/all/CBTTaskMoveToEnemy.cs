using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskMoveToEnemy : IBehTreeTask
{
#region RED Properties

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("moveType")]
public EMoveType MoveType { get; set;}

[REDProp("absSpeed")]
public float AbsSpeed { get; set;}

[REDProp("isMoving")]
public bool IsMoving { get; set;}

#endregion
}
}