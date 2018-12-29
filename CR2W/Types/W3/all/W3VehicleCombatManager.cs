using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3VehicleCombatManager : CEntity
{
#region RED Properties

[REDProp("rider")]
public Handle<CR4Player> Rider { get; set;}

[REDProp("vehicle")]
public Handle<CVehicleComponent> Vehicle { get; set;}

[REDProp("isInCombatAction")]
public bool IsInCombatAction { get; set;}

[REDProp("wasBombReleased")]
public bool WasBombReleased { get; set;}

#endregion
}
}