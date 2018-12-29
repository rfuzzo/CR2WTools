using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CStorySceneActionRotateToPlayer : CStorySceneAction
{
#region RED Properties

[REDProp("maxTime")]
public float MaxTime { get; set;}

[REDProp("acceptableAngleDif")]
public float AcceptableAngleDif { get; set;}

#endregion
}
}