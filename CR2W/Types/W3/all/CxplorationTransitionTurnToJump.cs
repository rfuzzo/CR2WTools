using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CxplorationTransitionTurnToJump : CExplorationStateTransitionAbstract
{
#region RED Properties

[REDProp("timeToExit")]
public float TimeToExit { get; set;}

[REDProp("angleToTrigger")]
public float AngleToTrigger { get; set;}

#endregion
}
}