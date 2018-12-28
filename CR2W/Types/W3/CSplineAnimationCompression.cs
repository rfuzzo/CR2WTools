using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSplineAnimationCompression : IAnimationCompression
{
#region RED Properties

[REDProp("positionTolerance")]
public float PositionTolerance { get; set;}

[REDProp("positionPolynomialDegree")]
public UInt16 PositionPolynomialDegree { get; set;}

[REDProp("rotationTolerance")]
public float RotationTolerance { get; set;}

[REDProp("rotationPolynomialDegree")]
public UInt16 RotationPolynomialDegree { get; set;}

[REDProp("scaleTolerance")]
public float ScaleTolerance { get; set;}

[REDProp("scalePolynomialDegree")]
public UInt16 ScalePolynomialDegree { get; set;}

[REDProp("floatTolerance")]
public float FloatTolerance { get; set;}

[REDProp("floatPolynomialDegree")]
public UInt16 FloatPolynomialDegree { get; set;}

#endregion
}
}