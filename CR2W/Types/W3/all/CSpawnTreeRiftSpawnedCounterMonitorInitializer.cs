using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CSpawnTreeRiftSpawnedCounterMonitorInitializer : ISpawnTreeSpawnMonitorInitializer
{
#region RED Properties

[REDProp("riftTag")]
public CName RiftTag { get; set;}

[REDProp("spawnLimit")]
public Int32 SpawnLimit { get; set;}

#endregion
}
}