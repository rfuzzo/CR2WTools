using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CFistfightOpponent 
{
#region RED Properties

[REDProp("npcTag")]
public CName NpcTag { get; set;}

[REDProp("startingPosTag")]
public CName StartingPosTag { get; set;}

#endregion
}
}