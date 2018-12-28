using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneGraph : CObject
{
#region RED Properties

[REDProp("graphBlocks")]
public Array<Ptr<CGraphBlock>> GraphBlocks { get; set;}

#endregion
}
}