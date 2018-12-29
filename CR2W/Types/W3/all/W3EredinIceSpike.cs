using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3EredinIceSpike : W3DurationObstacle
{
#region RED Properties

[REDProp("explodeAfter")]
public float ExplodeAfter { get; set;}

[REDProp("damageRadius")]
public float DamageRadius { get; set;}

[REDProp("damageVal")]
public float DamageVal { get; set;}

[REDProp("effectDuration")]
public float EffectDuration { get; set;}

[REDProp("meshComp")]
public Handle<CMeshComponent> MeshComp { get; set;}

[REDProp("destructionComp")]
public Handle<CDestructionSystemComponent> DestructionComp { get; set;}

[REDProp("entitiesInRange")]
public Array<Handle<CGameplayEntity>> EntitiesInRange { get; set;}

#endregion
}
}