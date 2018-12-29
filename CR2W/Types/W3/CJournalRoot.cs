using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CJournalRoot : CObject
{
#region RED Properties

[REDProp("objects")]
public Array<Handle<CJournalResource>> Objects { get; set;}

#endregion
}
}