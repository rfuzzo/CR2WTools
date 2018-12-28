using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SStorySceneSpotLightProperties 
{
#region RED Properties

[REDProp("innerAngle")]
public float InnerAngle { get; set;}

[REDProp("outerAngle")]
public float OuterAngle { get; set;}

[REDProp("softness")]
public float Softness { get; set;}

#endregion
}
}