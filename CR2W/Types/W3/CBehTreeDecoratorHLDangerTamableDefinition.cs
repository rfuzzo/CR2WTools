using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeDecoratorHLDangerTamableDefinition : CBehTreeDecoratorHLDangerDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("neutralIsDanger")]
public CBehTreeValBool NeutralIsDanger { get; set;}

#endregion
}
}