using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskCarryMiscreant : IBehTreeTask
{
#region RED Properties

[REDProp("attachmentBone")]
public CName AttachmentBone { get; set;}

[REDProp("miscreantName")]
public CName MiscreantName { get; set;}

[REDProp("miscreant")]
public Handle<CActor> Miscreant { get; set;}

#endregion
}
}