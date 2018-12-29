using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIRiderActionPoke : IRiderActionTree
{
#region RED Properties

[REDProp("pokeEvent")]
public CName PokeEvent { get; set;}

[REDProp("pokableScriptedAction")]
public Handle<IRiderActionTree> PokableScriptedAction { get; set;}

#endregion
}
}