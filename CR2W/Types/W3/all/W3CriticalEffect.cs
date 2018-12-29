using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3CriticalEffect : CBaseGameplayEffect
{
#region RED Properties

[REDProp("criticalStateType")]
public ECriticalStateType CriticalStateType { get; set;}

[REDProp("allowedHits")]
public Array<bool> AllowedHits { get; set;}

[REDProp("timeEndedHandled")]
public bool TimeEndedHandled { get; set;}

[REDProp("isDestroyedOnInterrupt")]
public bool IsDestroyedOnInterrupt { get; set;}

[REDProp("canPlayAnimation")]
public bool CanPlayAnimation { get; set;}

[REDProp("blockedActions")]
public Array<EInputActionBlock> BlockedActions { get; set;}

[REDProp("postponeHandling")]
public ECriticalHandling PostponeHandling { get; set;}

[REDProp("airHandling")]
public ECriticalHandling AirHandling { get; set;}

[REDProp("attachedHandling")]
public ECriticalHandling AttachedHandling { get; set;}

[REDProp("onHorseHandling")]
public ECriticalHandling OnHorseHandling { get; set;}

[REDProp("explorationStateHandling")]
public ECriticalHandling ExplorationStateHandling { get; set;}

[REDProp("usesFullBodyAnim")]
public bool UsesFullBodyAnim { get; set;}

#endregion
}
}