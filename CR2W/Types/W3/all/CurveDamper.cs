using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CurveDamper : CObject
{
#region RED Properties

[REDProp("curve")]
public Handle<CCurve> Curve { get; set;}

[REDProp("time")]
public float Time { get; set;}

[REDProp("duration")]
public float Duration { get; set;}

[REDProp("startValue")]
public float StartValue { get; set;}

[REDProp("currValue")]
public float CurrValue { get; set;}

[REDProp("destValue")]
public float DestValue { get; set;}

#endregion
}
}