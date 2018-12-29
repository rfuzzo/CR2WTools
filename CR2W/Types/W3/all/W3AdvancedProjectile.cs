using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3AdvancedProjectile : CThrowable
{
#region RED Properties

[REDProp("projSpeed")]
public float ProjSpeed { get; set;}

[REDProp("projAngle")]
public float ProjAngle { get; set;}

[REDProp("projDMG")]
public float ProjDMG { get; set;}

[REDProp("projSilverDMG")]
public float ProjSilverDMG { get; set;}

[REDProp("ignoreArmor")]
public bool IgnoreArmor { get; set;}

[REDProp("projEfect")]
public EEffectType ProjEfect { get; set;}

[REDProp("persistFxAfterCollision")]
public bool PersistFxAfterCollision { get; set;}

[REDProp("dealDamageEvenIfDodging")]
public bool DealDamageEvenIfDodging { get; set;}

[REDProp("ignore")]
public bool Ignore { get; set;}

[REDProp("isActive")]
public bool IsActive { get; set;}

[REDProp("collidedEntities")]
public Array<Handle<CGameplayEntity>> CollidedEntities { get; set;}

[REDProp("lifeSpan")]
public float LifeSpan { get; set;}

#endregion
}
}