using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskFlyingSwarmTeleport : CBTTaskTeleport
{
#region RED Properties

[REDProp("lair")]
public Handle<CFlyingSwarmMasterLair> Lair { get; set;}

[REDProp("useAnimations")]
public bool UseAnimations { get; set;}

[REDProp("attackTeleport")]
public bool AttackTeleport { get; set;}

[REDProp("res")]
public bool Res { get; set;}

[REDProp("fail")]
public bool Fail { get; set;}

[REDProp("despawnCalled")]
public bool DespawnCalled { get; set;}

[REDProp("disableBoidPOIComponents")]
public bool DisableBoidPOIComponents { get; set;}

[REDProp("delayVanish")]
public float DelayVanish { get; set;}

[REDProp("fxTime")]
public float FxTime { get; set;}

[REDProp("spawnedBirdCount")]
public Int32 SpawnedBirdCount { get; set;}

[REDProp("boidPOIComponents")]
public Array<Handle<CComponent>> BoidPOIComponents { get; set;}

[REDProp("appearFXLoopInterval")]
public float AppearFXLoopInterval { get; set;}

[REDProp("forcedDespawnTime")]
public float ForcedDespawnTime { get; set;}

#endregion
}
}