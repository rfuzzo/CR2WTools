using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CSpawnTreeAIDespawnInitializer : CSpawnTreeDespawnInitializer
{
#region RED Properties

[REDProp("id")]
public UInt64 Id { get; set;}

[REDProp("overrideDeepInitializers")]
public bool OverrideDeepInitializers { get; set;}

[REDProp("instantDespawnConfiguration")]
public SSpawnTreeDespawnConfiguration InstantDespawnConfiguration { get; set;}

[REDProp("aiDespawnConfiguration")]
public SSpawnTreeAIDespawnConfiguration AiDespawnConfiguration { get; set;}

[REDProp("ai")]
public Handle<CAIDespawnTree> Ai { get; set;}

[REDProp("aiPriority")]
public ETopLevelAIPriorities AiPriority { get; set;}

#endregion
}
}