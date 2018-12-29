using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3IceSpearProjectile : W3AdvancedProjectile
{
#region RED Properties

[REDProp("initFxName")]
public CName InitFxName { get; set;}

[REDProp("onCollisionFxName")]
public CName OnCollisionFxName { get; set;}

[REDProp("spawnEntityTemplate")]
public Handle<CEntityTemplate> SpawnEntityTemplate { get; set;}

[REDProp("customDuration")]
public float CustomDuration { get; set;}

[REDProp("onCollisionVictimFxName")]
public CName OnCollisionVictimFxName { get; set;}

[REDProp("immediatelyStopVictimFX")]
public bool ImmediatelyStopVictimFX { get; set;}

[REDProp("projectileHitGround")]
public bool ProjectileHitGround { get; set;}

#endregion
}
}