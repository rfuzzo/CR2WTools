using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIFlyOnCurve : IFlightActionTree
{
#region RED Properties

[REDProp("animationName")]
public CName AnimationName { get; set;}

[REDProp("curveTag")]
public CName CurveTag { get; set;}

[REDProp("curveDummyName")]
public string CurveDummyName { get; set;}

[REDProp("blendInTime")]
public float BlendInTime { get; set;}

[REDProp("slotAnimation")]
public CName SlotAnimation { get; set;}

[REDProp("animValPitch")]
public string AnimValPitch { get; set;}

[REDProp("animValYaw")]
public string AnimValYaw { get; set;}

[REDProp("maxPitchInput")]
public float MaxPitchInput { get; set;}

[REDProp("maxPitchOutput")]
public float MaxPitchOutput { get; set;}

[REDProp("maxYawInput")]
public float MaxYawInput { get; set;}

[REDProp("maxYawOutput")]
public float MaxYawOutput { get; set;}

#endregion
}
}