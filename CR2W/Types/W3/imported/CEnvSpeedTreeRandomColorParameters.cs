using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CEnvSpeedTreeRandomColorParameters 
{
#region RED Properties

[REDProp("luminanceWeights")]
public SSimpleCurve LuminanceWeights { get; set;}

[REDProp("randomColor0")]
public SSimpleCurve RandomColor0 { get; set;}

[REDProp("saturation0")]
public SSimpleCurve Saturation0 { get; set;}

[REDProp("randomColor1")]
public SSimpleCurve RandomColor1 { get; set;}

[REDProp("saturation1")]
public SSimpleCurve Saturation1 { get; set;}

[REDProp("randomColor2")]
public SSimpleCurve RandomColor2 { get; set;}

[REDProp("saturation2")]
public SSimpleCurve Saturation2 { get; set;}

#endregion
}
}