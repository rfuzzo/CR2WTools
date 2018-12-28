using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSpawnTree : CResource
{
#region RED Properties

[REDProp("rootNode")]
public Ptr<ISpawnTreeBaseNode> RootNode { get; set;}

[REDProp("creatureDefinition")]
public Array<Ptr<CEncounterCreatureDefinition>> CreatureDefinition { get; set;}

[REDProp("spawnTreeType")]
public ESpawnTreeType SpawnTreeType { get; set;}

#endregion
}
}