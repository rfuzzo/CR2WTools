using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SAnimationBufferBitwiseCompressionSettings 
{
#region RED Properties

[REDProp("translationTolerance")]
public float TranslationTolerance { get; set;}

[REDProp("translationSkipFrameTolerance")]
public float TranslationSkipFrameTolerance { get; set;}

[REDProp("orientationTolerance")]
public float OrientationTolerance { get; set;}

[REDProp("orientationCompressionMethod")]
public SAnimationBufferOrientationCompressionMethod OrientationCompressionMethod { get; set;}

[REDProp("orientationSkipFrameTolerance")]
public float OrientationSkipFrameTolerance { get; set;}

[REDProp("scaleTolerance")]
public float ScaleTolerance { get; set;}

[REDProp("scaleSkipFrameTolerance")]
public float ScaleSkipFrameTolerance { get; set;}

[REDProp("trackTolerance")]
public float TrackTolerance { get; set;}

[REDProp("trackSkipFrameTolerance")]
public float TrackSkipFrameTolerance { get; set;}

#endregion
}
}