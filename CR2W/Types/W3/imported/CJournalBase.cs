using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CJournalBase : CObject
{
#region RED Properties

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("baseName")]
public string BaseName { get; set;}

[REDProp("order")]
public UInt32 Order { get; set;}

[REDProp("uniqueScriptIdentifier")]
public CName UniqueScriptIdentifier { get; set;}

#endregion
}
}