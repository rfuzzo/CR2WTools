using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAICarryingItemsParams : CAINpcWanderParams
{
#region RED Properties

[REDProp("storePointTag")]
public CName StorePointTag { get; set;}

[REDProp("carryingArea")]
public EntityHandle CarryingArea { get; set;}

[REDProp("dropItemOnDeactivation")]
public bool DropItemOnDeactivation { get; set;}

#endregion
}
}