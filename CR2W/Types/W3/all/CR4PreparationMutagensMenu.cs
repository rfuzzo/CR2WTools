using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4PreparationMutagensMenu : CR4MenuBase
{
#region RED Properties

[REDProp("_gridInv")]
public Handle<W3GuiPreparationMutagensInventoryComponent> _gridInv { get; set;}

[REDProp("_currentInv")]
public Handle<W3GuiBaseInventoryComponent> _currentInv { get; set;}

[REDProp("_inv")]
public Handle<CInventoryComponent> _inv { get; set;}

[REDProp("optionsItemActions")]
public Array<EInventoryActionType> OptionsItemActions { get; set;}

[REDProp("_currentQuickSlot")]
public EEquipmentSlots _currentQuickSlot { get; set;}

[REDProp("TOXICTY_BAR_DATA_BINDING_KEY")]
public string TOXICTY_BAR_DATA_BINDING_KEY { get; set;}

[REDProp("MUTAGENS_SIZE")]
public Int32 MUTAGENS_SIZE { get; set;}

[REDProp("initialized")]
public bool Initialized { get; set;}

#endregion
}
}