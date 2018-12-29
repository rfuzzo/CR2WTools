using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSwarmSpawnAnimDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("useSwarms")]
public bool UseSwarms { get; set;}

[REDProp("manageGravity")]
public bool ManageGravity { get; set;}

[REDProp("spawnCondition")]
public ESpawnCondition SpawnCondition { get; set;}

[REDProp("swarmStabilizeTime")]
public float SwarmStabilizeTime { get; set;}

[REDProp("distToActors")]
public float DistToActors { get; set;}

[REDProp("delayMain")]
public float DelayMain { get; set;}

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

[REDProp("animEventNameActivator")]
public CName AnimEventNameActivator { get; set;}

#endregion
}
}