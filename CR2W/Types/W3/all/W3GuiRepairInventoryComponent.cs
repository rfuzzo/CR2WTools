using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3GuiRepairInventoryComponent : W3GuiBaseInventoryComponent
{
#region RED Properties

[REDProp("merchantInv")]
public Handle<CInventoryComponent> MerchantInv { get; set;}

[REDProp("masteryLevel")]
public Int32 MasteryLevel { get; set;}

[REDProp("repairSwords")]
public bool RepairSwords { get; set;}

[REDProp("repairArmors")]
public bool RepairArmors { get; set;}

#endregion
}
}