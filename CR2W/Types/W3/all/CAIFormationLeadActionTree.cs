using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIFormationLeadActionTree : IAIFormationActionTree
{
#region RED Properties

[REDProp("leaderSteering")]
public Handle<CMoveSteeringBehavior> LeaderSteering { get; set;}

[REDProp("reshapeOnMoveAction")]
public bool ReshapeOnMoveAction { get; set;}

[REDProp("leadSubtree")]
public Handle<IAIActionTree> LeadSubtree { get; set;}

#endregion
}
}