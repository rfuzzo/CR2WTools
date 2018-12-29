using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3GuiPlayerInventoryComponent : W3GuiBaseInventoryComponent
{
#region RED Properties

[REDProp("_shopInvCmp")]
public Handle<W3GuiShopInventoryComponent> _shopInvCmp { get; set;}

[REDProp("_filterType")]
public EInventoryFilterType _filterType { get; set;}

[REDProp("_currentItemCategoryType")]
public CName _currentItemCategoryType { get; set;}

[REDProp("stashMode")]
public bool StashMode { get; set;}

[REDProp("bPaperdoll")]
public bool BPaperdoll { get; set;}

[REDProp("currentDefaultItemAction")]
public EInventoryActionType CurrentDefaultItemAction { get; set;}

[REDProp("ignorePosition")]
public bool IgnorePosition { get; set;}

[REDProp("filterTagList")]
public Array<CName> FilterTagList { get; set;}

[REDProp("filterForbiddenTagList")]
public Array<CName> FilterForbiddenTagList { get; set;}

[REDProp("overrideQuestItemFilters")]
public bool OverrideQuestItemFilters { get; set;}

[REDProp("previewItems")]
public Array<SItemUniqueId> PreviewItems { get; set;}

[REDProp("dyePreviewSlots")]
public Array<SItemUniqueId> DyePreviewSlots { get; set;}

#endregion
}
}