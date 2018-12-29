using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIFlightIdleFreeRoam : IAIFlightIdleTree
{
#region RED Properties

[REDProp("flightHeight")]
public float FlightHeight { get; set;}

[REDProp("flyAround")]
public bool FlyAround { get; set;}

[REDProp("flyAroundDurationMin")]
public float FlyAroundDurationMin { get; set;}

[REDProp("flyAroundDurationMax")]
public float FlyAroundDurationMax { get; set;}

[REDProp("flightAreaSelection")]
public EAIAreaSelectionMode FlightAreaSelection { get; set;}

[REDProp("flightAreaOptionalTag")]
public CName FlightAreaOptionalTag { get; set;}

#endregion
}
}