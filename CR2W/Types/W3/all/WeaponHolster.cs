using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class WeaponHolster : CObject
{
#region RED Properties

[REDProp("currentMeleeWeapon")]
public EPlayerWeapon CurrentMeleeWeapon { get; set;}

[REDProp("queuedMeleeWeapon")]
public EPlayerWeapon QueuedMeleeWeapon { get; set;}

[REDProp("isQueuedMeleeWeapon")]
public bool IsQueuedMeleeWeapon { get; set;}

[REDProp("ownerHandle")]
public EntityHandle OwnerHandle { get; set;}

[REDProp("automaticUnholster")]
public bool AutomaticUnholster { get; set;}

[REDProp("isMeleeWeaponReady")]
public bool IsMeleeWeaponReady { get; set;}

#endregion
}
}