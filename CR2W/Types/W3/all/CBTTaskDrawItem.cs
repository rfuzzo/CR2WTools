using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskDrawItem : IBehTreeTask
{
#region RED Properties

[REDProp("owner")]
public Handle<CNewNPC> Owner { get; set;}

[REDProp("inventory")]
public Handle<CInventoryComponent> Inventory { get; set;}

[REDProp("temp")]
public Array<SItemUniqueId> Temp { get; set;}

[REDProp("itemName")]
public CName ItemName { get; set;}

[REDProp("eventName")]
public CName EventName { get; set;}

#endregion
}
}