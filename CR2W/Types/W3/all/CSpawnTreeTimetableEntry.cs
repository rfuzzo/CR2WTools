using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CSpawnTreeTimetableEntry : CSpawnTreeEntryList
{
#region RED Properties

[REDProp("nodeName")]
public CName NodeName { get; set;}

[REDProp("id")]
public UInt64 Id { get; set;}

[REDProp("entries")]
public Array<Ptr<ISpawnTreeBaseNode>> Entries { get; set;}

[REDProp("begin")]
public GameTime Begin { get; set;}

[REDProp("end")]
public GameTime End { get; set;}

#endregion
}
}