using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CWaveletAnimationCompression : IAnimationCompression
{
#region RED Properties

[REDProp("quantizationBits")]
public byte QuantizationBits { get; set;}

[REDProp("positionTolerance")]
public float PositionTolerance { get; set;}

[REDProp("rotationTolerance")]
public float RotationTolerance { get; set;}

[REDProp("scaleTolerance")]
public float ScaleTolerance { get; set;}

#endregion
}
}