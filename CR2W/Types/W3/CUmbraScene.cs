using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CUmbraScene : CResource
{
#region RED Properties

[REDProp("distanceMultiplier")]
public float DistanceMultiplier { get; set;}

[REDProp("localUmbraOccThresholdMul")]
public Handle<CResourceSimplexTree> LocalUmbraOccThresholdMul { get; set;}

#endregion
}
}