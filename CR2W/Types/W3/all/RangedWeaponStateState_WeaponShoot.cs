using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class RangedWeaponStateState_WeaponShoot : CScriptableState
{
#region RED Properties

[REDProp("cachedCombatActionTarget")]
public Handle<CGameplayEntity> CachedCombatActionTarget { get; set;}

#endregion
}
}