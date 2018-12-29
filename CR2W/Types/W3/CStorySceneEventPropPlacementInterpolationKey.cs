using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CStorySceneEventPropPlacementInterpolationKey 
{
#region RED Properties

/*[REDProp("bezierHandles")]
public [6]Bezier2dHandle BezierHandles { get; set;}

[REDProp("interpolationTypes")]
public [6]Uint32 InterpolationTypes { get; set;}*/

[REDProp("volatile")]
public bool Volatile { get; set;}

#endregion
}
}