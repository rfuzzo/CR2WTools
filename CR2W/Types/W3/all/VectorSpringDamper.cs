using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class VectorSpringDamper : CObject
{
#region RED Properties

[REDProp("destValue")]
public Vector DestValue { get; set;}

[REDProp("currValue")]
public Vector CurrValue { get; set;}

[REDProp("velValue")]
public Vector VelValue { get; set;}

[REDProp("smoothTime")]
public float SmoothTime { get; set;}

#endregion
}
}