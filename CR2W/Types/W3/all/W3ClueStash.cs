using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ClueStash : W3MonsterClue
{
#region RED Properties

[REDProp("lootEntityTemplate")]
public Handle<CEntityTemplate> LootEntityTemplate { get; set;}

[REDProp("setInvisibleAppearanceAfterLootingStash")]
public bool SetInvisibleAppearanceAfterLootingStash { get; set;}

[REDProp("showLootPanelImmediately")]
public bool ShowLootPanelImmediately { get; set;}

[REDProp("isStashDisabled")]
public bool IsStashDisabled { get; set;}

[REDProp("stashOpenDelay")]
public float StashOpenDelay { get; set;}

[REDProp("stashSpawnOffset")]
public Vector StashSpawnOffset { get; set;}

[REDProp("lootEntityTag")]
public CName LootEntityTag { get; set;}

[REDProp("currentAppearance")]
public CName CurrentAppearance { get; set;}

[REDProp("lootEntity")]
public Handle<W3Container> LootEntity { get; set;}

[REDProp("lootWasOfferedToPlayer")]
public bool LootWasOfferedToPlayer { get; set;}

[REDProp("stashWasLooted")]
public bool StashWasLooted { get; set;}

#endregion
}
}