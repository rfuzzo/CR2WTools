using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4ItemSelectionPopup : CR4PopupBase
{
#region RED Properties

[REDProp("m_DataObject")]
public Handle<W3ItemSelectionPopupData> M_DataObject { get; set;}

[REDProp("m_playerInv")]
public Handle<W3GuiSelectItemComponent> M_playerInv { get; set;}

[REDProp("m_containerInv")]
public Handle<W3GuiContainerInventoryComponent> M_containerInv { get; set;}

[REDProp("m_containerOwner")]
public Handle<CGameplayEntity> M_containerOwner { get; set;}

[REDProp("m_selectedItemCategory")]
public Int32 M_selectedItemCategory { get; set;}

#endregion
}
}