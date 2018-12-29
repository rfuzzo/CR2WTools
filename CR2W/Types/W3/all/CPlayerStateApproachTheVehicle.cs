using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CPlayerStateApproachTheVehicle : CPlayerStateBase
{
#region RED Properties

[REDProp("vehicle")]
public Handle<CVehicleComponent> Vehicle { get; set;}

[REDProp("slotNumber")]
public Int32 SlotNumber { get; set;}

#endregion
}
}