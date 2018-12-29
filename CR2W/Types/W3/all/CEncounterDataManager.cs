using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CEncounterDataManager : IScriptable
{
#region RED Properties

[REDProp("resetOnFullRespawn")]
public bool ResetOnFullRespawn { get; set;}

[REDProp("disabledCreaturesGroups")]
public Array<CreaturesGroupDef> DisabledCreaturesGroups { get; set;}

[REDProp("killedCreatures")]
public Int32 KilledCreatures { get; set;}

[REDProp("currentlySpawnedCreatures")]
public Int32 CurrentlySpawnedCreatures { get; set;}

[REDProp("spawnedCreatures")]
public Int32 SpawnedCreatures { get; set;}

[REDProp("lostCreatures")]
public Int32 LostCreatures { get; set;}

[REDProp("killedCreaturesByEntry")]
public Array<CreatureCounterDef> KilledCreaturesByEntry { get; set;}

[REDProp("currentlySpawnedCreaturesByEntry")]
public Array<CreatureCounterDef> CurrentlySpawnedCreaturesByEntry { get; set;}

[REDProp("spawnedCreaturesByEntry")]
public Array<CreatureCounterDef> SpawnedCreaturesByEntry { get; set;}

[REDProp("lostCreaturesByEntry")]
public Array<CreatureCounterDef> LostCreaturesByEntry { get; set;}

[REDProp("disbledMonitors")]
public Array<Handle<ISpawnTreeSpawnMonitorInitializer>> DisbledMonitors { get; set;}

[REDProp("ownerTasksToPerform")]
public Array<SOwnerEncounterTaskParams> OwnerTasksToPerform { get; set;}

[REDProp("externalTasksToPerform")]
public Array<SExternalEncounterTaskParams> ExternalTasksToPerform { get; set;}

#endregion
}
}