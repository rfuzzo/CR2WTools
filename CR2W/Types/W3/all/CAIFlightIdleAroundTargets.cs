using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIFlightIdleAroundTargets : IAIFlightIdleTree
{
#region RED Properties

[REDProp("flightTargetTag")]
public CName FlightTargetTag { get; set;}

[REDProp("flightAroundClosest")]
public bool FlightAroundClosest { get; set;}

[REDProp("flightAroundReselect")]
public bool FlightAroundReselect { get; set;}

[REDProp("flyAroundReselectDurationMin")]
public float FlyAroundReselectDurationMin { get; set;}

[REDProp("flyAroundReselectDurationMax")]
public float FlyAroundReselectDurationMax { get; set;}

[REDProp("idleFlightRadiusMin")]
public float IdleFlightRadiusMin { get; set;}

[REDProp("idleFlightRadiusMax")]
public float IdleFlightRadiusMax { get; set;}

[REDProp("idleFlightHeightMin")]
public float IdleFlightHeightMin { get; set;}

[REDProp("idleFlightHeightMax")]
public float IdleFlightHeightMax { get; set;}

#endregion
}
}