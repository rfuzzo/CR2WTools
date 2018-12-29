using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TooltipComponent : CObject
{
#region RED Properties

[REDProp("m_playerInv")]
public Handle<CInventoryComponent> M_playerInv { get; set;}

[REDProp("m_itemInv")]
public Handle<CInventoryComponent> M_itemInv { get; set;}

[REDProp("m_shopInv")]
public Handle<CInventoryComponent> M_shopInv { get; set;}

[REDProp("m_flashValueStorage")]
public Handle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

[REDProp("m_enchantmentManager")]
public Handle<W3EnchantmentManager> M_enchantmentManager { get; set;}

#endregion
}
}