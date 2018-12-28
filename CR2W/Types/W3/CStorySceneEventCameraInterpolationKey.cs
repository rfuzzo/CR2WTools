using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneEventCameraInterpolationKey 
{
#region RED Properties

/*[REDProp("bezierHandles")] //FIXME
public [15]Bezier2dHandle BezierHandles { get; set;}

[REDProp("interpolationTypes")]
public [15]Uint32 InterpolationTypes { get; set;}*/

[REDProp("volatile")]
public bool Volatile { get; set;}

#endregion
}
}