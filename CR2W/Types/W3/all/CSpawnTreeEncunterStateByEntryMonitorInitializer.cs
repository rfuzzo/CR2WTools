using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CSpawnTreeEncunterStateByEntryMonitorInitializer : ISpawnTreeSpawnMonitorInitializer
{
#region RED Properties

[REDProp("counterType")]
public EEncounterMonitorCounterType CounterType { get; set;}

[REDProp("referenceValue")]
public Int32 ReferenceValue { get; set;}

[REDProp("operator")]
public EOperator Operator { get; set;}

[REDProp("disableMonitorAfterTasksFinished")]
public bool DisableMonitorAfterTasksFinished { get; set;}

[REDProp("factOnConditionMet")]
public string FactOnConditionMet { get; set;}

[REDProp("ownerEncounterTasks")]
public Array<SOwnerEncounterTaskParams> OwnerEncounterTasks { get; set;}

[REDProp("externalEncounterTasks")]
public Array<SExternalEncounterTaskParams> ExternalEncounterTasks { get; set;}

#endregion
}
}