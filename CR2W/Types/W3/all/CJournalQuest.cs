using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CJournalQuest : CJournalContainer
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

[REDProp("type")]
public eQuestType Type { get; set;}

[REDProp("contentType")]
public EJournalContentType ContentType { get; set;}

[REDProp("world")]
public uint World { get; set;}

[REDProp("huntingQuestPath")]
public Handle<CJournalPath> HuntingQuestPath { get; set;}

[REDProp("title")]
public LocalizedString Title { get; set;}

[REDProp("questPhase")]
public Soft<CQuestPhase> QuestPhase { get; set;}

#endregion
}
}