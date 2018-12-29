using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIMiscreantAttachActionTree : IAICustomActionTree
{
#region RED Properties

[REDProp("attachmentBone")]
public CName AttachmentBone { get; set;}

[REDProp("miscreantName")]
public CName MiscreantName { get; set;}

[REDProp("behaviorGraph")]
public CName BehaviorGraph { get; set;}

#endregion
}
}