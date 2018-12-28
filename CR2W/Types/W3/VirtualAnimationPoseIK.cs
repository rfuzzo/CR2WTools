using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class VirtualAnimationPoseIK 
{
#region RED Properties

[REDProp("time")]
public float Time { get; set;}

[REDProp("ids")]
public Array<ETCrEffectorId> Ids { get; set;}

[REDProp("positionsMS")]
public Array<Vector> PositionsMS { get; set;}

[REDProp("rotationsMS")]
public Array<EulerAngles> RotationsMS { get; set;}

[REDProp("weights")]
public Array<float> Weights { get; set;}

#endregion
}
}