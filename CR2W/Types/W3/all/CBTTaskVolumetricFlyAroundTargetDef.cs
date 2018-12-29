using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskVolumetricFlyAroundTargetDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("distance")]
public float Distance { get; set;}

[REDProp("height")]
public float Height { get; set;}

[REDProp("flightMaxDuration")]
public float FlightMaxDuration { get; set;}

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

#endregion
}
}