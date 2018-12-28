using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeDecoratorCompleteInProximityDefinition : IBehTreeNodeDecoratorDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("distance")]
public CBehTreeValFloat Distance { get; set;}

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

/*[REDProp("3D")]
public bool 3D { get; set;}*/

#endregion
}
}