using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SFlashRenderTargetCamera 
{
#region RED Properties

[REDProp("position")]
public Vector Position { get; set;}

[REDProp("rotation")]
public EulerAngles Rotation { get; set;}

[REDProp("fov")]
public float Fov { get; set;}

[REDProp("zoom")]
public float Zoom { get; set;}

#endregion
}
}