using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskElementalThrowFire : CBTTaskAttack
{
#region RED Properties

[REDProp("projectileEntity")]
public Handle<CEntityTemplate> ProjectileEntity { get; set;}

[REDProp("projectile")]
public Handle<CProjectileTrajectory> Projectile { get; set;}

[REDProp("dodgeable")]
public bool Dodgeable { get; set;}

[REDProp("projectileShot")]
public bool ProjectileShot { get; set;}

#endregion
}
}