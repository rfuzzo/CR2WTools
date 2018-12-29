using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeNodeAttachToCurveDefinition : CBehTreeNodeAtomicActionDefinition
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

#endregion
}
}