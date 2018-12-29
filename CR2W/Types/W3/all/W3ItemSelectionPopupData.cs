using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ItemSelectionPopupData : CObject
{
#region RED Properties

[REDProp("targetInventory")]
public Handle<CInventoryComponent> TargetInventory { get; set;}

[REDProp("filterTagsList")]
public Array<CName> FilterTagsList { get; set;}

[REDProp("filterForbiddenTagsList")]
public Array<CName> FilterForbiddenTagsList { get; set;}

[REDProp("categoryFilterList")]
public Array<CName> CategoryFilterList { get; set;}

[REDProp("collectorTag")]
public CName CollectorTag { get; set;}

[REDProp("targetItems")]
public Array<CName> TargetItems { get; set;}

[REDProp("selectionMode")]
public EItemSelectionPopupMode SelectionMode { get; set;}

[REDProp("overrideQuestItemRestrictions")]
public bool OverrideQuestItemRestrictions { get; set;}

#endregion
}
}