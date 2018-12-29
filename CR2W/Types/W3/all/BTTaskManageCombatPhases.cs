using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskManageCombatPhases : IBehTreeTask
{
#region RED Properties

[REDProp("rangedCombatPhaseParameters")]
public SCombatPhaseParameters RangedCombatPhaseParameters { get; set;}

[REDProp("closeCombatPhaseParameters")]
public SCombatPhaseParameters CloseCombatPhaseParameters { get; set;}

[REDProp("nonCombatPhaseParameters")]
public SCombatPhaseParameters NonCombatPhaseParameters { get; set;}

[REDProp("availableCombatPhasesArray")]
public Array<SCombatPhaseParameters> AvailableCombatPhasesArray { get; set;}

[REDProp("initialCombatPhasesArray")]
public Array<SCombatPhaseParameters> InitialCombatPhasesArray { get; set;}

[REDProp("combatPhasesArray")]
public Array<SCombatPhaseParameters> CombatPhasesArray { get; set;}

[REDProp("setBehVariableName")]
public CName SetBehVariableName { get; set;}

[REDProp("activationEventReceived")]
public float ActivationEventReceived { get; set;}

[REDProp("rangedCombatTimeStamp")]
public float RangedCombatTimeStamp { get; set;}

[REDProp("closeCombatTimeStamp")]
public float CloseCombatTimeStamp { get; set;}

[REDProp("nonCombatTimeStamp")]
public float NonCombatTimeStamp { get; set;}

[REDProp("currentCombatPhase")]
public Int32 CurrentCombatPhase { get; set;}

[REDProp("afterFirstChoice")]
public bool AfterFirstChoice { get; set;}

#endregion
}
}