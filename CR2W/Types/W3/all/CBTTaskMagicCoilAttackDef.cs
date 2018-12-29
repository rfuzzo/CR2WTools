using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskMagicCoilAttackDef : CBTTaskAttackDef
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

#endregion
}
}