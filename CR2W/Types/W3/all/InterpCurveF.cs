using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class InterpCurveF : InterpCurve
{
#region RED Properties

[REDProp("points")]
public Array<Handle<InterpCurvePointF>> Points { get; set;}

#endregion
}
}