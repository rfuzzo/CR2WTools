using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CEnvToneMappingCurveParameters 
{
#region RED Properties

[REDProp("shoulderStrength")]
public SSimpleCurve ShoulderStrength { get; set;}

[REDProp("linearStrength")]
public SSimpleCurve LinearStrength { get; set;}

[REDProp("linearAngle")]
public SSimpleCurve LinearAngle { get; set;}

[REDProp("toeStrength")]
public SSimpleCurve ToeStrength { get; set;}

[REDProp("toeNumerator")]
public SSimpleCurve ToeNumerator { get; set;}

[REDProp("toeDenominator")]
public SSimpleCurve ToeDenominator { get; set;}

#endregion
}
}