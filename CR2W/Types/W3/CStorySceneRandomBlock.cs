using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneRandomBlock : CStorySceneGraphBlock
{
#region RED Properties

[REDProp("sockets")]
public Array<Ptr<CGraphSocket>> Sockets { get; set;}

[REDProp("controlPart")]
public Ptr<CStorySceneRandomizer> ControlPart { get; set;}

#endregion
}
}