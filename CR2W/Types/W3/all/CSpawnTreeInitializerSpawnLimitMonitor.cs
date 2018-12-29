using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CSpawnTreeInitializerSpawnLimitMonitor : ISpawnTreeSpawnMonitorBaseInitializer
{
#region RED Properties

[REDProp("id")]
public UInt64 Id { get; set;}

[REDProp("overrideDeepInitializers")]
public bool OverrideDeepInitializers { get; set;}

[REDProp("totalSpawnLimitMin")]
public UInt16 TotalSpawnLimitMin { get; set;}

[REDProp("totalSpawnLimitMax")]
public UInt16 TotalSpawnLimitMax { get; set;}

[REDProp("creatureDefinition")]
public CName CreatureDefinition { get; set;}

[REDProp("resetOnFullRespawn")]
public bool ResetOnFullRespawn { get; set;}

#endregion
}
}