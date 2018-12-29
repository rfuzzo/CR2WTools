using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3GuiSocketsInventoryComponent : W3GuiPlayerInventoryComponent
{
#region RED Properties

[REDProp("merchantInv")]
public Handle<CInventoryComponent> MerchantInv { get; set;}

[REDProp("m_upgradeItem")]
public SItemUniqueId M_upgradeItem { get; set;}

[REDProp("m_useSocketsFilter")]
public bool M_useSocketsFilter { get; set;}

#endregion
}
}