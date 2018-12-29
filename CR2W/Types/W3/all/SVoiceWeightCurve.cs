using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SVoiceWeightCurve 
{
#region RED Properties

[REDProp("useCurve")]
public bool UseCurve { get; set;}

[REDProp("curve")]
public SCurveData Curve { get; set;}

[REDProp("timeOffset")]
public float TimeOffset { get; set;}

[REDProp("valueMulPre")]
public float ValueMulPre { get; set;}

[REDProp("valueOffset")]
public float ValueOffset { get; set;}

[REDProp("valueMulPost")]
public float ValueMulPost { get; set;}

#endregion
}
}