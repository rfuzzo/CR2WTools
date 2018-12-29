using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4BlacksmithMenu : CR4MenuBase
{
#region RED Properties

[REDProp("_disassembleInv")]
public Handle<W3GuiDisassembleInventoryComponent> _disassembleInv { get; set;}

[REDProp("_repairInv")]
public Handle<W3GuiRepairInventoryComponent> _repairInv { get; set;}

[REDProp("_socketInv")]
public Handle<W3GuiSocketsInventoryComponent> _socketInv { get; set;}

[REDProp("_curInv")]
public Handle<W3GuiBaseInventoryComponent> _curInv { get; set;}

[REDProp("_addSocketInv")]
public Handle<W3GuiAddSocketsInventoryComponent> _addSocketInv { get; set;}

[REDProp("_standaloneDismantleInv")]
public Handle<W3StandaloneDismantleComponent> _standaloneDismantleInv { get; set;}

[REDProp("_tooltipDataProvider")]
public Handle<W3TooltipComponent> _tooltipDataProvider { get; set;}

[REDProp("_inv")]
public Handle<CInventoryComponent> _inv { get; set;}

[REDProp("_fixerNpc")]
public Handle<CNewNPC> _fixerNpc { get; set;}

[REDProp("_fixerInventory")]
public Handle<CInventoryComponent> _fixerInventory { get; set;}

[REDProp("m_standaloneMode")]
public bool M_standaloneMode { get; set;}

[REDProp("m_menuInited")]
public bool M_menuInited { get; set;}

[REDProp("m_lastConfirmedDisassembleQuantity")]
public Int32 M_lastConfirmedDisassembleQuantity { get; set;}

[REDProp("MAX_ITEM_NR")]
public Int32 MAX_ITEM_NR { get; set;}

[REDProp("currentItemsNr")]
public Int32 CurrentItemsNr { get; set;}

[REDProp("InitDataConfirmation")]
public Handle<PriceConfirmationPopupData> InitDataConfirmation { get; set;}

[REDProp("repairAllPopupData")]
public Handle<RepairAllPopupData> RepairAllPopupData { get; set;}

[REDProp("quantityPopupData")]
public Handle<QuantityPopupData> QuantityPopupData { get; set;}

[REDProp("m_fxRemoveItem")]
public Handle<CScriptedFlashFunction> M_fxRemoveItem { get; set;}

[REDProp("m_fxConfirmAction")]
public Handle<CScriptedFlashFunction> M_fxConfirmAction { get; set;}

[REDProp("m_fxSetPlayerMoney")]
public Handle<CScriptedFlashFunction> M_fxSetPlayerMoney { get; set;}

[REDProp("m_fxSetXActionLabel")]
public Handle<CScriptedFlashFunction> M_fxSetXActionLabel { get; set;}

[REDProp("m_sectionsList")]
public Handle<CScriptedFlashArray> M_sectionsList { get; set;}

[REDProp("m_ingrForMissingDecoctions")]
public Array<CName> M_ingrForMissingDecoctions { get; set;}

#endregion
}
}