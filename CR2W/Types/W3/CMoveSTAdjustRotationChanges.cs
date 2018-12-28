using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSTAdjustRotationChanges : IMoveSteeringTask
{
#region RED Properties

[REDProp("scenario")]
public EAdjustRotationChangesScenario Scenario { get; set;}

#endregion
}
}