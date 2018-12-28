using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneEventCameraLightInterpolationKey 
{
#region RED Properties

/*[REDProp("bezierHandles")]
public [2]Bezier2dHandle BezierHandles { get; set;}

[REDProp("interpolationTypes")]
public [2]Uint32 InterpolationTypes { get; set;}*/

[REDProp("volatile")]
public bool Volatile { get; set;}

#endregion
}
}