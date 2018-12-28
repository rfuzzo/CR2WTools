using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CJournalQuestMapPin : CJournalContainerEntry
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

[REDProp("radius")]
public float Radius { get; set;}

[REDProp("mapPinID")]
public CName MapPinID { get; set;}

[REDProp("type")]
public EJournalMapPinType Type { get; set;}

[REDProp("enabledAtStartup")]
public bool EnabledAtStartup { get; set;}

#endregion
}
}