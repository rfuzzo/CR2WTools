using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SSpawnStrategyRange 
{
#region RED Properties

[REDProp("spawnRange")]
public float SpawnRange { get; set;}

[REDProp("poolRange")]
public float PoolRange { get; set;}

[REDProp("offset")]
public Vector2 Offset { get; set;}

#endregion
}
}