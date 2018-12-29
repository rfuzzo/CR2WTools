using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3VehicleCombatManagerStateNull : CScriptableState
{
#region RED Properties

[REDProp("rider")]
public Handle<CR4Player> Rider { get; set;}

[REDProp("horseComp")]
public Handle<W3HorseComponent> HorseComp { get; set;}

#endregion
}
}