using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3IgniEntity : W3SignEntity
{
#region RED Properties

[REDProp("collisionFxEntity")]
public Handle<CEntity> CollisionFxEntity { get; set;}

[REDProp("rangeFxEntity")]
public Handle<CEntity> RangeFxEntity { get; set;}

[REDProp("channelBurnTestDT")]
public Array<SIgniChannelDT> ChannelBurnTestDT { get; set;}

[REDProp("lastCollisionFxPos")]
public Vector LastCollisionFxPos { get; set;}

[REDProp("CHANNELLING_BURN_TEST_FREQUENCY")]
public float CHANNELLING_BURN_TEST_FREQUENCY { get; set;}

[REDProp("aspects")]
public Array<SIgniAspect> Aspects { get; set;}

[REDProp("effects")]
public Array<SIgniEffects> Effects { get; set;}

[REDProp("forestTrigger")]
public Handle<W3ForestTrigger> ForestTrigger { get; set;}

[REDProp("projectileCollision")]
public Array<CName> ProjectileCollision { get; set;}

[REDProp("hitEntities")]
public Array<Handle<CGameplayEntity>> HitEntities { get; set;}

[REDProp("lastFxSpawnTime")]
public float LastFxSpawnTime { get; set;}

#endregion
}
}