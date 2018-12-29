using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskVolumetricFlyAroundTarget : CBTTaskVolumetricMove
{
#region RED Properties

[REDProp("distance")]
public float Distance { get; set;}

[REDProp("height")]
public float Height { get; set;}

[REDProp("flightMaxDuration")]
public float FlightMaxDuration { get; set;}

[REDProp("npcToDestDistance")]
public float NpcToDestDistance { get; set;}

[REDProp("flightStartTime")]
public float FlightStartTime { get; set;}

[REDProp("flightDuration")]
public float FlightDuration { get; set;}

#endregion
}
}