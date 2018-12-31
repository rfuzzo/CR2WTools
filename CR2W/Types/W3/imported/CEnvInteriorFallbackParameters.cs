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
public class CEnvInteriorFallbackParameters 
{
#region RED Properties

[REDProp("activated")]
public bool Activated { get; set;}

[REDProp("colorAmbientMul")]
public SSimpleCurve ColorAmbientMul { get; set;}

[REDProp("colorReflectionLow")]
public SSimpleCurve ColorReflectionLow { get; set;}

[REDProp("colorReflectionMiddle")]
public SSimpleCurve ColorReflectionMiddle { get; set;}

[REDProp("colorReflectionHigh")]
public SSimpleCurve ColorReflectionHigh { get; set;}

#endregion
}
}