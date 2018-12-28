using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSpawnTreeSelectRandomNode : ISpawnTreeCompositeNode
{
#region RED Properties

[REDProp("nodeName")]
public CName NodeName { get; set;}

[REDProp("id")]
public UInt64 Id { get; set;}

[REDProp("childNodes")]
public Array<Ptr<ISpawnTreeBaseNode>> ChildNodes { get; set;}

[REDProp("rerollDelay")]
public GameTime RerollDelay { get; set;}

#endregion
}
}