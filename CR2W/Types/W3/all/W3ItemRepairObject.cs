using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ItemRepairObject : CR4MapPinEntity
{
#region RED Properties

[REDProp("repairSword")]
public bool RepairSword { get; set;}

[REDProp("repairArmor")]
public bool RepairArmor { get; set;}

[REDProp("chargesArmor")]
public Int32 ChargesArmor { get; set;}

[REDProp("chargesWeapon")]
public Int32 ChargesWeapon { get; set;}

[REDProp("interactionComp")]
public Handle<CInteractionComponent> InteractionComp { get; set;}

#endregion
}
}