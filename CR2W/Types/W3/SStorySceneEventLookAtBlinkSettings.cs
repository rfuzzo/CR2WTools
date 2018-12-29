using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SStorySceneEventLookAtBlinkSettings 
{
#region RED Properties

[REDProp("canCloseEyes")]
public bool CanCloseEyes { get; set;}

[REDProp("forceCloseEyes")]
public bool ForceCloseEyes { get; set;}

[REDProp("animationName")]
public CName AnimationName { get; set;}

[REDProp("startOffset")]
public float StartOffset { get; set;}

[REDProp("durationPercent")]
public float DurationPercent { get; set;}

[REDProp("horizontalAngleDeg")]
public float HorizontalAngleDeg { get; set;}

#endregion
}
}