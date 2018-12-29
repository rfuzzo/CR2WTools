using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4PlayerStateSailingPassive : CR4PlayerStateUseGenericVehicle
{
#region RED Properties

[REDProp("boatLogic")]
public Handle<CBoatComponent> BoatLogic { get; set;}

[REDProp("dismountRequest")]
public bool DismountRequest { get; set;}

[REDProp("vehicleCombatMgr")]
public Handle<W3VehicleCombatManager> VehicleCombatMgr { get; set;}

[REDProp("rudderDamper")]
public float RudderDamper { get; set;}

#endregion
}
}