using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSTResolveStucking : IMoveSteeringTask
{
#region RED Properties

[REDProp("stuckFramesThreshold")]
public uint StuckFramesThreshold { get; set;}

[REDProp("distanceThreshold")]
public float DistanceThreshold { get; set;}

[REDProp("signalName")]
public CName SignalName { get; set;}

#endregion
}
}