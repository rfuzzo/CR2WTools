using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskMagicCoilAttack : CBTTaskAttack
{
#region RED Properties

[REDProp("fxNames")]
public Array<CName> FxNames { get; set;}

[REDProp("playFxInterval")]
public float PlayFxInterval { get; set;}

[REDProp("shootProjectileRange")]
public float ShootProjectileRange { get; set;}

[REDProp("shootProjectileInterval")]
public float ShootProjectileInterval { get; set;}

[REDProp("deactivateAfter")]
public float DeactivateAfter { get; set;}

[REDProp("setBehVarOnDeactivation")]
public CName SetBehVarOnDeactivation { get; set;}

[REDProp("setBehVarValueOnDeactivation")]
public float SetBehVarValueOnDeactivation { get; set;}

[REDProp("useActorHeading")]
public bool UseActorHeading { get; set;}

[REDProp("activateOnAnimEvent")]
public CName ActivateOnAnimEvent { get; set;}

[REDProp("projResourceName")]
public CName ProjResourceName { get; set;}

[REDProp("fxOnDamageInstigatedQuen")]
public CName FxOnDamageInstigatedQuen { get; set;}

[REDProp("m_collisionGroups")]
public Array<CName> M_collisionGroups { get; set;}

[REDProp("m_projectile")]
public Handle<W3AdvancedProjectile> M_projectile { get; set;}

[REDProp("m_projEntity")]
public Handle<CEntityTemplate> M_projEntity { get; set;}

[REDProp("m_numberOfFxActivated")]
public Int32 M_numberOfFxActivated { get; set;}

[REDProp("m_activated")]
public bool M_activated { get; set;}

#endregion
}
}