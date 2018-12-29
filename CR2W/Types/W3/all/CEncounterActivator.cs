using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CEncounterActivator : CGameplayEntity
{
#region RED Properties

[REDProp("encounterAreaTag")]
public CName EncounterAreaTag { get; set;}

[REDProp("phaseToActivate")]
public CName PhaseToActivate { get; set;}

[REDProp("disableEncounterOnExit")]
public bool DisableEncounterOnExit { get; set;}

[REDProp("encounter")]
public Handle<CEncounter> Encounter { get; set;}

[REDProp("isPlayerInArea")]
public bool IsPlayerInArea { get; set;}

#endregion
}
}