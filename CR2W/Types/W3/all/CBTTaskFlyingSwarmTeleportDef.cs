using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskFlyingSwarmTeleportDef : CBTTaskTeleportDef
{
#region RED Properties

[REDProp("useAnimations")]
public bool UseAnimations { get; set;}

[REDProp("spawnedBirdCount")]
public Int32 SpawnedBirdCount { get; set;}

[REDProp("delayVanish")]
public float DelayVanish { get; set;}

[REDProp("forcedDespawnTime")]
public float ForcedDespawnTime { get; set;}

[REDProp("appearFXLoopInterval")]
public float AppearFXLoopInterval { get; set;}

[REDProp("disableBoidPOIComponents")]
public bool DisableBoidPOIComponents { get; set;}

#endregion
}
}