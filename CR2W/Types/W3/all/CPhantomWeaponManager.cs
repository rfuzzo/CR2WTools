using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CPhantomWeaponManager : CObject
{
#region RED Properties

[REDProp("hitsToCharge")]
public Int32 HitsToCharge { get; set;}

[REDProp("timeToDischarge")]
public float TimeToDischarge { get; set;}

[REDProp("minVitalityPercToCharge")]
public float MinVitalityPercToCharge { get; set;}

[REDProp("vitalityPercLostOnDischarge")]
public float VitalityPercLostOnDischarge { get; set;}

[REDProp("hitCounter")]
public Int32 HitCounter { get; set;}

[REDProp("isWeaponCharged")]
public bool IsWeaponCharged { get; set;}

[REDProp("itemId")]
public SItemUniqueId ItemId { get; set;}

[REDProp("inv")]
public Handle<CInventoryComponent> Inv { get; set;}

[REDProp("chargedLoopedFxName")]
public CName ChargedLoopedFxName { get; set;}

[REDProp("chargedSingleFxName")]
public CName ChargedSingleFxName { get; set;}

#endregion
}
}