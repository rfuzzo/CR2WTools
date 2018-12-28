using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CJournalInitialEntriesResource : CResource
{
#region RED Properties

[REDProp("entries")]
public Array<Handle<CJournalPath>> Entries { get; set;}

[REDProp("regularQuestCount")]
public uint RegularQuestCount { get; set;}

[REDProp("monsterHuntQuestCount")]
public uint MonsterHuntQuestCount { get; set;}

[REDProp("treasureHuntQuestCount")]
public uint TreasureHuntQuestCount { get; set;}

#endregion
}
}