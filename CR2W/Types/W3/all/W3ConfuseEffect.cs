using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ConfuseEffect : W3CriticalEffect
{
#region RED Properties

[REDProp("drainStaminaOnExit")]
public bool DrainStaminaOnExit { get; set;}

[REDProp("criticalHitBonus")]
public float CriticalHitBonus { get; set;}

#endregion
}
}