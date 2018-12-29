using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3AlchemyManager : CObject
{
#region RED Properties

[REDProp("recipes")]
public Array<SAlchemyRecipe> Recipes { get; set;}

[REDProp("isPlayerMounted")]
public bool IsPlayerMounted { get; set;}

[REDProp("isPlayerInCombat")]
public bool IsPlayerInCombat { get; set;}

#endregion
}
}