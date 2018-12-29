using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CJournalTutorial : CJournalChildBase
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

[REDProp("name")]
public LocalizedString Name { get; set;}

[REDProp("image")]
public string Image { get; set;}

[REDProp("video")]
public string Video { get; set;}

[REDProp("description")]
public LocalizedString Description { get; set;}

[REDProp("dlcLock")]
public CName DlcLock { get; set;}

[REDProp("active")]
public bool Active { get; set;}

#endregion
}
}