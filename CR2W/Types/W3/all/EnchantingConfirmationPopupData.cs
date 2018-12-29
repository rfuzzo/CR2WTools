using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class EnchantingConfirmationPopupData : ConfirmationPopupData
{
#region RED Properties

[REDProp("removingEnchantment")]
public bool RemovingEnchantment { get; set;}

[REDProp("menuRef")]
public Handle<CR4EnchantingMenu> MenuRef { get; set;}

[REDProp("m_Price")]
public float M_Price { get; set;}

#endregion
}
}