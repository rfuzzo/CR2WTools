using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskPursueTarget : IBehTreeTask
{
#region RED Properties

[REDProp("moveType")]
public EMoveType MoveType { get; set;}

[REDProp("minDistance")]
public float MinDistance { get; set;}

[REDProp("keepDistance")]
public bool KeepDistance { get; set;}

[REDProp("isMoving")]
public bool IsMoving { get; set;}

#endregion
}
}