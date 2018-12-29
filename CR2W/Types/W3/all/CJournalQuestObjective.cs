using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CJournalQuestObjective : CJournalContainer
{
#region RED Properties

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("baseName")]
public string BaseName { get; set;}

[REDProp("order")]
public uint Order { get; set;}

[REDProp("uniqueScriptIdentifier")]
public CName UniqueScriptIdentifier { get; set;}

[REDProp("parentGuid")]
public CGUID ParentGuid { get; set;}

[REDProp("linkedParentGuid")]
public CGUID LinkedParentGuid { get; set;}

[REDProp("index")]
public byte Index { get; set;}

[REDProp("children")]
public Array<Ptr<CJournalContainerEntry>> Children { get; set;}

[REDProp("title")]
public LocalizedString Title { get; set;}

[REDProp("image")]
public string Image { get; set;}

[REDProp("world")]
public uint World { get; set;}

[REDProp("counterType")]
public eQuestObjectiveType CounterType { get; set;}

[REDProp("count")]
public uint Count { get; set;}

[REDProp("mutuallyExclusive")]
public bool MutuallyExclusive { get; set;}

[REDProp("bookShortcut")]
public CName BookShortcut { get; set;}

[REDProp("itemShortcut")]
public CName ItemShortcut { get; set;}

[REDProp("recipeShortcut")]
public CName RecipeShortcut { get; set;}

[REDProp("monsterShortcut")]
public Handle<CJournalPath> MonsterShortcut { get; set;}

#endregion
}
}