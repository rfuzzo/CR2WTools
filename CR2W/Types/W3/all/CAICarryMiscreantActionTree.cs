using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAICarryMiscreantActionTree : IAICustomActionTree
{
#region RED Properties

[REDProp("attachmentBone")]
public CName AttachmentBone { get; set;}

[REDProp("miscreantName")]
public CName MiscreantName { get; set;}

[REDProp("behaviorGraph")]
public CName BehaviorGraph { get; set;}

[REDProp("cryStartEventName")]
public CName CryStartEventName { get; set;}

[REDProp("cryStopEventName")]
public CName CryStopEventName { get; set;}

[REDProp("carrySubAction")]
public Handle<IAIActionTree> CarrySubAction { get; set;}

#endregion
}
}