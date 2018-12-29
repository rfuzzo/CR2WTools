using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4PreparationOilsMenu : CR4MenuBase
{
#region RED Properties

[REDProp("_gridInv")]
public Handle<W3GuiPreparationOilsInventoryComponent> _gridInv { get; set;}

[REDProp("_currentInv")]
public Handle<W3GuiBaseInventoryComponent> _currentInv { get; set;}

[REDProp("_inv")]
public Handle<CInventoryComponent> _inv { get; set;}

[REDProp("optionsItemActions")]
public Array<EInventoryActionType> OptionsItemActions { get; set;}

[REDProp("_currentQuickSlot")]
public EEquipmentSlots _currentQuickSlot { get; set;}

[REDProp("ITEMS_SIZE")]
public Int32 ITEMS_SIZE { get; set;}

#endregion
}
}