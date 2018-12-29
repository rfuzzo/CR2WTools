using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_ActorSpeed : CQCActorScriptedCondition
{
#region RED Properties

[REDProp("condition")]
public ECompareOp Condition { get; set;}

[REDProp("speed")]
public float Speed { get; set;}

#endregion
}
}