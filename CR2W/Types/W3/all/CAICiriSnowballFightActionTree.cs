using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAICiriSnowballFightActionTree : IAICustomActionTree
{
#region RED Properties

[REDProp("minDistFromTargetToPerformTeleport")]
public float MinDistFromTargetToPerformTeleport { get; set;}

[REDProp("delayBetweenThrows")]
public float DelayBetweenThrows { get; set;}

[REDProp("teleportPointTag")]
public CName TeleportPointTag { get; set;}

#endregion
}
}