using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIAttachToCurve : IAIActionTree
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

#endregion
}
}