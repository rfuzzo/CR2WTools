using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4PlayerStateDismountHorse : CPlayerStateDismountTheVehicle
{
#region RED Properties

[REDProp("horseComp")]
public Handle<W3HorseComponent> HorseComp { get; set;}

#endregion
}
}