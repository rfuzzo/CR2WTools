using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_IsInVehicle : CQCActorScriptedCondition
{
#region RED Properties

[REDProp("vehicleType")]
public EVehicleType VehicleType { get; set;}

[REDProp("vehicleTag")]
public CName VehicleTag { get; set;}

[REDProp("anyVehicle")]
public bool AnyVehicle { get; set;}

#endregion
}
}