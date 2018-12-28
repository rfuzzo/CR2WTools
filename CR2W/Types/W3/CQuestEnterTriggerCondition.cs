using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQuestEnterTriggerCondition : CQuestTriggerCondition
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

[REDProp("onAreaEntry")]
public bool OnAreaEntry { get; set;}

#endregion
}
}