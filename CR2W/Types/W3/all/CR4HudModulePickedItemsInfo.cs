using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModulePickedItemsInfo : CR4HudModuleBase
{
#region RED Properties

[REDProp("_RecentlyAddedItemListSize")]
public Int32 _RecentlyAddedItemListSize { get; set;}

[REDProp("bCurrentShowState")]
public bool BCurrentShowState { get; set;}

[REDProp("bShouldShowElement")]
public bool BShouldShowElement { get; set;}

[REDProp("_PickedItemListSize")]
public Int32 _PickedItemListSize { get; set;}

#endregion
}
}