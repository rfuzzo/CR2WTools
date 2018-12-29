using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4InventoryMenu : CR4MenuBase
{
#region RED Properties

[REDProp("_playerInv")]
public Handle<W3GuiPlayerInventoryComponent> _playerInv { get; set;}

[REDProp("_paperdollInv")]
public Handle<W3GuiPaperdollInventoryComponent> _paperdollInv { get; set;}

[REDProp("_containerInv")]
public Handle<W3GuiContainerInventoryComponent> _containerInv { get; set;}

[REDProp("_shopInv")]
public Handle<W3GuiShopInventoryComponent> _shopInv { get; set;}

[REDProp("_horseInv")]
public Handle<W3GuiContainerInventoryComponent> _horseInv { get; set;}

[REDProp("_horsePaperdollInv")]
public Handle<W3GuiHorseInventoryComponent> _horsePaperdollInv { get; set;}

[REDProp("_currentInv")]
public Handle<W3GuiBaseInventoryComponent> _currentInv { get; set;}

[REDProp("_currentMouseInv")]
public Handle<W3GuiBaseInventoryComponent> _currentMouseInv { get; set;}

[REDProp("_quantityPopupData")]
public Handle<QuantityPopupData> _quantityPopupData { get; set;}

[REDProp("_statsContext")]
public Handle<W3PlayerStatsContext> _statsContext { get; set;}

[REDProp("_paperdollContext")]
public Handle<W3InventoryPaperdollContext> _paperdollContext { get; set;}

[REDProp("_invContext")]
public Handle<W3InventoryGridContext> _invContext { get; set;}

[REDProp("_externGridContext")]
public Handle<W3ExternalGridContext> _externGridContext { get; set;}

[REDProp("_bookPopupData")]
public Handle<BookPopupFeedback> _bookPopupData { get; set;}

[REDProp("_paintingPopupData")]
public Handle<PaintingPopup> _paintingPopupData { get; set;}

[REDProp("_charStatsPopupData")]
public Handle<CharacterStatsPopupData> _charStatsPopupData { get; set;}

[REDProp("_itemInfoPopupData")]
public Handle<ItemInfoPopupData> _itemInfoPopupData { get; set;}

[REDProp("_destroyConfPopData")]
public Handle<W3DestroyItemConfPopup> _destroyConfPopData { get; set;}

[REDProp("drawHorse")]
public bool DrawHorse { get; set;}

[REDProp("m_player")]
public Handle<CEntity> M_player { get; set;}

[REDProp("_inv")]
public Handle<CInventoryComponent> _inv { get; set;}

[REDProp("_container")]
public Handle<W3Container> _container { get; set;}

[REDProp("_shopNpc")]
public Handle<CNewNPC> _shopNpc { get; set;}

[REDProp("_tooltipDataProvider")]
public Handle<W3TooltipComponent> _tooltipDataProvider { get; set;}

[REDProp("currentlySelectedTab")]
public Int32 CurrentlySelectedTab { get; set;}

[REDProp("_defaultInventoryState")]
public EInventoryMenuState _defaultInventoryState { get; set;}

[REDProp("_currentState")]
public EInventoryMenuState _currentState { get; set;}

[REDProp("optionsItemActions")]
public Array<EInventoryActionType> OptionsItemActions { get; set;}

[REDProp("_sentStats")]
public Array<SentStatsData> _sentStats { get; set;}

[REDProp("_currentQuickSlot")]
public EEquipmentSlots _currentQuickSlot { get; set;}

[REDProp("_currentEqippedQuickSlot")]
public EEquipmentSlots _currentEqippedQuickSlot { get; set;}

[REDProp("MAX_ITEM_NR")]
public Int32 MAX_ITEM_NR { get; set;}

[REDProp("currentItemsNr")]
public Int32 CurrentItemsNr { get; set;}

[REDProp("m_menuInited")]
public bool M_menuInited { get; set;}

[REDProp("m_isPadConnected")]
public bool M_isPadConnected { get; set;}

[REDProp("m_isUsingPad")]
public bool M_isUsingPad { get; set;}

[REDProp("m_hidePaperdoll")]
public bool M_hidePaperdoll { get; set;}

[REDProp("m_tagsFilter")]
public Array<CName> M_tagsFilter { get; set;}

[REDProp("m_ignoreSaveData")]
public bool M_ignoreSaveData { get; set;}

[REDProp("m_selectionModeActive")]
public bool M_selectionModeActive { get; set;}

[REDProp("m_selectionModeItem")]
public SItemUniqueId M_selectionModeItem { get; set;}

[REDProp("m_dyePreviewMode")]
public bool M_dyePreviewMode { get; set;}

[REDProp("m_dyePreviewSlots")]
public Array<SItemUniqueId> M_dyePreviewSlots { get; set;}

[REDProp("m_previewItems")]
public Array<SItemUniqueId> M_previewItems { get; set;}

[REDProp("m_previewSlots")]
public Array<bool> M_previewSlots { get; set;}

[REDProp("m_lastSelectedModuleID")]
public Int32 M_lastSelectedModuleID { get; set;}

[REDProp("m_lastSelectedModuleBindingName")]
public string M_lastSelectedModuleBindingName { get; set;}

[REDProp("m_bookPopupItem")]
public SItemUniqueId M_bookPopupItem { get; set;}

[REDProp("currentSelectedItem")]
public SItemUniqueId CurrentSelectedItem { get; set;}

[REDProp("m_fxPaperdollRemoveItem")]
public Handle<CScriptedFlashFunction> M_fxPaperdollRemoveItem { get; set;}

[REDProp("m_fxInventoryRemoveItem")]
public Handle<CScriptedFlashFunction> M_fxInventoryRemoveItem { get; set;}

[REDProp("m_fxInventoryUpdateFilter")]
public Handle<CScriptedFlashFunction> M_fxInventoryUpdateFilter { get; set;}

[REDProp("m_fxForceSelectItem")]
public Handle<CScriptedFlashFunction> M_fxForceSelectItem { get; set;}

[REDProp("m_fxForceSelectPaperdollSlot")]
public Handle<CScriptedFlashFunction> M_fxForceSelectPaperdollSlot { get; set;}

[REDProp("m_fxSetFilteringMode")]
public Handle<CScriptedFlashFunction> M_fxSetFilteringMode { get; set;}

[REDProp("m_fxRemoveContainerItem")]
public Handle<CScriptedFlashFunction> M_fxRemoveContainerItem { get; set;}

[REDProp("m_fxHideSelectionMode")]
public Handle<CScriptedFlashFunction> M_fxHideSelectionMode { get; set;}

[REDProp("m_fxSetInventoryMode")]
public Handle<CScriptedFlashFunction> M_fxSetInventoryMode { get; set;}

[REDProp("m_fxSetNewFlagsForTabs")]
public Handle<CScriptedFlashFunction> M_fxSetNewFlagsForTabs { get; set;}

[REDProp("m_fxSetSortingMode")]
public Handle<CScriptedFlashFunction> M_fxSetSortingMode { get; set;}

[REDProp("m_fxSetVitality")]
public Handle<CScriptedFlashFunction> M_fxSetVitality { get; set;}

[REDProp("m_fxSetToxicity")]
public Handle<CScriptedFlashFunction> M_fxSetToxicity { get; set;}

[REDProp("m_fxSetPreviewMode")]
public Handle<CScriptedFlashFunction> M_fxSetPreviewMode { get; set;}

[REDProp("m_fxSetDefaultTab")]
public Handle<CScriptedFlashFunction> M_fxSetDefaultTab { get; set;}

[REDProp("hackHideStatTooltip")]
public bool HackHideStatTooltip { get; set;}

[REDProp("hackHideItemTooltip")]
public bool HackHideItemTooltip { get; set;}

#endregion
}
}