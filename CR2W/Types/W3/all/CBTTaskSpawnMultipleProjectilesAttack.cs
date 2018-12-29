using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSpawnMultipleProjectilesAttack : CBTTaskSpawnMultipleEntitiesAttack
{
#region RED Properties

[REDProp("projectileAngle")]
public float ProjectileAngle { get; set;}

[REDProp("projectileAngleRandomness")]
public float ProjectileAngleRandomness { get; set;}

[REDProp("projectileSpeed")]
public float ProjectileSpeed { get; set;}

[REDProp("projectileSpeedRandomness")]
public float ProjectileSpeedRandomness { get; set;}

[REDProp("dodgeable")]
public bool Dodgeable { get; set;}

#endregion
}
}