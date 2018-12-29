using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSwarmSpawnAnim : IBehTreeTask
{
#region RED Properties

[REDProp("spawned")]
public bool Spawned { get; set;}

[REDProp("spawnCondition")]
public ESpawnCondition SpawnCondition { get; set;}

[REDProp("lair")]
public Handle<CFlyingSwarmMasterLair> Lair { get; set;}

[REDProp("swarmStabilizeTime")]
public float SwarmStabilizeTime { get; set;}

[REDProp("delayMain")]
public float DelayMain { get; set;}

[REDProp("time")]
public float Time { get; set;}

[REDProp("distToActors")]
public float DistToActors { get; set;}

[REDProp("currTime")]
public float CurrTime { get; set;}

[REDProp("initialTime")]
public float InitialTime { get; set;}

[REDProp("useSwarms")]
public bool UseSwarms { get; set;}

[REDProp("manageGravity")]
public bool ManageGravity { get; set;}

[REDProp("animEventOccured")]
public bool AnimEventOccured { get; set;}

[REDProp("despawnCalled")]
public bool DespawnCalled { get; set;}

[REDProp("raiseEventName")]
public CName RaiseEventName { get; set;}

[REDProp("fxName")]
public CName FxName { get; set;}

[REDProp("initialAppearance")]
public CName InitialAppearance { get; set;}

[REDProp("setAppearanceTo")]
public CName SetAppearanceTo { get; set;}

[REDProp("playFXOnAnimEvent")]
public bool PlayFXOnAnimEvent { get; set;}

[REDProp("res")]
public bool Res { get; set;}

[REDProp("fail")]
public bool Fail { get; set;}

[REDProp("despawn")]
public bool Despawn { get; set;}

[REDProp("animEventNameActivator")]
public CName AnimEventNameActivator { get; set;}

[REDProp("spawnCount")]
public Int32 SpawnCount { get; set;}

#endregion
}
}