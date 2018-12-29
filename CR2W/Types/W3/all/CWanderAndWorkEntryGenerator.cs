using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CWanderAndWorkEntryGenerator : CSpawnTreeBaseEntryGenerator
{
#region RED Properties

[REDProp("nodeName")]
public CName NodeName { get; set;}

[REDProp("id")]
public UInt64 Id { get; set;}

[REDProp("childNodes")]
public Array<Handle<ISpawnTreeBaseNode>> ChildNodes { get; set;}

[REDProp("entries")]
public Array<SWanderAndWorkEntryGeneratorParams> Entries { get; set;}

#endregion
}
}