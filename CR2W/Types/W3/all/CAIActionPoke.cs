using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIActionPoke : IAIActionTree
{
#region RED Properties

[REDProp("pokeEvent")]
public CName PokeEvent { get; set;}

[REDProp("pokableScriptedAction")]
public Handle<IAIActionTree> PokableScriptedAction { get; set;}

#endregion
}
}