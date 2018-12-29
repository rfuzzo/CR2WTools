using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TrapProjectileArea : W3Trap
{
#region RED Properties

[REDProp("projectile")]
public Handle<CEntityTemplate> Projectile { get; set;}

[REDProp("density")]
public float Density { get; set;}

[REDProp("maxShots")]
public Int32 MaxShots { get; set;}

[REDProp("reloadAtActivation")]
public bool ReloadAtActivation { get; set;}

[REDProp("projAtOnce")]
public SRange ProjAtOnce { get; set;}

[REDProp("delay")]
public SRangeF Delay { get; set;}

[REDProp("targetPlayerDelay")]
public SRangeF TargetPlayerDelay { get; set;}

[REDProp("height")]
public SRangeF Height { get; set;}

[REDProp("velocity")]
public SRangeF Velocity { get; set;}

[REDProp("projectileOriginOffsetX")]
public SRangeF ProjectileOriginOffsetX { get; set;}

[REDProp("projectileOriginOffsetY")]
public SRangeF ProjectileOriginOffsetY { get; set;}

[REDProp("shootOnlyWhenTargetInside")]
public bool ShootOnlyWhenTargetInside { get; set;}

[REDProp("deactivateAutomatically")]
public bool DeactivateAutomatically { get; set;}

[REDProp("useAdvancedDistribution")]
public bool UseAdvancedDistribution { get; set;}

[REDProp("useGridPositioning")]
public bool UseGridPositioning { get; set;}

[REDProp("excludedEntityTags")]
public Array<CName> ExcludedEntityTags { get; set;}

[REDProp("magnetTags")]
public Array<CName> MagnetTags { get; set;}

[REDProp("magnetRange")]
public float MagnetRange { get; set;}

[REDProp("magnetOffset")]
public Vector MagnetOffset { get; set;}

[REDProp("maxDistanceFromPlayer")]
public float MaxDistanceFromPlayer { get; set;}

[REDProp("forbidingAreaRadius")]
public float ForbidingAreaRadius { get; set;}

[REDProp("m_AreaComponent")]
public Handle<CTriggerAreaComponent> M_AreaComponent { get; set;}

[REDProp("m_ProjectilePositionGrid")]
public Array<Vector> M_ProjectilePositionGrid { get; set;}

[REDProp("m_UsedProjectilePosition")]
public Array<Vector> M_UsedProjectilePosition { get; set;}

[REDProp("m_AcceptablePos")]
public Array<Vector> M_AcceptablePos { get; set;}

[REDProp("m_ForbiddenPos")]
public Array<Vector> M_ForbiddenPos { get; set;}

[REDProp("m_LastPlayerCheckedPos")]
public Vector M_LastPlayerCheckedPos { get; set;}

[REDProp("m_LastQuantOfForbidAreas")]
public Int32 M_LastQuantOfForbidAreas { get; set;}

[REDProp("m_GridSquareWidth")]
public float M_GridSquareWidth { get; set;}

[REDProp("m_GridSquareLength")]
public float M_GridSquareLength { get; set;}

[REDProp("m_DelayUntilNextShoot")]
public float M_DelayUntilNextShoot { get; set;}

[REDProp("m_DelayUntilNextPlayerShoot")]
public float M_DelayUntilNextPlayerShoot { get; set;}

[REDProp("m_QuantityShotNext")]
public Int32 M_QuantityShotNext { get; set;}

[REDProp("m_PlayerIsInArea")]
public bool M_PlayerIsInArea { get; set;}

[REDProp("m_TargetsInArea")]
public Array<Handle<CEntity>> M_TargetsInArea { get; set;}

[REDProp("m_CreateEntityHelper")]
public Handle<W3TrapProjectileArea_CreateEntityHelper> M_CreateEntityHelper { get; set;}

[REDProp("m_EntityCreated")]
public Int32 M_EntityCreated { get; set;}

[REDProp("m_WasCreatingLastFrame")]
public bool M_WasCreatingLastFrame { get; set;}

[REDProp("m_Shot")]
public bool M_Shot { get; set;}

[REDProp("m_DebugFloat")]
public float M_DebugFloat { get; set;}

[REDProp("m_DebugIndex")]
public Int32 M_DebugIndex { get; set;}

[REDProp("m_TotalQuantityShot")]
public Int32 M_TotalQuantityShot { get; set;}

#endregion
}
}