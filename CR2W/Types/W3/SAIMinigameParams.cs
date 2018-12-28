using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SAIMinigameParams 
{
#region RED Properties

[REDProp("wristWrestling")]
public Ptr<CAIMinigameParamsWristWrestling> WristWrestling { get; set;}

#endregion
}
}