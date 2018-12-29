using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CJournalPath : ISerializable
{
#region RED Properties

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("resource")]
public Soft<CResource> Resource { get; set;}

[REDProp("child")]
public Handle<CJournalPath> Child { get; set;}

#endregion
}
}