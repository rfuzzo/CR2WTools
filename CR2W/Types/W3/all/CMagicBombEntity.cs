using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMagicBombEntity : CGameplayEntity
{
#region RED Properties

[REDProp("damageRadius")]
public float DamageRadius { get; set;}

[REDProp("damageVal")]
public float DamageVal { get; set;}

[REDProp("settlingTime")]
public float SettlingTime { get; set;}

[REDProp("entitiesInRange")]
public Array<Handle<CGameplayEntity>> EntitiesInRange { get; set;}

[REDProp("i")]
public Int32 I { get; set;}

[REDProp("damage")]
public Handle<W3DamageAction> Damage { get; set;}

[REDProp("victim")]
public Handle<CActor> Victim { get; set;}

#endregion
}
}