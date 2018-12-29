using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskExplodeAtDeath : IBehTreeTask
{
#region RED Properties

[REDProp("requiredAbility")]
public CName RequiredAbility { get; set;}

[REDProp("damageRadius")]
public float DamageRadius { get; set;}

[REDProp("damageValue")]
public float DamageValue { get; set;}

[REDProp("weaponSlot")]
public CName WeaponSlot { get; set;}

[REDProp("m_hasExploded")]
public bool M_hasExploded { get; set;}

#endregion
}
}