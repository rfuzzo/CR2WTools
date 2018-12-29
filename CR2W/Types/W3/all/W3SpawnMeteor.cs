using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SpawnMeteor : W3AdvancedProjectile
{
#region RED Properties

[REDProp("initFxName")]
public CName InitFxName { get; set;}

[REDProp("onCollisionFxName")]
public CName OnCollisionFxName { get; set;}

[REDProp("onCollisionFxName2")]
public CName OnCollisionFxName2 { get; set;}

[REDProp("startFxName")]
public CName StartFxName { get; set;}

[REDProp("ent")]
public Handle<CEntity> Ent { get; set;}

[REDProp("projectileHitGround")]
public bool ProjectileHitGround { get; set;}

[REDProp("playerPos")]
public Vector PlayerPos { get; set;}

[REDProp("projPos")]
public Vector ProjPos { get; set;}

[REDProp("projSpawnPos")]
public Vector ProjSpawnPos { get; set;}

#endregion
}
}