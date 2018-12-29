using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CHorseRiderSharedParams : IScriptable
{
#region RED Properties

[REDProp("rider")]
public Handle<CActor> Rider { get; set;}

[REDProp("horse")]
public Handle<CActor> Horse { get; set;}

[REDProp("mountStatus")]
public EVehicleMountStatus MountStatus { get; set;}

[REDProp("boat")]
public EntityHandle Boat { get; set;}

[REDProp("vehicleSlot")]
public EVehicleSlot VehicleSlot { get; set;}

#endregion
}
}