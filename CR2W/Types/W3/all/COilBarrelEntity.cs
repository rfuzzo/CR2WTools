using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class COilBarrelEntity : CGameplayEntity
{
#region RED Properties

[REDProp("fx_onInteraction")]
public CName Fx_onInteraction { get; set;}

[REDProp("damageRadius")]
public float DamageRadius { get; set;}

[REDProp("damageVal")]
public float DamageVal { get; set;}

[REDProp("explodeAfter")]
public float ExplodeAfter { get; set;}

[REDProp("destroyEntAfter")]
public float DestroyEntAfter { get; set;}

[REDProp("randomizeTime")]
public bool RandomizeTime { get; set;}

[REDProp("onFireDamagePerSec")]
public float OnFireDamagePerSec { get; set;}

[REDProp("isSetOnFire")]
public bool IsSetOnFire { get; set;}

[REDProp("isExploding")]
public bool IsExploding { get; set;}

[REDProp("onFireDamageArea")]
public Handle<CTriggerAreaComponent> OnFireDamageArea { get; set;}

[REDProp("entitiesInOnFireArea")]
public Array<Handle<CGameplayEntity>> EntitiesInOnFireArea { get; set;}

#endregion
}
}