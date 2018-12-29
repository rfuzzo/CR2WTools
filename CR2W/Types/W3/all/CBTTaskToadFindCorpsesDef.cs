using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskToadFindCorpsesDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("searchRange")]
public float SearchRange { get; set;}

[REDProp("maxResults")]
public Int32 MaxResults { get; set;}

[REDProp("tag")]
public CName Tag { get; set;}

#endregion
}
}