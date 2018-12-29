using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskWasInCriticalState : IBehTreeTask
{
#region RED Properties

[REDProp("timeDifference")]
public float TimeDifference { get; set;}

[REDProp("maxTimeDifference")]
public float MaxTimeDifference { get; set;}

[REDProp("criticalState")]
public ECriticalStateType CriticalState { get; set;}

[REDProp("timeOfLastCSDeactivation")]
public float TimeOfLastCSDeactivation { get; set;}

[REDProp("combatDataStorage")]
public Handle<CBaseAICombatStorage> CombatDataStorage { get; set;}

#endregion
}
}