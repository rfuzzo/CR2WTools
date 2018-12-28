using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class STargetSelectionWeights 
{
#region RED Properties

[REDProp("angleWeight")]
public float AngleWeight { get; set;}

[REDProp("distanceWeight")]
public float DistanceWeight { get; set;}

[REDProp("distanceRingWeight")]
public float DistanceRingWeight { get; set;}

#endregion
}
}