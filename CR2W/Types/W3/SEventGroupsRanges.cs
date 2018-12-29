using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SEventGroupsRanges 
{
#region RED Properties

[REDProp("tag")]
public CName Tag { get; set;}

[REDProp("beginIndex")]
public uint BeginIndex { get; set;}

[REDProp("endIndex")]
public uint EndIndex { get; set;}

#endregion
}
}