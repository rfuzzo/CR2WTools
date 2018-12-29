using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3BuffImmunityEntity : CGameplayEntity
{
#region RED Properties

[REDProp("immunities")]
public Array<EEffectType> Immunities { get; set;}

[REDProp("range")]
public float Range { get; set;}

[REDProp("isActive")]
public bool IsActive { get; set;}

[REDProp("actorsInRange")]
public Array<Handle<CActor>> ActorsInRange { get; set;}

#endregion
}
}