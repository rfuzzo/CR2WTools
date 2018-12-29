using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SJournalCreatureParams 
{
#region RED Properties

[REDProp("abilities")]
public Array<CName> Abilities { get; set;}

[REDProp("autoEffects")]
public Array<CName> AutoEffects { get; set;}

[REDProp("buffImmunity")]
public CBuffImmunity BuffImmunity { get; set;}

[REDProp("monsterCategory")]
public int MonsterCategory { get; set;}

[REDProp("isTeleporting")]
public bool IsTeleporting { get; set;}

[REDProp("droppedItems")]
public Array<CName> DroppedItems { get; set;}

#endregion
}
}