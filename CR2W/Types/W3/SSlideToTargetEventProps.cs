using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SSlideToTargetEventProps 
{
#region RED Properties

[REDProp("minSlideDist")]
public float MinSlideDist { get; set;}

[REDProp("maxSlideDist")]
public float MaxSlideDist { get; set;}

[REDProp("slideToMaxDistIfTargetSeen")]
public bool SlideToMaxDistIfTargetSeen { get; set;}

[REDProp("slideToMaxDistIfNoTarget")]
public bool SlideToMaxDistIfNoTarget { get; set;}

#endregion
}
}