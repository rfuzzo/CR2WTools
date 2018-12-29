using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4RyanAlchemyMenu : CR4Menu
{
#region RED Properties

[REDProp("KEY_RECIPE_LIST")]
public string KEY_RECIPE_LIST { get; set;}

[REDProp("m_flashValueStorage")]
public Handle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

[REDProp("m_alchemyManager")]
public Handle<W3AlchemyManager> M_alchemyManager { get; set;}

[REDProp("m_inventory")]
public Handle<CInventoryComponent> M_inventory { get; set;}

[REDProp("m_recipeList")]
public Array<SAlchemyRecipe> M_recipeList { get; set;}

#endregion
}
}