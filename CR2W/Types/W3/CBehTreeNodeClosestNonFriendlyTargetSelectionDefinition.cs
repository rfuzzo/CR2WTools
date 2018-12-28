using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeClosestNonFriendlyTargetSelectionDefinition : IBehTreeNodeCombatTargetSelectionBaseDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("testDelay")]
public float TestDelay { get; set;}

#endregion
}
}