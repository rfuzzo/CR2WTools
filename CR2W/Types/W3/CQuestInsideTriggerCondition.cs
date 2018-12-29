using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CQuestInsideTriggerCondition : CQuestTriggerCondition
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("active")]
public bool Active { get; set;}

[REDProp("triggerTag")]
public CName TriggerTag { get; set;}

[REDProp("tag")]
public CName Tag { get; set;}

[REDProp("isInside")]
public bool IsInside { get; set;}

#endregion
}
}