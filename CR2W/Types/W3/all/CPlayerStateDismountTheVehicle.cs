using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CPlayerStateDismountTheVehicle : CPlayerStatePostUseVehicle
{
#region RED Properties

[REDProp("vehicle")]
public Handle<CVehicleComponent> Vehicle { get; set;}

[REDProp("dismountType")]
public EDismountType DismountType { get; set;}

#endregion
}
}