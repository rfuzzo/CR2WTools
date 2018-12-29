using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4PlayerStateUseGenericVehicle : CPlayerStateUseVehicle
{
#region RED Properties

[REDProp("vehicle")]
public Handle<CVehicleComponent> Vehicle { get; set;}

[REDProp("camera")]
public Handle<CCustomCamera> Camera { get; set;}

[REDProp("signSlotNames")]
public Array<CName> SignSlotNames { get; set;}

[REDProp("fovVel")]
public float FovVel { get; set;}

#endregion
}
}