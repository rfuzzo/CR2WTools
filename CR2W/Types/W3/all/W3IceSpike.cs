using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3IceSpike : W3DurationObstacle
{
#region RED Properties

[REDProp("damageValue")]
public float DamageValue { get; set;}

[REDProp("weaponSlot")]
public CName WeaponSlot { get; set;}

[REDProp("canBeDestroyed")]
public bool CanBeDestroyed { get; set;}

[REDProp("destroyAfterTime")]
public float DestroyAfterTime { get; set;}

[REDProp("delayToDealDamage")]
public float DelayToDealDamage { get; set;}

#endregion
}
}