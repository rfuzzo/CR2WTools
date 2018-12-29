using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeNodeSetupCustomMoveTargetToPositionDefinition : IBehTreeNodeSetupCustomMoveDataDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("setTargetForEvaluation")]
public bool SetTargetForEvaluation { get; set;}

[REDProp("target")]
public CBehTreeValVector Target { get; set;}

[REDProp("heading")]
public CBehTreeValFloat Heading { get; set;}

#endregion
}
}