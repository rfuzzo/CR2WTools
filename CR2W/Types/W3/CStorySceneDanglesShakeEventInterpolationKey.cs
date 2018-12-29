using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CStorySceneDanglesShakeEventInterpolationKey 
{
#region RED Properties

/*[REDProp("bezierHandles")] //FIXME
public [1]Bezier2dHandle BezierHandles { get; set;}

[REDProp("interpolationTypes")]
public [1]Uint32 InterpolationTypes { get; set;}*/

[REDProp("volatile")]
public bool Volatile { get; set;}

#endregion
}
}