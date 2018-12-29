using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSwarmMonitor : IBehTreeTask
{
#region RED Properties

[REDProp("monitorShieldSwarm")]
public bool MonitorShieldSwarm { get; set;}

[REDProp("respawnShieldBirds")]
public bool RespawnShieldBirds { get; set;}

[REDProp("respawnThreshold")]
public float RespawnThreshold { get; set;}

[REDProp("respawnCooldown")]
public float RespawnCooldown { get; set;}

[REDProp("disableBoidPOIComponents")]
public bool DisableBoidPOIComponents { get; set;}

[REDProp("lair")]
public Handle<CFlyingSwarmMasterLair> Lair { get; set;}

[REDProp("boidPOIComponents")]
public Array<Handle<CComponent>> BoidPOIComponents { get; set;}

#endregion
}
}