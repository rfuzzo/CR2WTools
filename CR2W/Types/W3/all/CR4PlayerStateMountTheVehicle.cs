using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4PlayerStateMountTheVehicle : CPlayerStateBase
{
#region RED Properties

[REDProp("vehicle")]
public Handle<CVehicleComponent> Vehicle { get; set;}

[REDProp("mountType")]
public EMountType MountType { get; set;}

[REDProp("vehicleSlot")]
public EVehicleSlot VehicleSlot { get; set;}

[REDProp("camera")]
public Handle<CCustomCamera> Camera { get; set;}

#endregion
}
}