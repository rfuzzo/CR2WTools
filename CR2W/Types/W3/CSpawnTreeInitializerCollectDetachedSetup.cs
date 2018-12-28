using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSpawnTreeInitializerCollectDetachedSetup : ISpawnTreeInitializer
{
#region RED Properties

[REDProp("id")]
public UInt64 Id { get; set;}

[REDProp("overrideDeepInitializers")]
public bool OverrideDeepInitializers { get; set;}

[REDProp("maximumCollectionDelay")]
public float MaximumCollectionDelay { get; set;}

[REDProp("greedyCollection")]
public bool GreedyCollection { get; set;}

#endregion
}
}