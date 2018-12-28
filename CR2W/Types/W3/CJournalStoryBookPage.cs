using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CJournalStoryBookPage : CJournalContainer
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

[REDProp("world")]
public uint World { get; set;}

[REDProp("active")]
public bool Active { get; set;}

#endregion
}
}