using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3QuestCond_HasModifier : CQCActorScriptedCondition
{
#region RED Properties

[REDProp("modifier")]
public EEffectType Modifier { get; set;}

[REDProp("timePercents")]
public Int32 TimePercents { get; set;}

[REDProp("condition")]
public ECompareOp Condition { get; set;}

[REDProp("modifierParam1")]
public CName ModifierParam1 { get; set;}

[REDProp("sourceName")]
public CName SourceName { get; set;}

[REDProp("sourceNamePartialSearch")]
public bool SourceNamePartialSearch { get; set;}

#endregion
}
}