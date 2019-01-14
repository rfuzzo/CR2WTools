using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class ParticleBurst 
{
#region RED Properties

[REDProp("burstTime")]
public float BurstTime { get; set;}

[REDProp("spawnCount")]
public UInt32 SpawnCount { get; set;}

[REDProp("spawnTimeRange")]
public float SpawnTimeRange { get; set;}

[REDProp("repeatTime")]
public float RepeatTime { get; set;}

#endregion
}
}