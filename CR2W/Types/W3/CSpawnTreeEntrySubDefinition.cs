using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CSpawnTreeEntrySubDefinition : CObject
{
#region RED Properties

[REDProp("id")]
public UInt64 Id { get; set;}

[REDProp("creatureDefinition")]
public CName CreatureDefinition { get; set;}

[REDProp("partyMemberId")]
public CName PartyMemberId { get; set;}

[REDProp("creatureCount")]
public uint CreatureCount { get; set;}

[REDProp("initializers")]
public Array<Ptr<ISpawnTreeInitializer>> Initializers { get; set;}

#endregion
}
}