using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSpawnTreeBaseEntryGenerator : ISpawnTreeLeafNode
{
#region RED Properties

[REDProp("nodeName")]
public CName NodeName { get; set;}

[REDProp("id")]
public UInt64 Id { get; set;}

[REDProp("childNodes")]
public Array<Handle<ISpawnTreeBaseNode>> ChildNodes { get; set;}

#endregion
}
}