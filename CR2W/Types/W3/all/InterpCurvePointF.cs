using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class InterpCurvePointF : InterpCurvePoint
{
#region RED Properties

[REDProp("outVal")]
public float OutVal { get; set;}

[REDProp("arriveTangent")]
public float ArriveTangent { get; set;}

[REDProp("leaveTangent")]
public float LeaveTangent { get; set;}

#endregion
}
}