using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeNodeFlyOnCurveDefinition : CBehTreeNodeAttachToCurveDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("animationName")]
public CBehTreeValCName AnimationName { get; set;}

[REDProp("componentName")]
public CBehTreeValString ComponentName { get; set;}

[REDProp("blendInTime")]
public CBehTreeValFloat BlendInTime { get; set;}

[REDProp("animValPitch")]
public CBehTreeValCName AnimValPitch { get; set;}

[REDProp("animValYaw")]
public CBehTreeValCName AnimValYaw { get; set;}

[REDProp("maxPitchInput")]
public CBehTreeValFloat MaxPitchInput { get; set;}

[REDProp("maxPitchOutput")]
public CBehTreeValFloat MaxPitchOutput { get; set;}

[REDProp("maxYawInput")]
public CBehTreeValFloat MaxYawInput { get; set;}

[REDProp("maxYawOutput")]
public CBehTreeValFloat MaxYawOutput { get; set;}

#endregion
}
}