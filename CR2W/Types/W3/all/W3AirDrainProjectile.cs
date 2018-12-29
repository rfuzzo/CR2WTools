using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3AirDrainProjectile : W3AdvancedProjectile
{
#region RED Properties

[REDProp("destructionEntity")]
public Handle<CEntityTemplate> DestructionEntity { get; set;}

[REDProp("markerEntityTemplate")]
public Handle<CEntityTemplate> MarkerEntityTemplate { get; set;}

[REDProp("AirToDrain")]
public float AirToDrain { get; set;}

[REDProp("initFxName")]
public CName InitFxName { get; set;}

[REDProp("onCollisionFxName")]
public CName OnCollisionFxName { get; set;}

[REDProp("onCollisionFxName2")]
public CName OnCollisionFxName2 { get; set;}

[REDProp("markerEntity")]
public Handle<CEntity> MarkerEntity { get; set;}

[REDProp("projectileHitGround")]
public bool ProjectileHitGround { get; set;}

#endregion
}
}