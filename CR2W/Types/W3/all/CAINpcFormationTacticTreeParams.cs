using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAINpcFormationTacticTreeParams : CAISubTreeParameters
{
#region RED Properties

[REDProp("formationFollowerAttackAction")]
public Handle<CAIAttackActionTree> FormationFollowerAttackAction { get; set;}

[REDProp("formationLeaderAttackBehavior")]
public Handle<CAIAttackBehaviorTree> FormationLeaderAttackBehavior { get; set;}

#endregion
}
}