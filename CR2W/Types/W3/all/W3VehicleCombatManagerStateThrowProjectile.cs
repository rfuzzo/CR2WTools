using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3VehicleCombatManagerStateThrowProjectile : W3VehicleCombatManagerStateRangedAttack
{
#region RED Properties

[REDProp("abortThrow")]
public bool AbortThrow { get; set;}

[REDProp("thrownEntity")]
public Handle<CThrowable> ThrownEntity { get; set;}

#endregion
}
}