using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CPlayerStateDismountBoat : CPlayerStateDismountTheVehicle
{
#region RED Properties

[REDProp("boatComp")]
public Handle<CBoatComponent> BoatComp { get; set;}

[REDProp("remainingSlideDuration")]
public float RemainingSlideDuration { get; set;}

[REDProp("fromPassenger")]
public bool FromPassenger { get; set;}

#endregion
}
}