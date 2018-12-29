using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskWraithManageDoppelgangersDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("killDoppelgangersAtDeath")]
public bool KillDoppelgangersAtDeath { get; set;}

[REDProp("killDoppelgangersAfterTime")]
public float KillDoppelgangersAfterTime { get; set;}

[REDProp("splitEffectEntityTemplate")]
public Handle<CEntityTemplate> SplitEffectEntityTemplate { get; set;}

[REDProp("healthPercentageToRegen")]
public float HealthPercentageToRegen { get; set;}

#endregion
}
}