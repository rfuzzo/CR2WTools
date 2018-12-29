using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3VehicleCombatManagerStateRangedAttack : CScriptableState
{
#region RED Properties

[REDProp("rider")]
public Handle<CR4Player> Rider { get; set;}

[REDProp("aiming")]
public bool Aiming { get; set;}

[REDProp("fire")]
public bool Fire { get; set;}

[REDProp("wasAborted")]
public bool WasAborted { get; set;}

[REDProp("horizontalVal")]
public float HorizontalVal { get; set;}

#endregion
}
}