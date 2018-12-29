using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4PlayerStateHorseRiding : CR4PlayerStateUseGenericVehicle
{
#region RED Properties

[REDProp("dismountRequest")]
public bool DismountRequest { get; set;}

[REDProp("vehicleCombatMgr")]
public Handle<W3HorseCombatManager> VehicleCombatMgr { get; set;}

[REDProp("meleeTicketRequest")]
public Int32 MeleeTicketRequest { get; set;}

[REDProp("rangeTicketRequest")]
public Int32 RangeTicketRequest { get; set;}

[REDProp("scabbardsComp")]
public Handle<CAnimatedComponent> ScabbardsComp { get; set;}

[REDProp("initCamera")]
public bool InitCamera { get; set;}

[REDProp("currDesiredDist")]
public float CurrDesiredDist { get; set;}

[REDProp("cameraManualRotationDisabled")]
public bool CameraManualRotationDisabled { get; set;}

[REDProp("wasTrailCameraActive")]
public bool WasTrailCameraActive { get; set;}

[REDProp("trailCameraTimeStamp")]
public float TrailCameraTimeStamp { get; set;}

[REDProp("trailCameraCooldown")]
public float TrailCameraCooldown { get; set;}

[REDProp("m_shouldEnableAutoRotation")]
public bool M_shouldEnableAutoRotation { get; set;}

#endregion
}
}