using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class DebuffProjectile : W3AdvancedProjectile
{
#region RED Properties

[REDProp("debuffType")]
public EEffectType DebuffType { get; set;}

[REDProp("hitReactionType")]
public EHitReactionType HitReactionType { get; set;}

[REDProp("damageTypeName")]
public CName DamageTypeName { get; set;}

[REDProp("destroyQuen")]
public bool DestroyQuen { get; set;}

[REDProp("customDuration")]
public float CustomDuration { get; set;}

[REDProp("initFxName")]
public CName InitFxName { get; set;}

[REDProp("onCollisionFxName")]
public CName OnCollisionFxName { get; set;}

[REDProp("specialFxOnVictimName")]
public CName SpecialFxOnVictimName { get; set;}

[REDProp("applyDebuffIfNoDmgWasDealt")]
public bool ApplyDebuffIfNoDmgWasDealt { get; set;}

[REDProp("bounceOnVictimHit")]
public bool BounceOnVictimHit { get; set;}

[REDProp("signalDamageInstigatedEvent")]
public bool SignalDamageInstigatedEvent { get; set;}

[REDProp("destroyAfterFloat")]
public float DestroyAfterFloat { get; set;}

[REDProp("stopProjectileAfterCollision")]
public bool StopProjectileAfterCollision { get; set;}

[REDProp("sendGameplayEventToVicitm")]
public CName SendGameplayEventToVicitm { get; set;}

#endregion
}
}