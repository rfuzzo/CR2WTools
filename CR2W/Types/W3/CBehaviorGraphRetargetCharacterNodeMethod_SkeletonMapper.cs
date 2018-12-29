using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphRetargetCharacterNodeMethod_SkeletonMapper : IBehaviorGraphRetargetCharacterNodeMethod
{
#region RED Properties

[REDProp("skeleton")]
public Handle<CSkeleton> Skeleton { get; set;}

#endregion
}
}