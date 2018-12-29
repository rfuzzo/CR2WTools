using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TrapProjectileStatue : W3Trap
{
#region RED Properties

[REDProp("m_Projectile")]
public Handle<CEntityTemplate> M_Projectile { get; set;}

[REDProp("m_IsStatic")]
public bool M_IsStatic { get; set;}

[REDProp("m_RotationSpeed")]
public float M_RotationSpeed { get; set;}

[REDProp("m_FirstShootDelay")]
public float M_FirstShootDelay { get; set;}

[REDProp("m_FireRate")]
public float M_FireRate { get; set;}

[REDProp("m_MaxShots")]
public float M_MaxShots { get; set;}

[REDProp("m_MinAngleToStartShooting")]
public float M_MinAngleToStartShooting { get; set;}

[REDProp("m_MaxAimingPitchCorrection")]
public float M_MaxAimingPitchCorrection { get; set;}

[REDProp("m_TargetPositionPrediction")]
public float M_TargetPositionPrediction { get; set;}

[REDProp("m_ProjectileIsCocked")]
public bool M_ProjectileIsCocked { get; set;}

[REDProp("m_ProjectileSpeed")]
public float M_ProjectileSpeed { get; set;}

[REDProp("m_ProjectileLifeSpan")]
public float M_ProjectileLifeSpan { get; set;}

[REDProp("m_ProjectileFollowTarget")]
public bool M_ProjectileFollowTarget { get; set;}

[REDProp("m_DelayUntilNextProjectile")]
public float M_DelayUntilNextProjectile { get; set;}

[REDProp("m_ShotsLeft")]
public float M_ShotsLeft { get; set;}

[REDProp("m_CockedProjectile")]
public Handle<W3AdvancedProjectile> M_CockedProjectile { get; set;}

[REDProp("m_DelayToNextSorting")]
public float M_DelayToNextSorting { get; set;}

#endregion
}
}