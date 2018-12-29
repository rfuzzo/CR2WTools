using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class InterpCurvePointV : InterpCurvePoint
{
#region RED Properties

[REDProp("outVal")]
public Vector OutVal { get; set;}

[REDProp("arriveTangent")]
public Vector ArriveTangent { get; set;}

[REDProp("leaveTangent")]
public Vector LeaveTangent { get; set;}

#endregion
}
}