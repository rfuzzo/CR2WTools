using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4PlayerStateSailing : CR4PlayerStateUseGenericVehicle
{
#region RED Properties

[REDProp("boatLogic")]
public Handle<CBoatComponent> BoatLogic { get; set;}

[REDProp("remainingSlideDuration")]
public float RemainingSlideDuration { get; set;}

[REDProp("vehicleCombatMgr")]
public Handle<W3VehicleCombatManager> VehicleCombatMgr { get; set;}

[REDProp("dismountRequest")]
public bool DismountRequest { get; set;}

[REDProp("angleToSeatFromBack")]
public float AngleToSeatFromBack { get; set;}

[REDProp("angleToSeatFromForward")]
public float AngleToSeatFromForward { get; set;}

[REDProp("angleDamper")]
public float AngleDamper { get; set;}

[REDProp("offsetDamper")]
public float OffsetDamper { get; set;}

[REDProp("rudderDamper")]
public float RudderDamper { get; set;}

[REDProp("cameraSide")]
public float CameraSide { get; set;}

[REDProp("m_shouldEnableAutoRotation")]
public bool M_shouldEnableAutoRotation { get; set;}

#endregion
}
}