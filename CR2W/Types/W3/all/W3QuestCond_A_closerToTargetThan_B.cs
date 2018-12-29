using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_A_closerToTargetThan_B : CQuestScriptedCondition
{
#region RED Properties

[REDProp("object_A_tag")]
public CName Object_A_tag { get; set;}

[REDProp("object_B_tag")]
public CName Object_B_tag { get; set;}

[REDProp("targetTag")]
public CName TargetTag { get; set;}

[REDProp("listener")]
public Handle<W3QuestCond_A_closerToTargetThan_B_Listener> Listener { get; set;}

[REDProp("object_A")]
public Handle<CNode> Object_A { get; set;}

[REDProp("object_B")]
public Handle<CNode> Object_B { get; set;}

[REDProp("target")]
public Handle<CNode> Target { get; set;}

#endregion
}
}