using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskIdle : IBehTreeTask
{
#region RED Properties

[REDProp("toleranceAngle")]
public float ToleranceAngle { get; set;}

[REDProp("checkRotation")]
public bool CheckRotation { get; set;}

[REDProp("isMoving")]
public bool IsMoving { get; set;}

#endregion
}
}