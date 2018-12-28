using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeSetCustomMoveTargetToInteractionPointDefintion : IBehTreeNodeSetupCustomMoveDataDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("setTargetForEvaluation")]
public bool SetTargetForEvaluation { get; set;}

#endregion
}
}