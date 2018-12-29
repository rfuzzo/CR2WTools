using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CSStoryPhaseTimetableEntry 
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("actionCategies")]
public Array<CSStoryPhaseTimetableACategoriesTimetableEntry> ActionCategies { get; set;}

#endregion
}
}