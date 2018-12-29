using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3UsableItem : CItemEntity
{
#region RED Properties

[REDProp("itemType")]
public EUsableItemType ItemType { get; set;}

[REDProp("blockedActions")]
public Array<EInputActionBlock> BlockedActions { get; set;}

[REDProp("wasOnHiddenCalled")]
public bool WasOnHiddenCalled { get; set;}

#endregion
}
}