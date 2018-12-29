using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_ActorRotationToNode : CQCActorScriptedCondition
{
#region RED Properties

[REDProp("condition")]
public ECompareOp Condition { get; set;}

[REDProp("degrees")]
public float Degrees { get; set;}

[REDProp("targetTag")]
public CName TargetTag { get; set;}

[REDProp("targetNode")]
public Handle<CNode> TargetNode { get; set;}

[REDProp("listener")]
public Handle<W3QuestCond_ActorRotationToNode_Listener> Listener { get; set;}

#endregion
}
}