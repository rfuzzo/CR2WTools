using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4PlayerStateMountBoat : CR4PlayerStateMountTheVehicle
{
#region RED Properties

[REDProp("boatComp")]
public Handle<CBoatComponent> BoatComp { get; set;}

#endregion
}
}