using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SMapPinConfig 
{
#region RED Properties

[REDProp("pinTypes")]
public Array<SMapPinType> PinTypes { get; set;}

[REDProp("alwaysTrackedPins")]
public Array<CName> AlwaysTrackedPins { get; set;}

[REDProp("distantUpdateTime")]
public float DistantUpdateTime { get; set;}

[REDProp("nearbyRadius")]
public float NearbyRadius { get; set;}

#endregion
}
}