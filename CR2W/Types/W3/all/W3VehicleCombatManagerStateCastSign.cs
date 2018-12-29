using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3VehicleCombatManagerStateCastSign : CScriptableState
{
#region RED Properties

[REDProp("witcher")]
public Handle<W3PlayerWitcher> Witcher { get; set;}

[REDProp("horse")]
public Handle<CActor> Horse { get; set;}

[REDProp("horseComp")]
public Handle<W3HorseComponent> HorseComp { get; set;}

#endregion
}
}