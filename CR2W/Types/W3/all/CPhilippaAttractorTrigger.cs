using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CPhilippaAttractorTrigger : CGameplayEntity
{
#region RED Properties

[REDProp("actorTagToSendInfo")]
public CName ActorTagToSendInfo { get; set;}

[REDProp("triggeredByPlayer")]
public bool TriggeredByPlayer { get; set;}

[REDProp("triggeredByBolts")]
public bool TriggeredByBolts { get; set;}

[REDProp("triggeredByBombs")]
public bool TriggeredByBombs { get; set;}

[REDProp("actor")]
public Handle<CActor> Actor { get; set;}

[REDProp("lastActivation")]
public float LastActivation { get; set;}

#endregion
}
}