using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneGraphSocket : CGraphSocket
{
#region RED Properties

[REDProp("block")]
public Ptr<CGraphBlock> Block { get; set;}

[REDProp("name")]
public CName Name { get; set;}

[REDProp("connections")]
public Array<Ptr<CGraphConnection>> Connections { get; set;}

[REDProp("linkElement")]
public Ptr<CStorySceneLinkElement> LinkElement { get; set;}

#endregion
}
}