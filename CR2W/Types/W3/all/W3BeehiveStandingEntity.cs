using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3BeehiveStandingEntity : W3AnimatedContainer
{
#region RED Properties

[REDProp("damageVal")]
public SAbilityAttributeValue DamageVal { get; set;}

[REDProp("actorsInRange")]
public Array<Handle<CActor>> ActorsInRange { get; set;}

[REDProp("wasInteracted")]
public bool WasInteracted { get; set;}

#endregion
}
}