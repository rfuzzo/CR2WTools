using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3FairytaleWitchFluid : CGameplayEntity
{
#region RED Properties

[REDProp("entitiesInRange")]
public Array<Handle<CGameplayEntity>> EntitiesInRange { get; set;}

[REDProp("damageRadius")]
public float DamageRadius { get; set;}

[REDProp("damageVal")]
public float DamageVal { get; set;}

#endregion
}
}