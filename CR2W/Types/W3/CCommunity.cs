using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CCommunity : CResource
{
#region RED Properties

[REDProp("communityTable")]
public Array<CSTableEntry> CommunityTable { get; set;}

[REDProp("storyPhaseTimetable")]
public Array<CSStoryPhaseTimetableEntry> StoryPhaseTimetable { get; set;}

[REDProp("spawnsetType")]
public ECommunitySpawnsetType SpawnsetType { get; set;}

#endregion
}
}