using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CEnvCameraLightParameters 
{
#region RED Properties

[REDProp("activated")]
public bool Activated { get; set;}

[REDProp("color")]
public SSimpleCurve Color { get; set;}

[REDProp("attenuation")]
public SSimpleCurve Attenuation { get; set;}

[REDProp("radius")]
public SSimpleCurve Radius { get; set;}

[REDProp("offsetFront")]
public SSimpleCurve OffsetFront { get; set;}

[REDProp("offsetRight")]
public SSimpleCurve OffsetRight { get; set;}

[REDProp("offsetUp")]
public SSimpleCurve OffsetUp { get; set;}

#endregion
}
}