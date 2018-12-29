using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CStorySceneEventCameraInterpolationKey 
{
#region RED Properties

/*[REDProp("bezierHandles")]
public [15]Bezier2dHandle BezierHandles { get; set;}

[REDProp("interpolationTypes")]
public [15]uint InterpolationTypes { get; set;}*/

[REDProp("volatile")]
public bool Volatile { get; set;}

#endregion
}
}